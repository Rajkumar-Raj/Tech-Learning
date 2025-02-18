import logo from './logo.svg';
import MyButton from './button.js';
import './App.css';
import {useState} from 'react';

function App() {

  const[count, setCount] = useState(0);

  const handleclick = () => setCount(count+1);
  
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit src/App.js and save to reload. <br />
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
count = {count}

        <MyButton count={count} onclick={handleclick} />
      </header>
      
    </div>
  );
}

export default App;
