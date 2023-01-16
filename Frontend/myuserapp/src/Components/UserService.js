import axios from "axios";

class UserService{

constructor(){
    this.baseurl="http://localhost:5110/api/Users";
}

getAllUsers(){
    return axios.get(this.baseurl);
}

}

export default new UserService();