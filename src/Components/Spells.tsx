// import * as React, from "react";

import React, { useState } from "react";
// import Spell from "./Spell";

function Spells() {
  // const [selectedSpell, setSelectedSpell] = useState({});

  // const handleSpellSelection = (spell: {}) => {
  //   setSelectedSpell(spell);
  // };

  return (
    <div className="Spells">
      <h1>Incendio</h1>
      <h2>Wand Movement</h2>
      <img src="./src/Images/Incendio.webp" width="250px" height="200px"></img>
      <p>
        Incendio is used to conjure fire. The etymology is latin, incendium
        means "fire."
      </p>
      <h3>Completed </h3>
      {/* {selectedSpell && <Spell
      
      />} */}
    </div>
  );
}

export default Spells;

// from the list of spells, each spell will have an onClick event
// you'll pass in the spell on the onclick onClick={((event) => handleSpellSelection(event))}
