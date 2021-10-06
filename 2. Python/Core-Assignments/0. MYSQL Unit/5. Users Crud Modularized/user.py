from mysqlconnection import connectToMySQL
# model the class after the friend table from our database
class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.created_at = data["DATE_FORMAT(created_at, '%W %M %d %Y')"]
        self.updated_at = data["DATE_FORMAT(updated_at, '%W %M %d %Y')"]
    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select *, DATE_FORMAT(updated_at, '%W %M %d %Y'), DATE_FORMAT(created_at, '%W %M %d %Y') from users;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('userscr').query_db(query)
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

        send = connectToMySQL('userscr').query_db(query, data)

        return

    @classmethod
    def dropuser(self, usrid):
        query = f"delete from users where id={usrid};"

        send = connectToMySQL('userscr').query_db(query)

        return

    @classmethod
    def getuser(cls, usrid):
        query = f"select * from users where id={usrid};"
