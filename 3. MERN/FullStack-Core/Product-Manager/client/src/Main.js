import 'bootstrap/dist/css/bootstrap.min.css'
import React, {useEffect, useState} from "react";
import axios from 'axios';
import CreateProduct from "./components/CreateProduct";
import {
    BrowserRouter,
    Link,
    Switch,
    Route,
    useParams
} from "react-router-dom";
import ListProducts from "./components/ListProducts";
import ShowProductInfo from "./components/ShowProductInfo";
import UpdateProduct from "./components/UpdateProduct";


export default (props) => {
    const [products, setProducts] = useState([])
    const [product, setProduct] = useState([])
    const [isLoaded, setIsLoaded] = useState(false);

    useEffect(() => {
        axios.get('http://localhost:8000/api/products')
            .then(response => {
                setProducts(response.data.products)
            })
            .then(setIsLoaded(true))
            .catch(err => console.log(err))


    }, [])

    return (
        <h2>
            <BrowserRouter>
                <Switch>
                    <Route path='/products/update/:id' component={UpdateProduct}/>

                    <Route path='/products/create'>
                        <div>
                            <CreateProduct initialFormData={{}}/>
                        </div>
                    </Route>
                    <Route path='/products/:id' component={ShowProductInfo}/>
                    <Route path='/'>
                        <div>
                            <ListProducts isLoaded={isLoaded} products={products}/>
                        </div>
                    </Route>

                </Switch>

            </BrowserRouter>
        </h2>
    )

}