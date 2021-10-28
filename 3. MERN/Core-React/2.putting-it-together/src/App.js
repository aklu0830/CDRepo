import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';


import Dirsss from "./components/Dirsss";

function App() {

    return (

        <div className={"App"}>
            <Dirsss lname={"Doe"} fname={"Jane"} age={45} hclr={"Black"}></Dirsss>
            <Dirsss lname={"Smith"} fname={"John"} age={88} hclr={"Brown"}></Dirsss>

        </div>
    );
}

export default App;
