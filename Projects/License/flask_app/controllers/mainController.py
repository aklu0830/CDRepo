from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user, apikeys, licensekeys
from random import random, randrange, randint


@app.route("/")
def mainPage():
    session['logged_in'] = False
    session['user_id'] = ""
    session['license_id'] = ""
    session['api_id'] = ""
    session['viewingLicenses'] = False

    return render_template("homepage.html")


@app.route("/register")
def register():
    return render_template("registration.html")


@app.route("/makeuser", methods=['POST', 'GET'])
def mkuser():
    data = {"first_name": request.form['first_name'], "last_name": request.form['last_name'],
            "email": request.form['email'], "username": request.form['username'], "password": request.form['password'],
            "confirm-password": request.form['confirm-password']}
    if not user.User.regvalidate(data):
        return redirect("register")
    else:
        user.User.createusr(data)
        return redirect("login")


@app.route("/login")
def login():
    return render_template("login.html")


@app.route("/logout")
def logout():
    session['logged_in'] = False
    session.clear()
    return redirect("/")


@app.route("/processlogin", methods=['GET', 'POST'])
def processlogin():
    data = {"email": request.form['email'], "password": request.form['password']}
    if not user.User.loginvalidate(data):
        return redirect("/login")
    elif not user.User.login(data):
        flash(u"Login has failed", 'login')
        return redirect("/login")
    else:
        session['logged_in'] = True
        return redirect("dashboard")


@app.route("/dashboard")
def dashboard():
    apilist = apikeys.Api_Keys.get_all()
    if not session['logged_in']:
        return redirect("/login")
    else:
        return render_template("dashboard.html", apilist=apilist)


@app.route("/toggleviewlicense", methods=['POST', 'GET'])
def viewlicense():
    if not session['viewingLicenses']:
        session['viewingLicenses'] = True
        session['api_id'] = request.form['apikey_id']

        return redirect("/licensekeys")
    else:
        session['viewingLicenses'] = False
        session['api_id'] = ""
        return redirect("/dashboard")


@app.route("/licensekeys")
def showkeys():
    data = {"apikey_id": session['api_id']}
    lic = licensekeys.License_Keys.get_all(data)
    product_name = apikeys.Api_Keys.getapikey(data)
    return render_template("licenses.html", lic=lic, product_name=product_name)


@app.route("/makeproduct")
def makeproduct():
    if not session['logged_in']:
        return redirect("/login")
    else:
        return render_template("createproduct.html")


@app.route("/createproduct")
def createproduct():
    makeapikey = randint(400000, 2000000)
    data = {"product_name": request.form['product_name'], "apikey": f"api-{makeapikey}", "user_id": session['user_id']}

    if not apikeys.Api_Keys.validatecreation(data):
        return redirect("/makeproduct")
    else:
        apikeys.Api_Keys.createapikey(data)
        return redirect("/dashboard")


@app.errorhandler(404)
def page_not_found(e):
    return render_template('404.html')
