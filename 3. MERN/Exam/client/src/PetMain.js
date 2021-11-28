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
import UpdatePet from "./components/Pets/UpdatePet";
import ShowPetInfo from "./components/Pets/ShowPetInfo";



export default (props) => {

        return (
            <h2>
                <BrowserRouter>
                    <Switch>
                        <Route path='/pets/info/:id' component={ShowPetInfo}/>
                        <Route path='/pets/update/:id' component={UpdatePet}/>
                        <Route path='/pets/create' component={CreatePet}/>
                        <Route path='/' component={ListPets}/>


                    </Switch>

                </BrowserRouter>
            </h2>
        )

}