import React, {useEffect, useState} from "react";
import axios from "axios";
import 'bootstrap/dist/css/bootstrap.min.css'
import '../ListPets.css'
import {Link} from "react-router-dom";

const ListPets = () => {
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

    const removeHandler = () => {

    }

    if (isLoaded === false) {
        return (<h3>LOADING</h3>)
    } else {

        return (
            <table className='table table-dark'>
                <thead>
                <tr>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Actions</th>
                </tr>
                </thead>
                <tbody>
                {pets.map((pet, index) => {
                    return(
                        <tr>
                            <td>{pet.petName}</td>
                            <td>{pet.petType}</td>
                            <td><Link className='btn btn-primary'>View Information</Link><Link to={`/pets/update/${pet._id}`} className='btn btn-warning'>Edit</Link></td>
                        </tr>
                    )
                })}
                </tbody>
            </table>
        )
    }


}

export default ListPets;