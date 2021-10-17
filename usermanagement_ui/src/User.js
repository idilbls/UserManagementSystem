import React,{Component} from "react";
import { Table } from "react-bootstrap";
export class User extends Component{
    constructor(props){
        super(props);
        this.state={deps:[]}
    }
    componentDidMount(){  
        debugger;  
        axios.get('http://localhost:44399/api/User/get_all')  
          .then(response => {  
            this.setState({ deps: response.data });  
            debugger;  
    
          })  
          .catch(function (error) {  
            console.log(error);  
          })  
      }  
      tabRow(){  
        return this.state.deps.map(function(object, i){  
            return <Table obj={object} key={i} />;  
        });  
      }  

    render(){
        const{deps}=this.state;
        return(
            <div className="mt-5 d-flex justify-content-left">
                User Page
                <table className="table table-striped" style={{ marginTop: 10 }}>  
            <thead>  
              <tr>  
                <th>Name</th>  
                <th>Surname</th>  
                <th>Phone</th>  
                <th>Email</th>  
                <th>Date of Birth</th>  
                <th colSpan="4">Action</th>  
              </tr>  
            </thead>  
            <tbody>  
             { this.tabRow() }   
            </tbody>  
          </table>
            </div>
        )
    }
}