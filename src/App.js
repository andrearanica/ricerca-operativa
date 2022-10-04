import logo from './logo.svg';
import './App.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";

import Navbar from './components/Navbar';
import Form from './components/Form';

function App () {
  
  function setTable () {
    
  }

  return (
    <div className='App'>
      <Navbar />
      <div className='container my-5' style={{ textAlign: 'left' }}>
        <h1>Ricerca Operativa</h1>
        <Form />
      </div>
    </div>
  );
}

export default App;
