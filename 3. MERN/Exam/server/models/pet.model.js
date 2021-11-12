const mongoose = require('mongoose');

const PetSchema = new mongoose.Schema({
    petType: {
        type: String,
        minlength: [3, 'Must be at least 3 characters'],
        required: [true, 'Field is required']
    },
    petName: {type: String,
        minlength: [3, 'Pet name must be at least 3 characters'],
        required: [true, 'Pet name is required']
    },
    petDescription: {type: String,
        minlength: [3, 'Description must be at least 3 characters'],
        required: [true, 'Description is required']
    },
    skillOne: {type: String},
    skillTwo: {type: String},
    skillThree: {type: String}

}, {timestamps: true})

const Pet = mongoose.model('pets', PetSchema);

module.exports.Pet = Pet;