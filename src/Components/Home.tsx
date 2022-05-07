import Avatar from "@mui/material/Avatar";
import Stack from "@mui/material/Stack";
import React, { useState, useEffect } from "react";
import axios from "axios";

function Home() {
  const [allSpells, setAllSpells] = useState([]);
  const [requestedSpell, setRequestedSpell] = useState({});
  useEffect(() => {
    axios.get("/api/spells/all").then((response) => {
      if (response) {
        setAllSpells(response.data);
        console.log(response);
      }
    });
  }, []);

  const goToSpell = (spell: {}) => {
    axios.get(`api/spells/${spell.Id}`).then((response) => {
      if (response) {
        setRequestedSpell(response.data);
      }
    });
  };

  return (
    <div className="Home">
      {allSpells.map((spell) => {
        return (
          <ul>
            <li onClick={(spell) => goToSpell(spell)}>{spell.Name}</li>
          </ul>
        );
      })}
    </div>
  );

  //Need to add an image with map and side bar with the spells.
}

export default Home;

// useEffect(()=> {

// }, [])

// empty bracket on the bottom mean the function will run on mount, one time
//if you put something inside the [] it will rerender.
