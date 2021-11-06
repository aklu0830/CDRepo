import React, {useState} from "react";
import '../FormCSS.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import './DataOutput'

import {
    BrowserRouter,
    Link,
    Switch,
    Route,
    useParams
} from "react-router-dom";
import DataOutput from "./DataOutput";

const FormPage = (props) => {
    const [dataType, setDataType] = useState('');
    const [id, setID] = useState('');

    const Submit = (e) => {

        return (
            <BrowserRouter>
                <Switch>

                </Switch>
            </BrowserRouter>
        )

    }

    const handleChange = (e) => {

        e.preventDefault();
        setDataType(e.target.value)


    }

    const handleChangeNum = (e) => {
        e.preventDefault();
        setID(e.target.value)
    }

    const ass = () => {
        console.log(dataType + " " + id)
    }


    return (

        <div className="TopBar">

            <b>Search For:</b>
            <select onChange={handleChange} className='form-select-sm size'>
                <option value='people' onChange={handleChange}>People</option>
                <option value='planets'  onChange={handleChange}>Planets</option>
            </select>
            <b>ID: </b>
            <input type='text' onChange={handleChangeNum}/>
            <form>
                <input type='submit' className='btn btn-primary' formAction={dataType+"/"+id} value='Submit Button'/>
            </form>

        </div>
    );


}

export default FormPage