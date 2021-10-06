from flask import render_template, session, request, redirect
from flask_app import app


from flask_app.models import dojo, ninja


@app.route('/dojos')
def hello_world():

    return render_template('dojos.html')


if __name__ == '__main__':
    app.run()
