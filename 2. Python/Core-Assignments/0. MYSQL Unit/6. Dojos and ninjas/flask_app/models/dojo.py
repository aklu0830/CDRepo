from flask_app.config.mysqlconnection import connectToMySQL

class Dojo:
    def __init__(self, data):
        self.id = data['id']
        self.name= data['name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']


    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select * from users;"
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
    def createdojo(self, data):
        query = "insert into users(name, created_at, updated_at) values(%(name)s, now(), now());"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return

    @classmethod
    def dropdojo(self, data):

        query = f"delete from users where id=%(dojo_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return

    @classmethod
    def getuser(cls, data):
        print(data)
        query = "select * from users where id=%(user_id)s;"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return send[0]

    @classmethod
    def savechanges(self, data):

        query = "update users set name = %(dojo_name)s, updated_at=now() where id=%(dojo_id)s"

        send = connectToMySQL('dojos_and_ninjas').query_db(query, data)

        return
