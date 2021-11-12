import React, {useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../Form.css'
import axios from "axios";
import {useHistory} from "react-router-dom";


const CreateProduct = (props) => {
    const {initialFormData, submitCallBack} = props
    const [formInfo, setFormInfo] = useState(initialFormData)
    const history = useHistory();

    const submitHandler = (e) => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/products/create',
            formInfo
        )
            .then(()=> history.push('/'))
            .catch(err=>console.log(err))

    }

    const changeHandler = (e) => {
        setFormInfo({
            ...formInfo,
            [e.target.name]: e.target.value
        })

    }

    return (
        <form className='form-sizing'>
            <div className='form-group'>
                <label>Title</label>
                <input name='title' onChange={changeHandler} type='text' className='form-control'/>
                <label>Price</label>
                <input name='price' onChange={changeHandler} type='text' className='form-control'/>
                <label>Description</label>
                <input name='description' onChange={changeHandler} type='text' className='form-control'/>
            </div>
            <input type='submit' className='btn btn-success' value='Create Product' onClick={submitHandler}/>
        </form>
    )

}

export default CreateProduct;