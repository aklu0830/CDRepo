from flask import render_template, session, request, redirect
from flask_app import app
from flask_app.models import dojo, ninja, join



@app.route("/")
def home():
    return redirect("/dojos")


@app.route('/dojos')
def listdojos():
    return render_template('dojos.html', dojos=dojo.Dojo.get_all())

@app.route('/makedojo', methods=['POST','GET'])
def makedojo():


    data = {'name': request.form['name']}
    if not dojo.Dojo.validate(request.form):
        return redirect('/')
    print(data['name'])
    dojo.Dojo.createdojo(data)

    return redirect('/dojos')


@app.route("/addninja")
def addninja():


    dojoslist = dojo.Dojo.get_all()


    return render_template('addninja.html', dojoslist=dojoslist)

@app.route("/makeninja", methods=['POST','GET'])
def makeninja():
    data = {"dojo_id": request.form['location'], "first_name": request.form['first_name'], "last_name": request.form['last_name'], "age": request.form['age']}
    ninja.Ninja.createninja(data)

    return redirect('/dojos')


@app.route("/dojo/<int:dojo_id>")
def showninjas(dojo_id):
    data = {"dojo_id": dojo_id}
    dojolocation = dojo.Dojo.getdojo(data)
    dataset = join.Ninja.getstudents(data)
    print(dataset)
    return render_template('dojostudents.html', dataset=dataset, dojolocation=dojolocation)




@app.errorhandler(404)
def page_not_fount(e):
    return render_template('404.html'), 404


if __name__ == '__main__':
    app.run()
