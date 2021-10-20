import React, { Component } from 'react';
import { connect } from 'react-redux'
import { addToCart } from '../../redux/actions/cartActions';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import {getAllProducts} from '../../service/ServiceApi/ProductService';
import BASE_URL from "../../AppSettings";
 class dashBoard extends Component {
   constructor(props) {
     super(props);
     this.state = { products: null ,imagesUrls : []};

   }
   handleClick = (id) => {
     this.props.addToCart(id);
   };

   componentWillMount() {
    let imageList = []
   
   
    this.props.items.forEach(element => {
        imageList.push(element.img);
    });
    fetch(BASE_URL+"/Products")
    .then((response) => response.json())
    .then((data) => this.setState({ products: data, imagesUrls : imageList}));

   }

   render() {
     let itemList = <div></div>;
     if(this.state.products != null){
        itemList = this.state.products.map((item,index) => {
            return <div className="" key={item.id}>
                <Container class="rounded">
                  <Row>
                    <b className="card-title">{item.title}</b>
                    <Col>
                      {" "}
                      <img src={this.state.imagesUrls[index]} alt={item.title} />
                      <p class="text-danger">
                        <i>Price: R {item.price}</i>
                      </p>
                    </Col>
                    <Col>
                      {" "}
                      <p>{item.description}</p>
                    </Col>
     
                    <Col>
                      {" "}
                      <button class="btn btn-success" onClick={() => {
                          this.handleClick(item.id);
                        }}>
                        Add to Basket
                      </button>
                    </Col>
                  </Row>
                </Container>
              </div>;
          });
     }else{
        itemList = <div>
            <h1>Still Loading products to display.</h1>
            <p>Please be wait ....</p>
        </div>
     }
 

     return <div className="container">
         <h3 className="center">List of Products</h3>
         <div className="box">{itemList}</div>
       </div>;
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