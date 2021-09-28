from flask import Flask, render_template  # Import Flask to allow us to create our app

app = Flask(__name__)  # Create a new instance of the Flask class called "app"


@app.route('/')  # The "@" decorator associates this route with the function immediately following
def hello_world():
    return ''  # Return the string 'Hello World!' as a response

@app.route('/hello/<int:num>/<string:color>')
def hello(num, color):
    return render_template('index.html', num=num, color=color)

@app.route('/hello')
def hellotwo():
    return render_template('index.html', num=7, color='rebeccapurple')



if __name__ == "__main__":
    app.run(debug=True)



