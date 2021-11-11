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


export default (props) => {
    const [products, setProducts] = useState([])

    useEffect(() => {
        axios.get('http://localhost:8000/api/products')
            .then(response => {
                setProducts(response.data.products)

            })
            .catch(err => console.log(err))


    }, [])
    return (
        <h2>
            <BrowserRouter>
                <Switch>
                    <Route path='/products/create'>
                        <div>
                            <CreateProduct initialFormData={{}}/>
                        </div>
                    </Route>
                    <Route path='/products'>
                        <div>
                            <ListProducts products={products}/>
                        </div>
                    </Route>

                </Switch>

            </BrowserRouter>
        </h2>
    )

}