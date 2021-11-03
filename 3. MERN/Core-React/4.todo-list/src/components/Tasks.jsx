import React, {useState} from "react";
import 'bootstrap/dist/css/bootstrap.min.css'


const Tasks = () => {
    const [tasks, setTasks] = useState({
        nameOfTask: "",
        isComplete: false
    })

    const [listOfTasks, setListOfTasks] = useState([]);

    const handleChange = (e) => {
        setTasks({
            ...tasks,
            nameOfTask: e.target.value,
            isComplete: false
        });
    }

    const changeStuff = (e, index) => {
        setListOfTasks([...listOfTasks.slice(0, index), {...listOfTasks[index], isComplete: e.target.checked}, ...listOfTasks.slice(index+1) ]);

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

            {listOfTasks.map((item, idnum) =>
                <div>
                    <b style={item.isComplete ? {textDecoration: "line-through"}: {textDecoration: "none"}} id={idnum}>{item.nameOfTask}</b>
                    <input className="btn" type="checkbox" checked={item.isComplete} onChange={(e) => changeStuff(e,idnum)}/>
                </div>)}
        </div>
    )
}


export default Tasks