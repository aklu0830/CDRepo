import React, {useState} from 'react';
import '../App.css'


const MoreForms = (props) => {
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");

    const mkUser = (e) => {
        e.preventDefault();
        const newUser = {firstName, lastName, email, password, confirmPassword};
        console.log("Welcome", newUser)

    }

    return (

        <form>
            <div className={"form-control"}>
                <label className="labelss">First Name: </label>
                <input type="text" onChange={(e) => setFirstName(e.target.value)}/>
                <label className="labelss">Last Name: </label>
                <input type="text" onChange={(e) => setLastName(e.target.value)}/>
            </div>
        </form>

    );


};


export default MoreForms