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
    } else if ((data[4])==="")  {
        return (

            <div>
                <div><h1>Pet Shelter</h1></div>
                <div className='results'><h3>Pet Name:</h3> <a className='test'>{data.petName}</a></div>
                <div className='results'><h3>Pet Descripion:</h3> <a className='test'>{data.petDescription}</a></div>
                <a className='btn btn-danger' onClick={adoptionHandler}>Adopt</a>
            </div>

        )
    } else {
        return (
            <div>
                <div><h1>Pet Shelter</h1></div>
                <div className='results'><h3>Pet Name:</h3> <a className='test'>{data.petName}</a></div>
                <div className='results'><h3>Pet Descripion:</h3> <a className='test'>{data.petDescription}</a></div>
                <div className='results'><h3>Skills:</h3> <a className='test'>{data.skillOne} {data.skillTwo} {data.skillThree}</a></div>
                <a className='btn btn-danger' onClick={adoptionHandler}>Adopt</a>
            </div>

            )

    }

}

export default ShowPetInfo;