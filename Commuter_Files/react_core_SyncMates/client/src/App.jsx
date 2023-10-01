/* eslint-disable react/jsx-no-undef */
/* eslint-disable no-unused-vars */
import { useState } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Login from "./Pages/login";
import Home from "./Pages/Home";
import Dashboard from "./Pages/dashboard";

export default function App() {
  return (
    <> 
      <Router>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/login" element={<Login />} />
            <Route path="/dashboard" element={<Dashboard />} />
          </Routes>
      </Router>
    </>
  );
}

{
  /* <Route path='/category/:id' element={<Category />} />
<Route path='/product/:id' element={<SingleProduct />} />
<Route path='/comingSoon' element={<SubscriberPage />} />
<Route path='/login' element={<SubscriberPage />} /> */
}
