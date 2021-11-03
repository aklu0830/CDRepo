import React, {useState} from "react";
import 'bootstrap/dist/css/bootstrap.min.css'
import './boxColors.css'

const BoxForm = (props) => {
    const [task, setTask] = useState({
        nameOfTask: "",
        isComplete: false
        }
    );

    const [listOfTasks, setListOfTasks] = useState([]);

    const changeHandler = (e) => {
        console.log("");
        setTask({
            ...task,
            nameOfTask: e.target.value

        })
    }

    const submit = (e) => {
        e.preventDefault();
        setListOfTasks([...listOfTasks, task])
    }

    return (
        <div>
            <form>
                <h4>Add a color below</h4>
                <input type="text" onChange={changeHandler}/>
                <input type="submit" value="Add Color" className="btn btn-primary" onClick={submit}/>
                <ul>
                    <div className="boxes">
                        {listOfTasks.map((tasks, tn) =>
                            <div className="box" style={{backgroundColor: tasks.nameOfTask} }></div>

                        )}
                    </div>

                </ul>
            </form>

        </div>

    )
}

export default BoxForm