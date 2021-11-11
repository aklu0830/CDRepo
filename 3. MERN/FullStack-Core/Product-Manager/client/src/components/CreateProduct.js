import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'
import '../Form.css'

const CreateProduct = (props) => {

    return (
        <form className='form-sizing'>
            <div className='form-group'>
                <label>Title</label>
                <input type='text' className='form-control'/>
                <label>Price</label>
                <input type='text' className='form-control'/>
                <label>Description</label>
                <input type='text' className='form-control'/>
            </div>
            <input type='submit' className='btn btn-success' value='Create Product'/>
        </form>
    )

}

export default CreateProduct;