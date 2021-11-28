const {Pet} = require('../models/pet.model')


module.exports.ViewAllPets = (req, res) => {
    Pet.find()
        .then(results=>res.json({pets: results}))
        .catch(err=>console.log(err))
}


module.exports.ViewOnePet = (req, res) => {
    Pet.findOne({_id: req.params.id})
        .then(results=>res.json({pet: results}))
        .catch(err=>console.log(err))

}

module.exports.createPet = (req, res) => {
    const {petType, petName, petDescription, skillOne, skillTwo, skillThree} = req.body;
    Pet.create({
        petType,
        petName,
        petDescription,
        skillOne,
        skillTwo,
        skillThree
    })
        .then(pet=>res.json(pet))
        .catch(err=>res.json({errors: err}));

}

module.exports.UpdatePet = (req, res) => {
    Pet.updateOne({_id: req.params.id}, req.body, {new: true})
        .then(results=> res.json({pet: results}))
        .catch(error=>res.json({errors: error}))

}

module.exports.DeletePet = (req, res) => {
    Pet.deleteOne({_id: req.params.id})
        .then(results => res.json({results}))

}

