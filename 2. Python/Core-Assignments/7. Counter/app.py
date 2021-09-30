from flask import Flask, render_template, request, redirect, session

app = Flask(__name__)
app.secret_key = 'me.webdevelopment.sucksatcareer'



@app.route('/')
def index():  # put application's code here
    if 'count' in session:
        session['count'] += 1
    else:
        session['count'] = 1
    return render_template('index.html', sessionc=session['count'])


@app.route('/count', methods=['POST', 'GET'])
def submit():
    
    return redirect('/')


@app.route('/reset', methods=['GET'])
def reset():
    session.clear()
    return redirect('/')


if __name__ == '__main__':
    app.run()
