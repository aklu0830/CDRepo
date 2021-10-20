from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user, apikeys


@app.route("/")
def mainPage():

    if len(session)==0:
        return "Welcome"
    else:
        session['logged_in'] = True
        session['user_id'] = ""
        session['license_id'] = ""
        session['api_id'] = ""
    return render_template("homepage.html")

@app.route("/register")
def register():
    return render_template("registration.html")

@app.route("/login")
def login():
    return render_template("login.html")

@app.route("/dashboard")
def dashboard():
    apilist = apikeys.Api_Keys.get_all()
    if not session['logged_in']:
        return redirect("/login")
    else:
        return render_template("dashboard.html", apilist=apilist)


@app.errorhandler(404)
def page_not_found(e):
    return render_template('404.html')
