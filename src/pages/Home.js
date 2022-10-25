import React , {useState} from 'react';
// import logo from './logo.svg';
import './App.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import matrix from 'matrix-js/lib';

import Navbar from './components/Navbar';
import Form from './components/Form';
import Table from './components/Table';

function App () {
  // let up, d, m;
  const [up, setUp] = useState()
  const [d, setD] = useState()
  const [m, setM] = useState()

  function setAlert (success) {
    if (success) {
      document.getElementById('alert').className='alert alert-success'
      document.getElementById('alert').textContent='🚀 Dati inseriti correttamente!'
    } else {
      document.getElementById('alert').className='alert alert-danger'
      document.getElementById('alert').textContent='🚧 Attenzione! Devi inserire almeno due unità produttive e due destinazioni!'
    }
  }

  function makeTable (e) {
    e.preventDefault()    
    setUp(document.getElementById('up').value)
    setD(document.getElementById('d').value)
    // console.log(`U.P.: ${up} | Destinazioni: ${d}`)
    var temp = [[1, 2, 3], [7, 8, 9]]
    setM(matrix(temp))
    if (up > 1 && d > 1) {
      setAlert(true)
    } else {
      setAlert(false)
    }
    // console.log(m)
  }

  return (
    <div className='App'>
      <Navbar />
      <div className='container my-5' style={{ textAlign: 'left' }}>
        <h1>Ricerca Operativa</h1>
        <Form setTable={makeTable}/>
        <Table d={d} up={up}/>
      </div>
    </div>
  );
}

export default Home;