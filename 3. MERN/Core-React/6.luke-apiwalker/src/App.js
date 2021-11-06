import React, {useState} from "react";
import {Form} from "react-bootstrap";
import {
    BrowserRouter,
    Link,
    Switch,
    Route,
    useParams
} from "react-router-dom";
import FormPage from "./components/FormPage";
import DataOutput from "./components/DataOutput";


const Home = (props) => {
    return (
        <h1 style={{color: "red"}}>Home Component</h1>
    );
}

const About = (props) => {
    return (
        <h1 style={{color: "blue"}}>About Component</h1>
    );
}

const Location = (props) => {
    const {city} = useParams();
    return (
        <h1>Welcome to {city}</h1>
    );
}


function App() {
    return (
        <div className="App">
            <BrowserRouter>
                <Switch>
                    <Route path='/'>
                        <div>
                            <FormPage/>
                        </div>
                    </Route>
                </Switch>
                <Switch>
                    <Route path='/:datatype/:id'>
                        <div>
                            <DataOutput/>
                        </div>
                    </Route>
                </Switch>

            </BrowserRouter>


        </div>
    );
}

export default App;