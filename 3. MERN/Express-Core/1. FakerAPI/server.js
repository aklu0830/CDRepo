const express = require('express');
const app = express();
const faker = require('faker');
const port = 8000;

class User {
    constructor() {
        this.id = faker.datatype.number();
        this.name = faker.name.findName();


    }
}
class Company {
    constructor() {
        this.id = faker.datatype.number();
        this.name = faker.company.companyName();
    }
}

class MixClass {
    constructor() {
    }
}

usr = new User();
cmp = new Company();

const UsersOb =[
    {user_id: usr.id, name: usr.name}


];

const CompanyOb =[
    {company_id: cmp.id, companyName: cmp.name}

]

const MixerOb = [
    {company_id: cmp.id, companyName: cmp.name},
    {user_id: usr.id, name: usr.name}
]

console.log(usr.name)


app.get("/api/users/new", (req, res) => {
    res.json(UsersOb)
})

app.get("/api/companies/new", (req, res)=> {
    res.json(CompanyOb)
})

app.get("/api/user/company", (req, res) => {
    res.json(MixerOb)
})

app.listen( port, () => console.log(`Listening on port: ${port}`) );