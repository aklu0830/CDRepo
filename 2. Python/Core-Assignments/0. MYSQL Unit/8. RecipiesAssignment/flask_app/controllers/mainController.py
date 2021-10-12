from flask import render_template, session, request, redirect, flash
from flask_app import app
from flask_app.models import user

@app.route('/')
def test():
    return 'shit'


if __name__ == '__main__':
    app.run()
