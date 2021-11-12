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



export default (props) => {
    const [pets, setPets] = useState([])
    const [isLoaded, setIsLoaded] = useState(false);

    useEffect(() => {
        axios.get('http://localhost:8000/api/pets/')
            .then(response => {
                setPets(response.data.pets)
            })
            .then(setIsLoaded(true))
            .catch(err => console.log(err))


    }, [])

    if (isLoaded === false) {
        return (
            <h2>Page is currently Loading</h2>
        )
    } else {
        return (
            <h2>
                <BrowserRouter>
                    <Switch>
                        <Route path='/'>
                            <h2>Tesst</h2>
                        </Route>

                    </Switch>

                </BrowserRouter>
            </h2>
        )
    }

}