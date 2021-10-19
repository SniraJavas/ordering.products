import React, { Component } from 'react'
import { connect } from 'react-redux'
//import { addDELIVERY } from './actions/cartActions'
class CartHelper extends Component{
    
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
                    <li className="collection-item">
                            <label>
                                <input type="checkbox" ref="DELIVERY" onChange= {this.handleChecked} />
                                <span>Delivery(R50)</span>
                            </label>
                        </li>
                        <li className="collection-item"><b>Total: R{this.props.total} </b></li>
                    </div>
                    <div className="checkout">
                        <button className="waves-effect waves-light btn">Checkout</button>
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
