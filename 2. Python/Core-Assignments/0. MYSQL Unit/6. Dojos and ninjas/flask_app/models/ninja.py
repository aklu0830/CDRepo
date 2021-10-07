
from flask_app.config.mysqlconnection import connectToMySQL


# model the class after the friend table from our database
class Ninja:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.age = data['age']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.dojo_id = data['dojo_id']


    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select * from ninjas;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('dojos_and_ninjas').query_db(query)
        # Create an empty list to append our instances of friends
        userlist = []
        # Iterate over the db results and create instances of friends with cls.
        for user in results:
            userlist.append(cls(user))
            print(user)
        return userlist

    @classmethod
    def createninja(self, data):
        query = "insert into ninjas(first_name, last_name, age, created_at, updated_at, dojo_id) values(%(first_name)s,%(last_name)s,%(age)s, now(), now(), %(dojo_id)s);"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return

    @classmethod
    def removeninjauser(self, data):
        query = f"delete from ninjas where id=%(ninja_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query ,data)

        return

    @classmethod
    def getuser(cls, data):
        print(data)
        query = "select * from ninjas where id=%(ninja_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return send[0]

    @classmethod
    def savechanges(self, data):

        query = "update ninjas set first_name = %(first_name)s, last_name = %(last_name)s, age = %(age)s, updated_at=now() where id=%(userid)s"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return
