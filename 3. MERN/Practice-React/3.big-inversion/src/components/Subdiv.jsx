import React from "react";

const Subdiv = props => {




    return(
      <div>
          <h1>{ props.lastname }, { props.firstname }</h1>
          <p>Age: { props.age }</p>
          <p>Hair Color: { props.hairColor }</p>

      </div>
    );




}


export default Subdiv