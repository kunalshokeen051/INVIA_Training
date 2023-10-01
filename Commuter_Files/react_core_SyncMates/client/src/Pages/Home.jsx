/* eslint-disable no-unused-vars */
import {useState} from "react";
import { useNavigate } from "react-router-dom";
import logo from '../assets/logo.png';

export default function Home() {
   const [isAuthenticated, setIsAuthenticated] = useState(false);
   const navigate = useNavigate();
 
  return (
    <div>
      {/* Home page start */}
      <div className="flex flex-col px-10 w-full h-screen">
        <div className="flex w-1/2 flex-col pt-2  pb-14 gap-2">
          <span className="text-5xl flex items-end gap-2 py-4 font-extrabold mb-10 bg-gradient-to-br from-gr_1 to-gr_2 text-transparent bg-clip-text">
            <img src={logo} alt="" className="w-16 animate-flip"/>
            <p className="text-3xl font-bold">SyncMates</p>
          </span>
        <h2 className="text-8xl">Your Team,</h2>
        <h2 className="text-8xl">Your Rules</h2>
        <div className="flex gap-6">
        <h2 className="text-8xl my-4">Perfectly</h2>
        <h2 className="calli text-8xl my-4 text-gradient_colors-100 p-2 pb-4 font-bold bg-gradient-to-br from-gr_1 to-gr_2 text-transparent bg-clip-text ">Synced</h2>
        </div>
          <div className="btn-primary mt-10 text-xl font-bold w-40" onClick={() =>navigate('/login') }>Get Started</div>
        </div>
        <div className="bg-gradient-to-b pl-4 from-gr_1 to-gr_20 h-[120vh] w-[50%] absolute -top-24 -right-[85px] -rotate-12  overflow-clip">
          <video autoPlay muted loop>
            <source src="/home_footage-3.mp4" />
          </video>
        </div>
        {/* footer start */}
        <div className="slider z-0 w-full h-[80px]">
            <h2 className="item">Empower your team, collaborate effortlessly with our app!</h2>
            <h2 className="item">Boosting Team Productivity, One Collaboration at a Time – Try Our App Today!</h2>
            <h2 className="item">Where Teams Thrive, Success Follows – Embrace Our Collaboration App!</h2>
            <h2 className="item">Empower your team, collaborate effortlessly with our app!</h2>
            <h2 className="item">Boosting Team Productivity, One Collaboration at a Time – Try Our App Today!</h2>
            <h2 className="item">Where Teams Thrive, Success Follows – Embrace Our Collaboration App!</h2>
        </div>
        {/* footer end */}
      </div>
      {/* Home page end */}
    </div>
  );
}
