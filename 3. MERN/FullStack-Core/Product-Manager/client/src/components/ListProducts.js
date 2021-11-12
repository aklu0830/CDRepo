import React from "react";
import '../ListProduct.css'
import axios from 'axios';
import {Link} from "react-router-dom";

const ListProducts = (props) => {
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
                                <td >{product.title}</td>
                                <td >{product.price}</td>
                                <td >{product.description}</td>

                                <td><Link to={`/products/update/${product._id}`} className='btn btn-warning'>Edit</Link><Link to={`/products/${product._id}`} className='btn btn-primary'>Product Information</Link><Link className='btn btn-danger'>Remove Product</Link></td>
                            </tr>

                        )
                    })}


                </tbody>

            </table>
        </div>


    )
}

export default ListProducts;