import { useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import Footer from "./Components/Footer";
import Spells from "./Components/Spells";
import Header from "./Components/Header";

export function App() {
  return (
    <div className="App">
      <style>
        @import
        url('https://fonts.googleapis.com/css2?family=Amatic+SC&family=Fredericka+the+Great&display=swap');
      </style>
      <Header />
      <Spells />
      <Footer />
    </div>
  );
}

export default App;
