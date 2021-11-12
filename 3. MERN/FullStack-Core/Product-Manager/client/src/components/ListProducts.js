import React from "react";
import '../ListProduct.css'
import axios from 'axios';

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
                                <td>{product.title}</td>
                                <td>{product.price}</td>
                                <td>{product.description}</td>
                                <td><button className='btn btn-primary'>View Product Info</button><button className='btn btn-danger'>Delete User</button></td>
                            </tr>

                        )
                    })}


                </tbody>

            </table>
        </div>


    )
}

export default ListProducts;