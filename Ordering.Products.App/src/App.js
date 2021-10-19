import React, { Component } from 'react';
import {BrowserRouter, Route, Switch} from 'react-router-dom';
import NavigationBar from './components/nav-bar/Navbar';
import dashBoard from './components/dash-board/dashBoard';
import cart from './components/cart/Cart';
import 'bootstrap/dist/css/bootstrap.min.css';
class App extends Component {
  render() {
    return (
       <BrowserRouter>
            <div className="App">
            
              <NavigationBar />
                <Switch>
                    <Route exact path="/" component={dashBoard}/>
                    <Route path="/cart" component={cart}/>
                  </Switch>
             </div>
       </BrowserRouter>
      
    );
  }
}

export default App;
