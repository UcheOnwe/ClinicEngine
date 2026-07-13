import {  BrowserRouter, Routes, Route } from "react-router-dom";
import LandingPage from "./pages/LandingPage";
import CreateClinicPage from "./pages/CreateClinicPage";
import ClinicDetailPage from "./pages/ClinicDetailPage";


function App(){
  return(
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<LandingPage/>}/>
        <Route path= "/register" element={<CreateClinicPage/>}/>
        <Route path= "/clinic/:id" element={<ClinicDetailPage/>}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App;