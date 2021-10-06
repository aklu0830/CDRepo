from flask import Flask, render_template, session, request, redirect

from user import User
app = Flask(__name__)


@app.route('/')
def hello_world():  # put application's code here
    return redirect("/users")

@app.route("/users")
def userspage():
    users = User.get_all()
    return render_template('userpage.html', users=users)

@app.route("/users/new", methods=['POST', 'GET'])
def createuser():

    return render_template('createuser.html')

@app.route("/process", methods=['POST'])
def createuseraction():

    data = {"fname" : request.form['first_name'], "lname" : request.form['last_name'], "eml" : request.form['email']}

    User.createusr(data)
    return redirect("/users")

@app.route("/users/")
def red():
    return redirect("/users")

@app.route("/rmuser/<int:usrid>")
def deluser(usrid):
    User.dropuser(usrid)
    return redirect('/users')



if __name__ == '__main__':
    app.run()
