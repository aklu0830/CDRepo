import React, {useState} from "react";
import 'bootstrap/dist/css/bootstrap.min.css'


const Tasks = () => {
    const [tasks, setTasks] = useState({
        nameOfTask: ""
    })

    const [listOfTasks, setListOfTasks] = useState([]);

    const handleChange = (e) => {
        setTasks({
            ...tasks,
            nameOfTask: e.target.value
        });
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        setListOfTasks([...listOfTasks, tasks])
        document.getElementById("input-sect").value = ""
    }

    return (
        <div>
            <div>
                <input type="text" id="input-sect" onChange={handleChange}/>
                <input type="submit" className="btn btn-primary" value="Add Task" onClick={handleSubmit}/>
            </div>
            <div>
                {listOfTasks.map((item, idnum) =>
                    <div>
                        <li id={idnum}>{item.nameOfTask}</li>

                    </div>)}
            </div>


        </div>

    )
}


export default Tasks