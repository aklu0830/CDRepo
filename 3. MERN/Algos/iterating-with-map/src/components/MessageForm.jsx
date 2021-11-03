import React, {useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';


const MessageForm = (props) => {
    const [msg, setMsg] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        props.onNewMessage(msg);
    };

    return (
        <form onSubmit={handleSubmit}>
            <h1>Set Message</h1>
            <textarea
                rows="4"
                cols="50"
                placeholder="Enter your message here"
                onChange={(e) => setMsg(e.target.value)}
                value={msg}
            />
            <input type="submit" className="btn btn-primary" value="Send Message"/>
        </form>
    );
};

export default MessageForm;