import React, {useState} from "react";
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css'


const FetchPok = (props) => {
    const [pokemon, setPokemon] = useState([]);

    const getPok = () => {
            axios.get('https://pokeapi.co/api/v2/pokemon')
                .then(response => {setPokemon(response.data.results)})

    }




    return (
        <div>


            <div><button className="btn btn-info" onClick={getPok}>Fetch Pokemon</button></div>
            <div>{pokemon.map((item, index) =>
                <div>{item.name}</div>)}</div>
        </div>



)
};

export default FetchPok