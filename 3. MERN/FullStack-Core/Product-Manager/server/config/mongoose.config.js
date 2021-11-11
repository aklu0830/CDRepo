const mongoose = require('mongoose');

mongoose.connect('mongodb://localhost/Testing', {
    useNewUrlParser: true,
    useUnifiedTopology: true
})
    .then(() => console.log("connection established"))
    .catch(err => console.log("database connection failure", err))