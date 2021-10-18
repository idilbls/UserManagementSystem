import React from 'react';   
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';  
import axios from 'axios'  
import '../User/AddUser.css'  
class Edit extends React.Component {  
    constructor(props) {  
        super(props)  
     
    this.onChangeName = this.onChangeName.bind(this);  
    this.onChangeSurname = this.onChangeSurname.bind(this);  
    this.onChangeEmail = this.onChangeEmail.bind(this);  
    this.onChangePhoneNumber = this.onChangePhoneNumber.bind(this);  
    this.onChangeDateOfBirth = this.onChangeDateOfBirth.bind(this);  
    this.onSubmit = this.onSubmit.bind(this);  
  
         this.state = {  
            name:'',  
            surname:'', 
            email:'', 
            phoneNumber:'',
            dateOfBirth:''  
        }  
    }  
  
  componentDidMount() {  
      axios.post('https://localhost:44399/api/user/get_user_by_id?id='+this.props.match.params.id)  
          .then(response => {  
              this.setState({ 
                name:response.data.name,
                surname:response.data.surname,  
                email:response.data.email, 
                phoneNumber:response.data.phoneNumber,
                dateOfBirth:response.data.dateOfBirth  
             });  
             console.log(response.data);
  
          })  
          .catch(function (error) {  
              console.log(error);  
          })  
    }  
  
  onChangeName(e) {  
    this.setState({  
        name: e.target.value  
    });  
  }  
  onChangeSurname(e) {  
    this.setState({  
        surname: e.target.value  
    });    
  }  
  onChangeEmail(e) {  
    this.setState({  
        email: e.target.value  
    });  
}  
    onChangePhoneNumber(e) {  
        this.setState({  
            phoneNumber: e.target.value  
        });  
  }  
  onChangeDateOfBirth(e) {  
    this.setState({  
        dateOfBirth: e.target.value  
    });  
}  
  
  onSubmit(e) {   
       e.preventDefault();  
    const obj = {  
      id:this.props.match.params.id,  
      name: this.state.name, 
      surname: this.state.surname,  
      email: this.state.email,  
      phoneNumber: this.state.phoneNumber,
      dateOfBirth: this.state.dateOfBirth  
  
    };  
    axios.post('https://localhost:44399/api/user/update/', obj)  
        .then(res => console.log(res.data));  
        this.props.history.push('/UserList')  
  }  
    render() {  
        return (  
            <Container className="App">  
  
             <h4 className="PageHeading">Update User Informations</h4>  
                <Form className="form" onSubmit={this.onSubmit}>  
                    <Col>  
                        <FormGroup row className="p-4 pb-0">  
                            <Label for="name" sm={2}>Name</Label>  
                            <Col sm={10}>  
                                <Input type="text" name="name" value={this.state.name} onChange={this.onChangeName}  
                                placeholder="Enter Name" />  
                            </Col>  
                        </FormGroup>  
                        <FormGroup row className="p-4 pb-0">  
                            <Label for="surname" sm={2}>Surname</Label>  
                            <Col sm={10}>  
                                <Input type="text" name="surname" value={this.state.surname} onChange={this.onChangeSurname} placeholder="Enter Surname" />  
                            </Col>  
                        </FormGroup>  
                         <FormGroup row className="p-4 pb-0">  
                            <Label for="email" sm={2}>Email</Label>  
                            <Col sm={10}>  
                                <Input type="text" name="email" value={this.state.email} onChange={this.onChangeEmail} placeholder="Enter Email" />  
                            </Col>  
                        </FormGroup>  
                         <FormGroup row className="p-4 pb-0">  
                            <Label for="phoneNumber" sm={2}>Phone Number</Label>  
                            <Col sm={10}>  
                                <Input type="text" name="phoneNumber"value={this.state.phoneNumber} onChange={this.onChangePhoneNumber} placeholder="Enter Phone Number" />  
                            </Col>  
                        </FormGroup>   
                        <FormGroup row className="p-4 pb-0">  
                            <Label for="dateOfBirth" sm={2}>Date of Birth</Label>  
                            <Col sm={10}>  
                                <Input type="date" name="dateOfBirth"value={this.state.dateOfBirth.toString()} onChange={this.onChangeDateOfBirth} placeholder="Enter Data of Birth" />  
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
  
export default Edit;  