import UserService from "./UserService";
import {useState,useEffect} from "react";

const List = () => {

        let[userArr,setUserArr]=useState([]);

        useEffect(()=>{
            UserService.getAllUsers().then((result)=>{
                setUserArr(result.data)
            }).catch(()=>{});
        },[]);

    const renderList=()=>{
        return userArr.map((user)=>{
            return <tr key={user.userid}><td>{user.userid}</td><td>{user.username}</td><td>{user.course}</td><td>{user.purchasedate}</td></tr>
        });
    }

    return (<div>
        {renderList()}
    </div>);



}
export default List;