import React from 'react';
import { Link } from 'react-router-dom';
import {Navbar, Nav,Container} from 'react-bootstrap';
 const NavigationBar = ()=>{
    return(
        <Navbar bg="primary" variant="dark">
        <Container class="text-primary">
          <Navbar.Brand href="/"><h2>Ordering System</h2></Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto" >
              <Nav.Link href="/">View Products</Nav.Link>
              <Nav.Link href="/cart">View Basket(0)</Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
   
        
    )
}

export default NavigationBar;
