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

    const Submit = (e) => {

        return (
            <BrowserRouter>
                <Switch>

                </Switch>
            </BrowserRouter>
        )

    }


    return (
        <div className="TopBar">

            <b>Search For:</b>
            <select className='form-select-sm size'>
                <option selected>People</option>
                <option>Planets</option>
                <option>Starships</option>
            </select>
            <b>ID: </b>
            <input type='text'/>
            <input type='submit' className='btn btn-primary' value='Submit Button'/>
        </div>
    );


}

export default FormPage