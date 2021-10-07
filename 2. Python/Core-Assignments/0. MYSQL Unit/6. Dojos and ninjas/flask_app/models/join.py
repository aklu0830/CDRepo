
from flask_app.config.mysqlconnection import connectToMySQL


# model the class after the friend table from our database
class Ninja:
    def __init__(self, data):
        self.ninja_id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.age = data['age']
        self.ninjacreated_at = data['created_at']
        self.ninjaupdated_at = data['updated_at']
        self.ninja_dojo_id = data['dojo_id']
        self.dojo_id = data['dojos.id']
        self.dojo_name = data['name']
        self.dojocreated_at = data['dojos.created_at']
        self.dojoupdated_at = data['dojos.updated_at']


    # Now we use class methods to query our database
    @classmethod
    def getstudents(cls, datat):
        query = "select *, dojos.* from ninjas JOIN dojos ON ninjas.dojo_id = dojos.id where dojo_id=%(dojo_id)s;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('dojos_and_ninjas').query_db(query, datat)
        # Create an empty list to append our instances of friends
        userlist = []
        # Iterate over the db results and create instances of friends with cls.
        for dojo in results:
            print(dojo)
            userlist.append(cls(dojo))
        return userlist
