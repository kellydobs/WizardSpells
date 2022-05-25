import { useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import Footer from "./Components/Footer";
import Spell from "./Components/Spell";
import Header from "./Components/Header";
import User from "./Components/User";
import Home from "./Components/Home";
import Login from "./Components/SignIn";
import {
  BrowserRouter as Router,
  Route,
  Routes,
  Link,
  useParams,
} from "react-router-dom";

export function App() {
  return (
    <div className="App">
      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="/home" element={<Home />} />
          <Route path="/spell" element={<Spell />} />
        </Routes>
      </Router>
      <Footer />
    </div>
  );
}

export default App;
