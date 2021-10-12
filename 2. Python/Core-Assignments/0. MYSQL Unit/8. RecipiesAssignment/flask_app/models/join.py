from operator import sub

import flask_bcrypt
from flask import flash, session

from flask_app.config.mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
from flask_app import app
import re

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

bcrypt = Bcrypt(app)

dbname = 'recipes'


# model the class after the friend table from our database
class JoinedData:
    def __init__(self, data):
        self.id = data['users.id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.user_created_at = data['users.created_at']
        self.user_updated_at = data['users.updated_at']
        self.id = data['recipes.id']
        self.recipe_name = data['name']
        self.description = data['description']
        self.instructions = data['instructions']
        self.under30 = data['under30']
        self.recipe_created_at = data['recipes.created_at']
        self.recipe_updated_at = data['recipes.updated_at']
        self.recipe_user_id = data['user_id']

    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "SELECT *, recipes.* from users JOIN recipes ON users.id = recipes.user_id;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL(dbname).query_db(query)
        # Create an empty list to append our instances of friends
        userlist = []
        # Iterate over the db results and create instances of friends with cls.
        for user in results:
            userlist.append(cls(user))
            print(user)
        return userlist

