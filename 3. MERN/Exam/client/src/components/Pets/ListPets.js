import React, {useEffect, useState} from "react";
import axios from "axios";

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
                            <td>TEXT</td>
                        </tr>
                    )
                })}
                </tbody>
            </table>
        )
    }


}

export default ListPets;