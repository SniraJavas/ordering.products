import logo from './logo.svg';
import {BrowserRouter, Route, Switch} from 'react-router-dom';
import Navbar from './components/navBar/Navbar'
import './App.css';

function App() {
  return (
    <BrowserRouter>
            <div className="App">
            
              <Navbar/>
                <Switch>
                    {/* <Route exact path="/" component={Home}/>
                    <Route path="/cart" component={Cart}/> */}
                  </Switch>
             </div>
       </BrowserRouter>
  );
}

export default App;
