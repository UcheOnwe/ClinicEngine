import {  BrowserRouter, Routes, Route } from "react-router-dom";
import LandingPage from "./pages/LandingPage";
import CreateClinicPage from "./pages/CreateClinicPage";

function App(){
  return(
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<LandingPage/>}/>
        <Route path= "/register" element={<CreateClinicPage/>}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App;