import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Subdiv from "./components/Subdiv";

function App() {
    return (
        <div className="App">
            <Subdiv lastname={"Doe"} firstname={"Jane"} hairColor={"Black"} age={45}></Subdiv>
            <Subdiv lastname={"Smith"} firstname={"John"} hairColor={"Brown"} age={88}></Subdiv>
            <Subdiv lastname={"Fillmore"} firstname={"Millard"} hairColor={"Brown"} age={50}></Subdiv>
            <Subdiv lastname={"Smith"} firstname={"Maria"} hairColor={"Brown"} age={62}></Subdiv>

        </div>
    );
}

export default App;
