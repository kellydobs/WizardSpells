import React, {
  ChangeEvent,
  ChangeEventHandler,
  useEffect,
  useState,
} from "react";
// import {
//   AppBar,
//   Card,
//   Container,
//   FormGroup,
//   FormControl,
//   FormHelperText,
//   Input,
//   InputLabel,
//   Typography,
//   Button,
// } from "@mui/material";

import { useHistory } from "react-router";

// const defaultValues = {
//   username: "",
//   password: "",
// };

// const Login = () => {
//   const [formValues, setFormValues] = useState(defaultValues);

//   const handleInputChange: ChangeEventHandler = (e: ChangeEvent) => {
//     const target = e.target as HTMLInputElement;
//     const { id, value } = target;
//     setFormValues({
//       ...formValues,
//       [id]: value,
//     });
//   };

//   const handleSubmit = (event: any) => {
//     event.preventDefault();
//     console.log(formValues);
//   };

//   return (
//     <Card className="login">
//       <form onSubmit={handleSubmit}>
//         <FormControl sx={{ py: "10%", width: "100%" }}>
//           <Input id="username" onChange={handleInputChange} />
//         </FormControl>
//         <FormControl sx={{ py: "10%", width: "100%" }}>
//           <InputLabel htmlFor="password">Password</InputLabel>
//           <Input id="password" onChange={handleInputChange} />
//         </FormControl>
//         <Button sx={{ marginTop: "5%", width: "100%" }} type="submit">
//           Login
//         </Button>
//       </form>
//     </Card>
//   );
// };

// export default Login;
