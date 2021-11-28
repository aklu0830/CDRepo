const PetController = require('../controllers/pet.controller');

module.exports = app => {
    app.get('/api/pets/', PetController.ViewAllPets);
    app.get('/api/pets/info/:id', PetController.ViewOnePet);
    app.post('/api/pets/create', PetController.createPet);
    app.put('/api/pets/update/:id', PetController.UpdatePet);
    app.delete('/api/pets/delete/:id', PetController.DeletePet)
}