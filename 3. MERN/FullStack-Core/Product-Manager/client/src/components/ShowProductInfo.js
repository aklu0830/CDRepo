import React, {useEffect, useState} from "react";
import axios from 'axios';
import '../ShowProductInfo.css'





const ShowProductInfo = ({match}) => {
    const [productInfo, setProductInfo] = useState([]);

    useEffect(() => {
        axios.get(`http://localhost:8000/api/products/${match.params.id}`)
            .then(resp=>setProductInfo(resp.data.product))

    }, [])
    return(
        <div className='showStuff'>
            <h2 className='showStuff'>Product Name: {productInfo.title}</h2>
            <h2 className='showStuff'>Price: ${productInfo.price}</h2>
            <h2 className='showStuff'>Description: {productInfo.description}</h2>
        </div>
    )
}

export default ShowProductInfo;