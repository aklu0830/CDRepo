from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user, recipe, join


@app.route("/")
def mainpage():
    if ('loggedIN') in session:
        print("Key Exists")
    else:
        session['loggedIN'] = False
        session['user_id'] = ""
        session['first_name'] = ""

    return render_template('login.html')


@app.route("/makeuser", methods=['GET', 'POST'])
def makeuser():
    data = {"first_name": request.form['first_name'], "last_name": request.form['last_name'],
            "email": request.form['email'], "password": request.form['password'],
            "confirm-password": request.form['confirm-password']}

    if not user.User.regvalidate(data):
        return redirect('/')
    else:
        user.User.createusr(data)
    return redirect('/')


@app.route('/login', methods=['POST', 'GET'])
def login():
    data = {"email": request.form['email'], "password": request.form['password']}

    if not user.User.loginvalidate(data):
        return redirect('/')

    elif not user.User.login(data):
        flash(u"Login has failed", 'login')
        return redirect('/')
    else:
        session['loggedIN'] = True
        return redirect('/dashboard')


@app.route("/logout")
def logout():
    session['loggedIN'] = False
    session.clear()
    return redirect('/')


@app.route("/dashboard")
def dashboard():
    data = recipe.Recipe.get_all()

    if not session['loggedIN']:
        return render_template('404.html')
    else:
        return render_template('welcomepage.html', data=data)


@app.route('/new/recipe')
def newRecipePage():
    return render_template('addrecipe.html')


@app.route('/createrecipe', methods=['GET', 'POST'])
def makerecipe():
    data = {'name': request.form['name'], 'description': request.form['description'],
            'instructions': request.form['instructions'], 'date_made': request.form['date'],
            'under30': request.form['under30'],
            'user_id': request.form['user_id']}
    recipe.Recipe.createrecipe(data)

    return redirect('/')


if __name__ == '__main__':
    app.run()
