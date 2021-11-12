const mongoose = require('mongoose');

mongoose.connect('mongodb://localhost/Exam', {
    useNewUrlParser: true,
    useUnifiedTopology: true
})
    .then(() => console.log("connection established"))
    .catch(err => console.log("database connection failure", err))