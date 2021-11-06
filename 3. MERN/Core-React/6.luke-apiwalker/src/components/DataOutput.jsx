import React, {useEffect, useState} from "react";
import {Redirect, useParams} from "react-router-dom";
import axios from "axios";
import '../DataOutput.css'


const DataPrint = props => {
    const [data, setData] = useState([]);
    var {datatype} = useParams();
    var {id} = useParams();


    useEffect(() => {

        fetch('https://swapi.dev/api/' + datatype)
            .then(response => response.json())
            .then(response => {
                setData(response.results)
            })


    }, [])






    if (data.length < 1) {
        return (

            <div className='dss'>
                <h1>Loading....</h1>
                <footer>If this is taking longer than 3 seconds, your input data is invalid</footer>
            </div>
        );
    } else if (data.length < 1) {
        return (
            <div className='dss'>
                <h1>Unable to display data</h1>
            </div>
        )
    } else if (datatype === 'people') {
        return (

            <div className='dss'>

                <h1>Name: {data[id].name}</h1>
                <h5>Height: <d className="res">{data[id].height}</d></h5>
                <h5>Mass: <d className="res">{data[id].mass}kg</d></h5>
                <h5>Hair Color: <d className="res">{data[id].hair_color}</d></h5>
                <h5>Skin Color: <d className="res">{data[id].skin_color}</d></h5>

            </div>
        );
    } else if (datatype === 'planets') {
        return (

            <div className='dss'>

                <h1>{data[id].name}</h1>
                <h5>Climate: <d className="res">{data[id].climate}</d></h5>
                <h5>Terrain: <d className="res">{data[id].terrain}</d></h5>
                <h5>Population: <d className="res">{data[id].surface_water}</d></h5>
                <h5>Population: <d className="res">{data[id].population}</d></h5>

            </div>
        );
    }


}


export default DataPrint