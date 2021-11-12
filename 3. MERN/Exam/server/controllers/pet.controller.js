const {Pet} = require('../models/pet.model')


module.exports.ViewAllPets = (req, res) => {
    Pet.find()
        .then(results=>res.json({pets: results}))
        .catch(err=>console.log(err))
}


module.exports.ViewOnePet = (req, res) => {
    Pet.findOne({_id: req.body.id})
        .then(results=>res.json({pet: results}))
        .catch(err=>console.log(err))

}

module.exports.CreatePet = (req, res) => {

}

module.exports.UpdatePet = (req, res) => {

}

module.exports.DeletePet = (req, res) => {

}

