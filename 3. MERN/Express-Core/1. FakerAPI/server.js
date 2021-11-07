const express = require('express');
const app = express();
const faker = require('faker');
const port = 8000;

class User {
    constructor() {
        this.name = faker.name.findName();
    }
}

console.log(User().name)

app.listen( port, () => console.log(`Listening on port: ${port}`) );