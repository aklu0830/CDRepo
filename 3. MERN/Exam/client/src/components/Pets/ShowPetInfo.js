import React, {useEffect, useState} from "react";
import axios from "axios";
import {useParams} from "react-router-dom";

const ShowPetInfo = () => {
    const {id} = useParams()
    const [data, setData] = useState([]);
    const [isLoaded, setIsLoaded] = useState(false);



    useEffect(() => {
        axios.get(`http://localhost:8000/api/pets/info/${id}`)
            .then(response=>console.log(response))

    }, [])
    return (
        <div></div>
    )
}

export default ShowPetInfo;