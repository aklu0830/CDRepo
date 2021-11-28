const JokesController = require('../controllers/jokes.controller');

module.exports = app => {
    app.get('/api/jokes', JokesController.findAll)
    app.get('/api/jokes/:id', JokesController.findAJoke);
    app.post('/api/jokes/make', JokesController.createJoke)
    app.put('/api/jokes/update/:id', JokesController.updateJoke)
    app.delete('/api/jokes/delete/:id', JokesController.deleteJoke)

}