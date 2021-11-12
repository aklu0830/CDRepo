import React, {useState} from "react";
import '../ListProduct.css'
import axios from 'axios';
import {useParams, useHistory, Link} from "react-router-dom";

const ListProducts = (props) => {
    let loaded = props.isLoaded
    const history = useHistory();
    const {removeFromDom} = props;


    const removeProduct = (id) => {

        axios.delete('http://localhost:8000/api/products/delete/'+id)
            .then(()=> history.push('/'))
            .catch(err=>console.log(err));
    }

    if (loaded === false) {
        return (
            <div>Page data is loading</div>
        )
    } else {
        return (
            <div>
                <table className='table table-dark list-sizing'>
                    <thead>
                    <tr>
                        <th>Product Name</th>
                        <th>Price</th>
                        <th>Description</th>
                        <th>Options</th>
                    </tr>

                    </thead>
                    <tbody>

                    {props.products.map((product, num) => {
                        return (
                            <tr>
                                <td>{product.title}</td>
                                <td>{product.price}</td>
                                <td>{product.description}</td>

                                <td><Link to={`/products/update/${product._id}`}
                                          className='btn btn-warning'>Edit</Link><Link to={`/products/${product._id}`}
                                                                                       className='btn btn-primary'>Product
                                    Information</Link><Link to='/' onClick={() => removeProduct(product._id)}
                                                            className='btn btn-danger'>Remove Product</Link></td>
                            </tr>

                        )
                    })}


                    </tbody>

                </table>
            </div>


        )
    }
}

export default ListProducts;