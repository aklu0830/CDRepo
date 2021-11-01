import React, {useState} from "react";

const Subdiv = props => {
    const [state, setState] = useState({
        age: props.age
    })

    const clickHander = e => {
        console.log(state)
        setState({
            age: state.age+1
        })
    }

    return(
      <div>
          <h1>{ props.lastname }, { props.firstname }</h1>
          <p>Age: { state.age }</p>
          <p>Hair Color: { props.hairColor }</p>
          <button onClick={clickHander} className={"btn btn-primary"}>Increase Age</button>
      </div>
    );




}


export default Subdiv