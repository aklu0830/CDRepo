const Jokes = require('../models/jokes.model')
const e = require("express");

module.exports.findAll = (req, res) => {
    Jokes.find()
        .then(allJokes => res.json({jokes: allJokes}))
        .catch(err=> res.json({message: "Error has occured", error: err}))
}

module.exports.findAJoke = (req, res) => {
    Jokes.findOne({_id: req.params.id})
        .then(results => res.json({jokes: results}))
        .catch(err => res.json({message: "Error", error: err}))
}

module.exports.createJoke = (req, res) => {
    Jokes.create(req.body)
        .then(jokeData => res.json({joke: jokeData}))
        .catch(err => res.json({message: "Error", error: err}))
}

module.exports.updateJoke = (req, res) => {
    Jokes.updateOne({_id: req.params.id}, req.body, {new:true})
        .then(jokeData => res.json({joke: jokeData}))
        .catch(err => res.json({message: "Error", error:err}))
}

module.exports.deleteJoke = (req, res) => {
    Jokes.deleteOne({_id: req.params.id})
        .then(results => res.json({message: results}))
        .catch(err => res.json({message: "Error deleting joke", error: err}))
}