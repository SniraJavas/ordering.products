import React, { Component } from 'react'
import { connect } from 'react-redux'
import {getProduct }from './../../service/ProductStorage';
//import { addDELIVERY } from './actions/cartActions'
class CartHelper extends Component{
    constructor(props){ 
        super(props);
        this.state = {
            total: 0
          };

    }
    componentWillUnmount() {
         if(this.refs.DELIVERY.checked)
              this.props.substractDELIVERY()
    }

    handleChecked = (e)=>{
        if(e.target.checked){
            this.props.addDELIVERY();
        }
        else{
            this.props.substractDELIVERY();
        }
    }

    render(){
  
        return(
            <div className="container">
                <div className="collection">
                        <li className="collection-item"><b>Total: R{this.state.total} </b></li>
                    </div>
                    <div className="checkout">
                        <button className="waves-effect waves-light btn">Complete Order</button>
                    </div>
                 </div>
        )
    }
}

const mapStateToProps = (state)=>{
    return{
        addedItems: state.addedItems,
        total: state.total
    }
}

const mapDispatchToProps = (dispatch)=>{
    return{
        addDELIVERY: ()=>{dispatch({type: 'ADD_DELIVERY'})},
        substractDELIVERY: ()=>{dispatch({type: 'SUB_DELIVERY'})}
    }
}

export default connect(mapStateToProps,mapDispatchToProps)(CartHelper)
