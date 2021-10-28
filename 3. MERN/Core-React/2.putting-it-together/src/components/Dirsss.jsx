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
                <h1>{this.props.lname}, {this.props.fname}</h1>
                <h6>Age: { this.state.age}</h6>
                <h6>Hair Color: {this.state.hclr}</h6>
                <button onClick={this.incAge} className={"btn btn-primary"}>Flip Switch</button>
            </fieldset>
        );
    }


}



export default Dirsss