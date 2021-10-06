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
    data = {"fname": request.form['first_name'], "lname": request.form['last_name'], "eml": request.form['email']}

    User.createusr(data)
    return redirect("/users")


@app.route("/users/")
def red():
    return redirect("/users")


@app.route("/rmuser/<int:usrid>")
def deluser(usrid):
    User.dropuser(usrid)
    return redirect('/users')


@app.route("/users/edit/<int:user_id>", methods=['GET'])
def editusr(user_id):
    datat = {"user_id": user_id}
    userinfo = User.getuser(datat)
    print(userinfo)
    return render_template("edituser.html", userinfo=userinfo, user_id=user_id)


@app.route("/userupdate/<int:userid>", methods=['GET', 'POST'])
def saveedits(userid):
    first_name = request.form['first_name']
    last_name = request.form['last_name']
    email = request.form['email']
    data = {"userid": userid, "first_name": first_name, "last_name": last_name, "email": email}
    User.savechanges(data)
    return redirect('/users')

@app.route("/users/show/<int:uid>")
def showuser(uid):
    data = {"user_id": uid}
    userinfo = User.getuser(data)
    return render_template('showuser.html', userinfo=userinfo, uid=uid)



if __name__ == '__main__':
    app.run()
