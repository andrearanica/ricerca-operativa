function Form (props) {
    return (
        <div className='input-group mb-3'>
            <input placeholder='Numero di U.P.' className="form-control" />
            <input placeholder='Numero di D' type='number' className="form-control" />
            <button onClick={ props.setTable } className='btn'>Invia</button>
        </div>
    )
}

export default Form;