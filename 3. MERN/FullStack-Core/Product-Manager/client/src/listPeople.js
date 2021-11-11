import React from "react";

export default props => {
    return (
        <div>
            {props.products.map((product, num) => {
                return <h3 key={num}>{product.title}</h3>
            })}
        </div>
    )
}