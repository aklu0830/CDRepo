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
class Recipe:
    def __init__(self, data):
        self.id = data['id']
        self.name = data['name']
        self.description = data['description']
        self.instructions = data['instructions']
        self.under30 = data['under30']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.user_id = data['user_id']

    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "select * from recipes;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL(dbname).query_db(query)
        # Create an empty list to append our instances of friends
        userlist = []
        # Iterate over the db results and create instances of friends with cls.
        for user in results:
            userlist.append(cls(user))
            print(user)
        return userlist

    @classmethod
    def createrecipe(self, data):
        query = 'insert into recipes(`name`, `description`, `instructions`, `under30`, `created_at`, `updated_at`, `user_id`) values(%(name)s, %(description)s,%(instructions)s,%(under30)s,%(date_made)s, curdate(), %(user_id)s);'

        send = connectToMySQL(dbname).query_db(query, data)

        return

    @classmethod
    def droprecipe(self, data):
        query = "delete from recipes where id=%(recipeid)s;"

        send = connectToMySQL(dbname).query_db(query, data)

        return

    @classmethod
    def getrecipe(cls, data):
        query = "select * from recipes where id=%(recipeid)s;"

        send = connectToMySQL(dbname).query_db(query, data)

        if len(send) < 1:
            pass
        else:

            return send[0]

    @classmethod
    def updaterecipe(cls, data):
        query = "update recipes set `name`=%(name)s, `description`=%(description)s, `instructions`=%(instructions)s, `under30`=%(under30)s, `created_at`=%(date_made)s, `updated_at`=now() where id=%(recipeid)s;"

        send = connectToMySQL(dbname).query_db(query, data)

        return send

    @staticmethod
    def validations(data):
        is_valid = True
        if len(data['name']) < 1:
            flash(u'Name field cannot be empty', 'col-1')
            is_valid = False
        if len(data['description']) < 5:
            flash(u'Description must be at least 5 characters', 'col-1')
            is_valid = False
        
        return is_valid
