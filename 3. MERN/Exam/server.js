const express = require('express');
const cors = require('cors')
const app = express();

require('./server/config/mongoose.config')

const port = 8000;
app.use(cors());
app.use(express.json())
app.use(express.urlencoded({extended: true}))

const productRouteRegistration = require('./server/routes/product.routes');
const petRouteRegistration = require('./server/routes/pet.routes');

petRouteRegistration(app)
productRouteRegistration(app)



app.listen(port, () => console.log(`Listening on port ${port}`))