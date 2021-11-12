import 'bootstrap/dist/css/bootstrap.min.css'
import React, {useEffect, useState} from "react";

import axios from "axios";

import {
    BrowserRouter,
    Link,
    Switch,
    Route,
    useParams
} from "react-router-dom";
import ListPets from "./components/Pets/ListPets";
import CreatePet from "./components/Pets/CreatePet";



export default (props) => {

        return (
            <h2>
                <BrowserRouter>
                    <Switch>
                        <Route path='/pets/create' component={CreatePet}/>
                        <Route path='/' component={ListPets}/>

                    </Switch>

                </BrowserRouter>
            </h2>
        )

}