import React, { Component } from 'react';
import { connect } from 'react-redux'
import { addToCart } from '../../redux/actions/cartActions';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
 class dashBoard extends Component{
    
    handleClick = (id)=>{
        console.log("props : ", this.props.items);
        console.log("Product Id : ",id);
        this.props.addToCart(id); 

    }

    render(){
        let itemList = this.props.items.map(item=>{
            return <div className="" key={item.id}>
                <Container class="rounded">
                  <Row >
                      <b className="card-title">{item.title}</b>
                    <Col> <img src={item.img} alt={item.title}/><p class="text-danger"><i>Price: R {item.price}</i></p></Col>
                    <Col>  <p>{item.desc}</p></Col>
        
                    <Col> <button class="btn btn-success" onClick={()=>{this.handleClick(item.id)}}>Add to Basket</button></Col>
                  </Row>
                </Container>
              </div>;
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