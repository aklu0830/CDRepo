import React, {useEffect, useState} from "react";
import axios from "axios";
import '../ShowPetInfo.css'
import {Link, useHistory, useParams} from "react-router-dom";

const ShowPetInfo = () => {
    const {id} = useParams()
    const history = useHistory();
    const [data, setData] = useState([]);
    const [isLoaded, setIsLoaded] = useState(false);

    const adoptionHandler = () => {
        setIsLoaded(false);
        axios.delete(`http://localhost:8000/api/pets/delete/${id}`)
            .then(()=>history.push('/'))
            .catch(err => console.log(err))

    }



    useEffect(() => {
        axios.get(`http://localhost:8000/api/pets/info/${id}`)
            .then(response=>setData(response.data.pet))
            .then(setIsLoaded(true))

    }, [])


    if (isLoaded === false && data.length < 1) {
        return (
            <h1>Loading....</h1>
        )
    } else  {
        return (

            <div>
                <div><h1>Pet Shelter</h1></div>
                <div className='results'><h3>Pet Name:</h3> <p className='test'>{data.petName}</p></div>
                <div className='results'><h3>Pet Descripion:</h3> <p className='test'>{data.petDescription}</p></div>
                <div className='results'><h3>Skills:</h3> <a className='test'>{data.skillOne}</a></div>
                <a className='btn btn-danger' onClick={adoptionHandler}>Adopt</a>
            </div>

        )
    }

}

export default ShowPetInfo;