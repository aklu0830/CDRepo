const mongoose = require('mongoose');

const PetSchema = new mongoose.Schema({
    petType: {type: String, minlength:3, required: true},
    petName: {type: String, minlength:3, required:true},
    petDescription: {type: String, minlength:3, required:true},
    skillOne: {type: String},
    skillTwo: {type: String},
    skillThree: {type: String}

}, {timestamps: true})

const Pet = mongoose.model('pets', PetSchema);

module.exports.Pet = Pet;