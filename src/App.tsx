import { useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import Footer from "./Components/Footer";
import Spells from "./Components/Spells";
import Header from "./Components/Header";
import User from "./Components/User";
import Home from "./Components/Home";
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
          <Route path="/" element={<User />} />
          <Route path="/home" element={<Home />} />
          <Route path="/spells" element={<Spells />} />
        </Routes>
      </Router>
      <Footer />
    </div>
  );
}

export default App;
