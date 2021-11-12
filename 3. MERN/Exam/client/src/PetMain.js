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



export default (props) => {

        return (
            <h2>
                <BrowserRouter>
                    <Switch>
                        <Route path='/' component={ListPets}/>

                    </Switch>

                </BrowserRouter>
            </h2>
        )

}