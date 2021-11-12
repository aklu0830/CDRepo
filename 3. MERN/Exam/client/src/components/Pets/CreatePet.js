import React, {useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../CreatePet.css'
import axios from "axios";
import {useHistory} from "react-router-dom";


const CreateProduct = (props) => {
    const {initialFormData, submitCallBack} = props
    const [formInfo, setFormInfo] = useState(initialFormData)
    const history = useHistory();

    const submitHandler = (e) => {
        e.preventDefault();
        axios.post('http://localhost:8000/api/pets/create',
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
                <label>Pet Type</label>
                <input name='petType' onChange={changeHandler} type='text' className='form-control'/>
                <label>Name</label>
                <input name='petName' onChange={changeHandler} type='text' className='form-control'/>
                <label>Skill 1</label>
                <input name='skillOne' onChange={changeHandler} type='text' className='form-control'/>
                <label>Skill 2</label>
                <input name='skillTwo' onChange={changeHandler} type='text' className='form-control'/>
                <label>Skill 3</label>
                <input name='skillThree' onChange={changeHandler} type='text' className='form-control'/>
            </div>
            <input type='submit' className='btn btn-success' value='Add Pet' onClick={submitHandler}/>
        </form>
    )

}

export default CreateProduct;