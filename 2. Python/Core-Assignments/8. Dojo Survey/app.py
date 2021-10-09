from flask import Flask, render_template, session, request, redirect


app = Flask(__name__)

app.secret_key = 'stuff'


@app.route('/')
def index():  # put application's code here
    if ('Name', 'Location', 'Language', 'Comments') in session:
        print("Key's Exist")
    else:
        session['Name'] = ""
        session['Location'] = ""
        session['Language'] = ""
        session['Comments'] = ""
    return render_template('index.html')


@app.route('/process', methods=['POST', 'GET'])
def process():
    session['Name'] = request.form['Name']
    session['Location'] = request.form['Location']
    session['Language'] = request.form['Language']
    session['Comments'] = request.form['Comments']

    return redirect('/result')


@app.route('/result', methods=['POST', 'GET'])
def result():
    name = session['Name']
    location = session['Location']
    language = session['Language']
    comments = session['Comments']

    return render_template('result.html', name=name, location=location, language=language, comments=comments)





if __name__ == '__main__':
    app.run()
