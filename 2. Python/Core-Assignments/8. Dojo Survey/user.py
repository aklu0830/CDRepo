import this

from mysqlconnection import connectToMySQL


# model the class after the friend table from our database
class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']


    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select * from users;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('dojo_survey').query_db(query)
        # Create an empty list to append our instances of friends
        userlist = []
        # Iterate over the db results and create instances of friends with cls.
        for user in results:
            userlist.append(cls(user))
            print(user)
        return userlist

    @classmethod
    def createusr(self, data):
        query = "insert into users(first_name, last_name, email, created_at, updated_at) values(%(fname)s,%(lname)s,%(eml)s, now(), now());"

        send = connectToMySQL('dojo_survey').query_db(query, data)

        return

    @classmethod
    def dropuser(self, usrid):
        query = f"delete from users where id={usrid};"

        send = connectToMySQL('dojo_survey').query_db(query)

        return

    @classmethod
    def getuser(cls, data):
        print(data)
        query = "select * from users where id=%(user_id)s;"

        send = connectToMySQL('dojo_survey').query_db(query, data)

        return send[0]

    @classmethod
    def savechanges(self, data):

        query = "update users set first_name = %(first_name)s, last_name = %(last_name)s, email = %(email)s, updated_at=now() where id=%(userid)s"

        send = connectToMySQL('dojo_survey').query_db(query, data)

        return

    @staticmethod
    def validate():
        if len(User)
