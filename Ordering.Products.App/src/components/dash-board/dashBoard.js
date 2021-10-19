import React, { Component } from 'react';
import { connect } from 'react-redux'
import { addToCart } from '../../redux/actions/cartActions';

 class dashBoard extends Component{
    
    handleClick = (id)=>{
        console.log("props : ", this.props.items);
        console.log("Product Id : ",id);
        this.props.addToCart(id); 

    }

    render(){
        let itemList = this.props.items.map(item=>{
            return(
                <div className="" key={item.id}>
                            <img src={item.img} alt={item.title}/>
                        <div className="card-content">
                        <b className="card-title">{item.title}</b>
                            <p>{item.desc}</p>
                            <p><i>Price: R {item.price}</i></p>
                            <button class="btn btn-success" onClick={()=>{this.handleClick(item.id)}}>Add to Basket</button>
                        </div>
                 </div>

            )
        })

        return(
            <div className="container">
                <h3 className="center">List of Products</h3>
                <div className="box">
                    {itemList}
                </div>
            </div>
        )
    }
}
const mapStateToProps = (state)=>{
    return {
      items: state.items
    }
  }
const mapDispatchToProps= (dispatch)=>{
    
    return{
        addToCart: (id)=>{dispatch(addToCart(id))}
    }
}

export default connect(mapStateToProps,mapDispatchToProps)(dashBoard)