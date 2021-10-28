import React, {Component} from "react";


class Dirsss extends Component {


    constructor(props) {
        super(props);
        this.state = {
            age: props.age
        };
    }

    incAge = () => {
        this.setState({age : this.state.age+=1})
    }

    render() {
        return (
            <fieldset>
                <p>The light is currently { this.state.age}</p>
                <button onClick={this.incAge} className={"btn btn-primary"}>Flip Switch</button>
            </fieldset>
        );
    }


}



export default Dirsss