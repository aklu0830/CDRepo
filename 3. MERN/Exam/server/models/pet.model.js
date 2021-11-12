const mongoose = require('mongoose');

const PetSchema = new mongoose.Schema({
    petType: {type: String},
    petName: {type: String},
    skillOne: {type: String},
    skillTwo: {type: String},
    skillThree: {type: String}

}, {timestamps: true})

const Pet = mongoose.model('pets', PetSchema);

module.exports.Pet = Pet;