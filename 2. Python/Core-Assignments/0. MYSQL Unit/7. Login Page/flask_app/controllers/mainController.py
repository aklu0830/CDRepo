from flask import render_template, session, request, redirect
from flask_app import app


@app.route("/")
def mainpage():
    return render_template('login.html')

@app.route("/dashboard")
def dashboard():
    return render_template('welcomepage.html')




if __name__ == '__main__':
    app.run()