import React, {Component} from "react";

class Profile extends Component {
    render() {
        return (
            <div className="Profile">
                <h2>{this.props.lastname}, {this.props.firstname}</h2>
                <h6>Age: {this.props.age}</h6>
                <h6>Hair Color: {this.props.hclr}</h6>
            </div>
        )
    }


}

export default Profile