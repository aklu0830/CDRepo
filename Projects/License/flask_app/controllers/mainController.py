from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user


@app.route("/")
def mainPage():

    if 'logged_in' in session:
        return "Welcome"
    else:
        session['logged_in'] = False
        session['user_id'] = ""
        session['license_id'] = ""
        session['api_id'] = ""

    return "Main Page"

@app.errorhandler(404)
def page_not_found(e):
    return render_template('404.html')
