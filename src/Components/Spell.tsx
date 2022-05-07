import React, {
  ChangeEvent,
  ChangeEventHandler,
  useEffect,
  useState,
  
} from "react";
import {
  BrowserRouter as Router,
  Route,
  Routes,
  Link,
  useParams,


} from "react-router-dom";
import { CommentType, SpellType } from "../Types";


import spell from "./Spell";

async function loadOneSpell(id: string) {
  const response = await fetch(`/api/spells/${id}`)

  if (response.ok){
    return response.json()
  } else {
    throw await response.json()
  }
}

async function submitNewComment(comment: CommentType){
  const response = await fetch(`/api/comments`, {
    method: 'POST',
    headers: { 'content-type': 'application/json' },
    body: JSON.stringify(comment),
  })
  if (response.ok) {
    return response.json()
  } else {
    throw await response.json()
  }
}

export function Spell() {
  const { id }= useParams<{ id: string }>()
const [newComment, setNewComment] = useState<CommentType>({
  id: undefined,
  comment: '',
  createdAt: new Date(),
  spellId: Number(id),

})

const { refetch: reloadSpell, data: spell = NullSpell } = useQuery<SpellType>(
  ['one-spell', id],
  () => loadOneSpell(id)
)

const createNewComment = useMutation(submitNewComment, {
  onSuccess: function () {
  reloadSpell()
  setNewComment({
    ...newComment,
    comment: '',
    createdAt: new Date(),

  })
  },
})

function handleNewCommentTextFieldChange(
  event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>

)
{
  const name = event.target.name
  const value = event.target.value 

  setNewComment({ ...newComment, [name]: value})
}
// //Guard clause approach
// //if (spell === undefined) {
//   return null
// }

  // const [selectedSpell, setSelectedSpell] = useState({});

  // const handleSpellSelection = (spell: {}) => {
  //   setSelectedSpell(spell);
  // };

  return (
    <div className="Spell">
      <h1>Incendio</h1>
      <h2>Wand Movement</h2>
      <img src="./src/Images/Incendio.webp" width="250px" height="200px"></img>
      <p>
        Incendio is used to conjure fire. The etymology is latin, incendium
        means "fire."
      </p>
      <h3>Completed </h3>

      <ul className="comments">
        {Spell.comments.map((comment) => (
        <li key={UserComment.id}>
          <div className= "comment"></div>
        </li>
        <div>
          <time>{comment.CreatedAt}</time>
          </div>))}
  </ul>

  <h3>Enter your comment</h3>
  <form onSubmit = {function (event) {
    event.preventDefault()
    createNewComment.mutate(newComment)
  }}>
    <p className="form-input">
      <label htmlFor="comment">Comment</label>
      <textarea name="comment">value={newComment.comment} onChange={handleNewCommentTextFieldChange}</textarea>
  
    </p>
  </form>



        
    
      {/* {selectedSpell && <Spell
      
      />} */}
    </div>
  );
}

export default Spell;

// from the list of spell, each spell will have an onClick event
// you'll pass in the spell on the onclick onClick={((event) => handleSpellelection(event))}
