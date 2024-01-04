import React, { useState, useEffect } from 'react';
import './App.css';
import agent from './api/agent'

function App() {
  const [products, setProducts] = useState([])

  useEffect(() => {
    agent.products.getProducts().then(data => setProducts(data))
  }, [])
  
  return (
    <div className="App">
        <p>
          ReStore
        </p>
    </div>
  );
}

export default App;
