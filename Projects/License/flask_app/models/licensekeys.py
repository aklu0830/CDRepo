from operator import sub

import flask_bcrypt
from flask import flash, session

from flask_app.config.mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
from flask_app import app
import re

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

bcrypt = Bcrypt(app)

dbname = 'licenses'


# model the class after the friend table from our database
class Api_Keys:
    def __init__(self, data):
        self.id = data['id']
        self.license_key = data['license_key']
        self.server_ip= data['server_ip']
        self.api_key_id = data['api_key_id']

    # Now we use class methods to query our database
    @classmethod
    def get_all(cls, data):
        query = "select * from license_keys where api_key_id=%(apikey_id)s;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL(dbname).query_db(query, data)
        # Create an empty list to append our instances of friends
        apikey_list = []
        # Iterate over the db results and create instances of friends with cls.
        for key in results:
            apikey_list.append(cls(key))
            print(key)
        return apikey_list

    @classmethod
    def createlicensekey(self, data):
        pswhash = bcrypt.generate_password_hash(data['password'])

        query = f'insert into users(first_name, last_name, email, password, created_at, updated_at) values(%(first_name)s,%(last_name)s,%(email)s, "{pswhash}", now(), now());'

        send = connectToMySQL(dbname).query_db(query, data)

        return

    @classmethod
    def droplicensekey(self, data):
        query = "delete from users where id=%(id)s;"

        send = connectToMySQL(dbname).query_db(query, data)

        return

    @classmethod
    def getlicensekey(cls, data):
        query = "select * from users where id=%(email)s;"

        send = connectToMySQL(dbname).query_db(query, data)

        return send[0]
