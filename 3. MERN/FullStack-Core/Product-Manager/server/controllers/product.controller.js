const {Product} = require('../models/product.model');

module.exports.getAllProducts = (req,res) => {
    Product.find()
        .then(result=>res.json({products: result}))
        .catch(err=>res.json({error: err}))
}

module.exports.createProduct = (req, res) => {
    const {title, price, description} = req.body;
    Product.create({
        title,
        price,
        description
    })
        .then(product=>res.json({product}))
        .catch(err=>res.json(err))

}

module.exports.getProduct = (req, res) => {
    Product.findOne({_id: req.params.id})
        .then(results=> res.json({message: results}))
        .catch(error=>console.log(error))
}

module.exports.updateProduct = (req, res) => {
    Product.updateOne({_id: req.params.id}, req.body, {new: true})
        .then(results=> res.json({message: results}))
        .catch(error => console.log(error))
}