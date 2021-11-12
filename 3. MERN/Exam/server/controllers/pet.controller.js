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
    const {petType, petName, skillOne, skillTwo, skillThree} = req.body;
    Pet.create({
        petType,
        petName,
        skillOne,
        skillTwo,
        skillThree
    })
        .then(pettt=>res.json({pettt}))
        .catch(err=>res.json(err))

}

module.exports.UpdatePet = (req, res) => {
    Pet.updateOne({_id: req.params.id}, req.body, {new: true})
        .then(results=> res.json({pet: results}))
        .catch(error=>console.log(error))

}

module.exports.DeletePet = (req, res) => {
    Pet.deleteOne({_id: req.params.id})
        .then(results => res.json({results}))

}

