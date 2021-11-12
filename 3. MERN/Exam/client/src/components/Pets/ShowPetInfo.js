import React, {useEffect, useState} from "react";
import axios from "axios";
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
                <h1>Animal Type: {data.petType}</h1>
                <a className='btn btn-danger' onClick={adoptionHandler}>Adopt</a>
            </div>

        )
    }

}

export default ShowPetInfo;