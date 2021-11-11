import React, {useEffect, useState} from "react";
import axios from 'axios';


export default (props) => {
    const [products, setProducts] = useState([])

    useEffect(() => {
        axios.get('http://localhost:8000/api/products')
            .then(response => {
                setProducts(response.data.products)

            })
            .catch(err => console.log(err))


    }, [])
    return(
        <h2>
            {products.map((item, index) => {
                return(
                    <div>
                        <h2>Name: {item.title}</h2>
                        <h6>Price: {item.price}</h6>
                        <h6>Description: {item.description}</h6>
                    </div>

                )

            })}
        </h2>
    )

}