import React, {useEffect, useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../Form.css'
import axios from "axios";
import {useParams, useHistory} from "react-router-dom";



const UpdateProduct = (props) => {
    const history = useHistory();
    const {id} = useParams()
    let [loaded, setLoaded] = useState(false)
    const {initialFormData, submitCallBack} = props
    const [formInfo, setFormInfo] = useState(initialFormData)

    const submitHandler = (e) => {
        e.preventDefault()
        axios.put('http://localhost:8000/api/products/update/'+id, formInfo)
            .then(()=> history.push('/'))
            .catch(err=>console.log(err))

    }

    useEffect(()=> {
        axios.get('http://localhost:8000/api/products/'+id)
            .then(resp=>setFormInfo(resp.data.product))
            .then(() => setLoaded(true))
            .catch(error=>console.log(error))
    }, [])

    const changeHandler = (e) => {
        setFormInfo({
            ...formInfo,
            [e.target.name]: e.target.value
        })

    }

    if (loaded === false) {
        return(
            <div>Loading</div>
        )
    } else {
        return (
            <form className='form-sizing'>
                <div className='form-group'>
                    <label>Title</label>
                    <input name='title' onChange={changeHandler} type='text' className='form-control' value={formInfo.title}/>
                    <label>Price</label>
                    <input name='price' onChange={changeHandler} type='text' className='form-control' value={formInfo.price}/>
                    <label>Description</label>
                    <input name='description' onChange={changeHandler} type='text' className='form-control' value={formInfo.description}/>
                </div>
                <input type='submit' className='btn btn-success' value='Update Product' onClick={submitHandler}/>
            </form>
        )
    }

}

export default UpdateProduct;