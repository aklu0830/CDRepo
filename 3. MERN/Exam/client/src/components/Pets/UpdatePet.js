import React, {useEffect, useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../CreatePet.css'
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
        axios.put('http://localhost:8000/api/pets/update/'+id, formInfo)
            .then(()=> history.push('/'))
            .catch(err=>console.log(err))

    }

    useEffect(()=> {
        axios.get('http://localhost:8000/api/pets/info/'+id)
            .then(resp=>setFormInfo(resp.data.pet))
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
                    <label>Pet Type</label>
                    <input name='petType' onChange={changeHandler} type='text' className='form-control' value={formInfo.petType}/>
                    <label>Name</label>
                    <input name='petName' onChange={changeHandler} type='text' className='form-control' value={formInfo.petName}/>
                    <label>Pet Description</label>
                    <input name='petDescription' onChange={changeHandler} type='text' className='form-control' value={formInfo.petDescription}/>
                    <label>Skill 1</label>
                    <input name='skillOne' onChange={changeHandler} type='text' className='form-control' value={formInfo.skillOne}/>
                    <label>Skill 2</label>
                    <input name='skillTwo' onChange={changeHandler} type='text' className='form-control' value={formInfo.skillTwo}/>
                    <label>Skill 3</label>
                    <input name='skillThree' onChange={changeHandler} type='text' className='form-control' value={formInfo.skillThree}/>
                </div>
                <input type='submit' className='btn btn-success' value='Update Product' onClick={submitHandler}/>
            </form>
        )
    }

}

export default UpdateProduct;