/* eslint-disable no-unused-vars */
import React,{useState} from 'react'
import Loader from '../components/Loader'
import { useNavigate } from 'react-router-dom';

const Login = () => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [loader, setLoader] = useState(false);
  const navigate = useNavigate();
 
  const handleClick = () =>{
       navigate('/dashboard')
  }


  return (
    isAuthenticated 
    ? <Loader/>
    :<>
    <div className='w-full min-h-screen flex items-center justify-center'>
      <button className='btn-primary outline-none hover:text-slate-300' onClick={handleClick}>Dashboard</button>
    </div>
    </>

      
  )
}

export default Login