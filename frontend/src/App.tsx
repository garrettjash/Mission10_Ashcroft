import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import BowlerList from './Bowling/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Our Favorite Bowlers" />
      <BowlerList />
    </div>
  );
}

export default App;
