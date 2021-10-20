import React, { Component } from 'react';
import { connect } from 'react-redux'
import { Link } from 'react-router-dom'
import { removeItem,subtractQuantity,addQuantity} from './../../redux/actions/cartActions';
import  CartHelper from './CartHelper'
import {getProduct }from './../../service/ProductStorage';
import './Cart.css';

class Cart extends Component{
    constructor(props){ 
        super(props);
        this.state = {
            productsInfo: getProduct()
          };

    }
    //to remove the item completely
    handleRemove = (id)=>{
        this.props.removeItem(id);
    }
    //to add the quantity
    handleAddQuantity = (id)=>{
        this.props.addQuantity(id);
    }
    //to substruct from the quantity
    handleSubtractQuantity = (id)=>{
        this.props.subtractQuantity(id);
    }
    render(){
        let addedItems = <p>Nothing</p>
        if(this.state.productsInfo == null){
            addedItems = <p>You have not ordered anything</p>
        }else{
            addedItems =this.state.productsInfo.items.length ?
            (  
                this.state.productsInfo.addedItems.map(item=>{
                    return <ul class="list-group">
                        <li class="list-group-item d-flex justify-content-between align-items-center">
                          <div class="small-image">
                            
                            <img src={item.img} alt={item.img} height="5%" width="50%" />
                            <div><p>
                                            <b>Quantity: {item.quantity}</b> 
                                        </p><Link to="/cart"><i className="material-icons" onClick={()=>{this.handleAddQuantity(item.id)}}>arrow_drop_up</i></Link>
                                <Link to="/cart"><i className="material-icons" onClick={()=>{this.handleSubtractQuantity(item.id)}}>arrow_drop_down</i></Link></div>
                          </div>
                          <button className="waves-effect waves-light btn pink remove" onClick={()=>{this.handleRemove(item.id)}}>Delete</button>
                          <div>
                          <span className="title">{item.title}</span>
                          </div>
                          <span class="badge badge-primary badge-pill">
                          Price: R {item.price}
                          </span>
                        </li>
                      </ul>;
                })
            ):

             (
                <p>Nothing.</p>
             )
        }
      
       return(
            <div className="container">
                <div className="row justify-content-center">
                    <h5>List of what you have ordered</h5>
                    <ul className="">
                        {addedItems}
                    </ul>
                </div> 
                <CartHelper />          
            </div>
       )
    }
}


const mapStateToProps = (state)=>{
    console.log("state " ,state)
    return{
        items: state.addedItems,
        addedItems: state.addedItems
    }
}
const mapDispatchToProps = (dispatch)=>{
    return{
        removeItem: (id)=>{dispatch(removeItem(id))},
        addQuantity: (id)=>{dispatch(addQuantity(id))},
        subtractQuantity: (id)=>{dispatch(subtractQuantity(id))}
    }
}
export default connect(mapStateToProps,mapDispatchToProps)(Cart)