import logo from './logo.svg';
import './App.css';
import Profile from "./components/Profile";

function App() {
    return (
        <div className="App">
            <Profile lastname={"Doe"} firstname={"Jane"} age={16} hclr={"Black"}></Profile>
            <Profile lastname={"Smith"} firstname={"John"} age={88} hclr={"Brown"}></Profile>
            <Profile lastname={"Fillmore"} firstname={"Millard"} age={50} hclr={"Brown"}></Profile>
            <Profile lastname={"Smith"} firstname={"Maria"} age={62} hclr={"Brown"}></Profile>

        </div>
    );
}

export default App;
