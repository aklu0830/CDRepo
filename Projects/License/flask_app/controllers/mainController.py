from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user


@app.route("/")
def mainPage():

    if len(session)==0:
        return "Welcome"
    else:
        session['logged_in'] = False
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
    if not session['logged_in']:
        return render_template("login.html")
    else:
        return render_template("")


@app.errorhandler(404)
def page_not_found(e):
    return render_template('404.html')
