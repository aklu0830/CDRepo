from flask import Flask, render_template

app = Flask(__name__)


@app.route('/')
def hello_world():  # put application's code here
    return render_template('index.html')


@app.route('/checkerboard/<int:width>/<int:length>/<string:colorone>/<string:colortwo>')
def cb(length, width, colorone, colortwo):
    return render_template('index.html', length=length, width=width, colorone=colorone, colortwo=colortwo)


if __name__ == '__main__':
    app.run()
