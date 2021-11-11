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