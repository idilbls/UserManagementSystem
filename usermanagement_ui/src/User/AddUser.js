import React from 'react';  
import axios from 'axios';  
import '../User/AddUser.css'  
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
class AddUser extends React.Component{  
constructor(props){  
  super(props)  
  this.createUser = this.createUser.bind(this);  
  this.state = {  
    name:'',  
    surname:'', 
    email:'', 
    phoneNumber:'',
    dateOfBirth:'' 
  }  
}   
async createUser(){  
await  axios.post('https://localhost:44399/api/user/add/', {id: 0,name: this.state.name,surname: this.state.surname,email: this.state.email,phoneNumber: this.state.phoneNumber,dateOfBirth: this.state.dateOfBirth})  
.then(json => {  
if(json.data.Status==='Success'){  
  console.log(json.data.Status);  
  alert("Data Save Successfully");  
this.props.history.push('/UserList')  
}  
else{  
alert('Data not Saved');  
debugger;  
this.props.history.push('/UserList')  
} 
this.props.history.push('/UserList')  
})  
} 

// createUser(e){ 
//   e.preventDefault();  
//   const obj = {
//     id: 0,
//     name: this.state.name,  
//     surname: this.state.surname,  
//     email: this.state.email,  
//     phoneNumber: this.state.phoneNumber,
//     dateOfBirth: this.state.dateOfBirth
//   };
//    axios.post('https://localhost:44399/api/user/add/', {obj})  
//   .then(res => console.log(res.data));  
//   this.props.history.push('/UserList')  
// }

handleChange= (e)=> {  
this.setState({[e.target.name]:e.target.value});  
}  
   
render() {  
return (  
   <Container className="App">  
    <h4 className="PageHeading">Enter User Informations</h4>  
    <Form className="form" onSubmit={this.createUser}>  
      <Col>  
        <FormGroup row className="p-4 pb-0">  
          <Label for="name" sm={2}>Name</Label>  
          <Col sm={10}>  
            <Input type="text" name="name" onChange={this.handleChange} value={this.state.name} placeholder="Enter Name" required/>  
          </Col>  
        </FormGroup>  
        <FormGroup row className="p-4 pb-0">  
          <Label for="surname" sm={2}>Surname</Label>  
          <Col sm={10}>  
            <Input type="text" name="surname" onChange={this.handleChange} value={this.state.surname} placeholder="Enter Surname" required/>  
          </Col>  
        </FormGroup>  
        <FormGroup row className="p-4 pb-0">  
          <Label for="email" sm={2}>Email</Label>  
          <Col sm={10}>  
            <Input type="text" name="email" onChange={this.handleChange} value={this.state.email} placeholder="Enter Email" required/>  
          </Col>  
        </FormGroup>  
        <FormGroup row className="p-4 pb-0">  
          <Label for="phoneNumber" sm={2}>Phone Number</Label>  
          <Col sm={10}>  
            <Input type="text" name="phoneNumber" onChange={this.handleChange} value={this.state.phoneNumber} placeholder="Enter Phone Number" required/>  
          </Col>  
        </FormGroup>  
        <FormGroup row className="p-4 pb-0">  
          <Label for="dateOfBirth" sm={2}>Date of Birth</Label>  
          <Col sm={10}>  
            <Input type="date" name="dateOfBirth" onChange={this.handleChange} value={this.state.dateOfBirth.toString()} placeholder="Enter Date of Birth" />  
          </Col>  
        </FormGroup>  
      </Col>  
      <Col>  
        <FormGroup row className="mt-4">  
          <Col sm={5}>  
          </Col>  
          <Col sm={1}>  
          <Button type="submit" color="success">Submit</Button>{' '} 
          </Col>  
          <Col sm={1}>  
            <Button color="danger">Cancel</Button>{' '}  
          </Col>  
          <Col sm={5}>  
          </Col>  
        </FormGroup>  
      </Col>  
    </Form>  
  </Container>  
);  
}  
   
}  
   
export default AddUser;  
   