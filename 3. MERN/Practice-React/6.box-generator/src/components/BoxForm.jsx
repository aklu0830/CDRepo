import React, {useState} from "react";
import 'bootstrap/dist/css/bootstrap.min.css'
import './boxColors.css'

const BoxForm = (props) => {
    const [color, setColor] = useState({
        nameOfColo: "",
        isComplete: false
        }
    );

    const [listOfColors, setListOfColors] = useState([]);

    const changeHandler = (e) => {
        console.log("");
        setColor({
            ...color,
            nameOfColor: e.target.value

        })
    }

    const submit = (e) => {
        e.preventDefault();
        setListOfColors([...listOfColors, color])
    }

    return (
        <div>
            <form>
                <h4>Add a color below</h4>
                <input type="text" onChange={changeHandler}/>
                <input type="submit" value="Add Color" className="btn btn-primary" onClick={submit}/>
                <ul>
                    <div className="boxes">
                        {listOfColors.map((boxes, tn) =>
                            <div className="box" style={{backgroundColor: boxes.nameOfColor} }></div>

                        )}
                    </div>

                </ul>
            </form>

        </div>

    )
}

export default BoxForm