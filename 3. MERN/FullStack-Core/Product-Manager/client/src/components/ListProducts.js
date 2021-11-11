import React from "react";
import axios from 'axios';

const ListProducts = (props) => {
    return (
        <div>
            {props.products.map((product, num) => {
                return <h3 key={num}>{product.title}</h3>
            })}
        </div>
    )
}

export default ListProducts;