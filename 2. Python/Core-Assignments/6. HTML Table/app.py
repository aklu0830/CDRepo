from flask import Flask, render_template

app = Flask(__name__)

user_info = [
    {'first_name': 'Michael', 'last_name': 'Choi'},
    {'first_name': 'John', 'last_name': 'Supsupin'},
    {'first_name': 'Mark', 'last_name': 'Guillen'},
    {'first_name': 'KB', 'last_name': 'Tonel'}
]


@app.route('/')
def hello_world():  # put application's code here
    return 'Home Page'


@app.route('/list')
def list():
    return render_template('index.html', users=user_info, users_length=len(user_info))


if __name__ == '__main__':
    app.run()
