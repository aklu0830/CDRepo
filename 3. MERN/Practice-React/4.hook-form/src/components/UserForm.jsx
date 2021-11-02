import React, {useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import '../App.css';


const UserForm = () => {
    const [username, setUsername] = useState("");
    const [usernameError, setUsernameError] = useState("");
    const [email, setEmail] = useState("");
    const [emailError, setEmailError] = useState("")
    const [password, setPassword] = useState("");
    const [passwordError, setPasswordError] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");
    const [confirmPasswordError, setConfirmPasswordError] = useState("");
    const [firstName, setFirstName] = useState("");
    const [firstNameError, setFirstNameError] = useState("");
    const [lastName, setLastName] = useState("");
    const [lastNameError, setLastNameError] = useState("");
    const [hasBeenSubmitted, setHasBeenSubmitted] = useState(false);
    const [hasBeenSubmittedMSG, setHasBeenSubmittedMSG] = useState("");


    const createUser = (e) => {
        e.preventDefault()
        const newUser = {username, email, password, firstName};
        console.log("Welcome", newUser);
        setHasBeenSubmitted(true)
    };

    const handleSubmit = () => {
        if (hasBeenSubmitted) {
            setHasBeenSubmittedMSG("Thanks for submitting!")
        } else {
            setHasBeenSubmittedMSG("")
        }

    };

    const handleUsername = (e) => {
        setUsername(e.target.value);
        if (e.target.value.length < 1) {
            setUsernameError("Username is required");
        } else if(e.target.value.length < 3) {
            setUsernameError("Username must be atleast 3 characters");
        } else {
            setUsernameError("")
        }

    }

    const handleEmail = (e) => {
        setEmail(e.target.value);
        if (e.target.value.length < 1) {
            setEmailError("Email is required")
        } else if (e.target.value.length < 3) {
            setEmailError("Email must be 3 characters or greater");
        } else {
            setEmailError("")
        }
    }

    const handlePassword = (e) => {
        setPassword(e.target.value);
        if (e.target.value.length < 1) {
            setPasswordError("Password is required")
        } else if (e.target.value.length < 8) {
            setPasswordError("Password must be 3 characters or greater");
        } else {
            setPasswordError("")
        }

    }

    const handleConfirmPassword = (e) => {
        setConfirmPassword(e.target.value);
        if (e.target.value !== password) {
            setConfirmPasswordError("Passwords don't match")
        } else {
            setConfirmPasswordError("")
        }
    }
    const handleFirstName = (e) => {
        setFirstName(e.target.value);
        if (e.target.value.length < 1) {
            setFirstNameError("First name is required")
        } else {
            setFirstNameError("")
        }
    }

    const handleLastName = (e) => {
        setLastName(e.target.value);
        if(e.target.value < 1) {
            setLastNameError("Last name is required")
        } else {
            setLastNameError("");
        }
    }

    return (
        <form onSubmit={createUser}>
            <div className="form-group">
                <label>Username: </label>
                <input className="form-control" type="text" onChange={handleUsername}/>
                {
                    usernameError ?
                        <p style={{color: 'red'}}>{usernameError}</p>:
                        ''
                }
            </div>
            <div className="form-group">
                <label>Email Address: </label>
                <input className="form-control" type="text" onChange={handleEmail}/>
                {
                    emailError ?
                        <p style={{color: 'red'}}>{emailError}</p> :
                        ''
                }
            </div>
            <div className="form-group">
                <label>Password: </label>
                <input className="form-control" type="text" onChange={handlePassword}/>
                {
                   passwordError ?
                       <p style={{color: 'red'}}>{passwordError}</p> :
                       ''
                }
            </div>
            <div className="form-group">
                <label>Confirm Password: </label>
                <input className="form-control" type="text" onChange={handleConfirmPassword}/>
                {
                    confirmPasswordError ?
                        <p style={{color: 'red'}}>{confirmPasswordError}</p> :
                        ''
                }
            </div>
            <div className="form-group">
                <label>First Name: </label>
                <input className="form-control" type="text" onChange={handleFirstName}/>
            </div>
            <div className="form-group">
                <label>Last Name: </label>
                <input className="form-control" type="text" onChange={handleLastName}/>
                {
                    lastNameError ?
                        <p className="alert alert-danger"> {lastNameError}</p>:
                            ''
                }
            </div>
            <input className="btn btn-primary" type="submit" onSubmit={handleSubmit} value="Create User"/>
            {
                hasBeenSubmittedMSG ?
                    <p className="alert alert-success">{hasBeenSubmittedMSG}</p>:
                    ''
            }
        </form>
    );
};

export default UserForm;