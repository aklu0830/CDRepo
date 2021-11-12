const mongoose = require('mongoose');

const PetSchema = new mongoose.Schema({
    petType: {type: String, required: true},
    petName: {type: String, required: true},
    skillone: {type: String, required: true},
    skilltwo: {type: String, required: true},
    skillthree: {type: String, required: true}

}, {timestamps: true})

const Pet = mongoose.model('pet', PetSchema);

module.exports.Pet = Pet;