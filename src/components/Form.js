function Form (props) {
    return (
        <><div className='input-group mb-3'>
            <input min='0' placeholder='Numero di Unità Produttive' type='number' className="form-control" id='up' />
            <input min='0' placeholder='Numero di Destinazioni' type='number' className="form-control" id='d' / >
            <button onClick={ props.setTable } className='btn'>Invia</button>
        </div>
        {/*<div id='alert' className='alert alert-danger'>
        🚧 Attenzione! Devi inserire almeno due unità produttive e due destinazioni!
        </div>*/}
        <div id='alert'>🔎 Inserisci i dati qui sopra per procedere</div>
        </>
    )
}

export default Form;