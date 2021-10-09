from flask import flash

from flask_app.config.mysqlconnection import connectToMySQL

class Dojo:
    def __init__(self, data):
        self.dojo_id = data['id']
        self.dojo_name = data['name']
        self.dojo_created_at = data['created_at']
        self.dojo_updated_at = data['updated_at']


    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select * from dojos;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('dojos_and_ninjas').query_db(query)
        # Create an empty list to append our instances of friends
        dojolist = []
        # Iterate over the db results and create instances of friends with cls.
        for dojo in results:
            print(dojo)
            dojolist.append(cls(dojo))
        return dojolist

    @classmethod
    def createdojo(self, data):
        query = "insert into dojos(name, created_at, updated_at) values(%(name)s, now(), now());"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return

    @classmethod
    def dropdojo(self, data):

        query = f"delete from dojos where dojos.id=%(dojo_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return

    @classmethod
    def getdojo(cls, data):
        print(data)
        query = "select * from dojos where id=%(dojo_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return send[0]

    @classmethod
    def savechanges(self, data):

        query = "update dojos set name = %(dojo_name)s, updated_at=now() where id=%(dojo_id)s"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return


    @staticmethod
    def validate(dojo):
        is_valid = True
        if len(dojo['name']) < 3:
            flash("Name must be at least 3 characters.")
            is_valid = False
        return is_valid

