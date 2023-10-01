/* eslint-disable no-unused-vars */
import React from "react";
import logo from '../assets/logo.png'
import { useNavigate } from "react-router-dom";

const Header = () => {

  const navigate = useNavigate();

  return (
    <div className="w-full h-20 flex justify-between px-4 items-center shadow-b">
      <div className="min-w-52 px-4 h-full items-center justify-center gap-4 flex" onClick={() => navigate('/')}>
        <img src={logo} alt="" className="w-12"/>
        <h2 className="text-4xl font-extrabold cursor-pointer text-white">SyncMates</h2>
      </div>
      <div className="">
        <h2 className="text-2xl font-bold cursor-pointer text-gray-400">
          Hi, Kunal
        </h2>
      </div>
    </div>
  )
};

export default Header;
