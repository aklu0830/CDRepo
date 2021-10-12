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
        session['editing'] = False
        session['recid'] = ''

    if session['loggedIN']:
        return redirect('/dashboard')

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
    session['editing'] = False

    if not session['loggedIN']:
        return render_template('404.html')
    else:
        return render_template('welcomepage.html', data=data)


@app.route('/new/recipe')
def newRecipePage():
    return render_template('addrecipe.html')


@app.route('/createrecipe', methods=['GET', 'POST'])
def makerecipe():
    data = {'name': request.form['recipe_name'], 'description': request.form['description'],
            'instructions': request.form['instructions'], 'date_made': request.form['date'],
            'under30': request.form['underthirty'],
            'user_id': session['user_id']}
    recipe.Recipe.createrecipe(data)

    return redirect('/dashboard')


@app.route('/show/<int:recipe_id>')
def showrecipe(recipe_id):
    data = {'recipeid': recipe_id}

    rec = recipe.Recipe.getrecipe(data)

    return render_template('showrecipe.html', rec=rec)


@app.route('/delete', methods=['GET', 'POST'])
def removeRecipe():
    data = {'recipeid': request.form['delete']}

    recipe.Recipe.droprecipe(data)

    return redirect('/dashboard')


@app.route('/toggleEdit', methods=['GET', 'POST'])
def toggleEditStatus():
    if not session['editing']:
        session['editing'] = True
        recid = request.form['edit']
        return redirect('/edit/' + recid)
    else:
        session['recid'] = ""
        session['editing'] = False
        return redirect('dashboard')


@app.route('/edit')
def edit1():
    return redirect('/')


@app.route('/edit/')
def edit2():
    return redirect('/')


@app.route('/edit/<int:recipeid>', methods=['GET', 'POST'])
def editRecipe(recipeid):
    if not session['editing']:
        return redirect('/dashboard')

    data = {'recipeid': recipeid}
    session['recid'] = data['recipeid']
    print(f"REC ID IS {session['recid']}")

    rec = recipe.Recipe.getrecipe(data)

    return render_template('editrecipe.html', rec=rec)


@app.route('/applychanges', methods=['POST', 'GET'])
def applychanges():
    data = {'name': request.form['recipe_name'], 'description': request.form['description'],
            'instructions': request.form['instructions'], 'under30': request.form['underthirty'],
            'date_made': request.form['date'], 'recipeid': session['recid']}
    recid = data['recipeid']
    if not recipe.Recipe.validations(data):
        return redirect(f'/edit/{recid}')

    recipe.Recipe.updaterecipe(data)

    return redirect('/dashboard')


if __name__ == '__main__':
    app.run()
