import React from "react";
import { createClinic } from "../services/clinicService"; //createClinic is a named export and must use
//Curly braces
import { useState } from "react";
import { useNavigate } from "react-router-dom";

//This is like a c# class, just expressed as a function. React prefers functions over
//classes  for components now
export default function CreateClinicForm() {
  // 1. State remembers form values
  const [formData, setFormData] = useState({
    //Capture form data in realtime and store in memory
    //always put in camelCase for json serialization and mapping
    //across frontend and backend. frontend camelCase Backend PascalCase
    name: "",
    phoneNumber: "",
    address: "",
    openingHours: "",
    animalsSeen: "",
  });

  const [error, setError] = useState(null);
  const [success, setSuccess] = useState(false);

  const navigate = useNavigate();

  // 2. Handler updates state on every key press
  function handleChange(e) {
    setFormData({
      ...formData, //handle changes for all 5 form fields
      [e.target.name]: e.target.value, //eg PhoneNumber:346-555-1111
    });
  }

  // 3. Submit - calls API, handles result
  async function handleSubmit(e) {
    e.preventDefault(); //built in method to prevent form data from being wiped after reload
    // so javascript can handle the request to the backend
    try {
      const result = await createClinic(formData); //show success message or redirect
      navigate(`/clinic/${result.id}`)
    } catch (error) {
      setError(error);
    }
  }

  //4. JSX - The actual UI returned
  return (
    <div className="card" >
      <div className="card-body">
        <h5 className="card-title">Register Your Clinic</h5>
        <form onSubmit={handleSubmit}>
          <div className = "mb-3">
          <label htmlfor = "web-name-id" className = "form-label">Clinic Name</label>

          {/* name, value & onchange - input fully controlled, nam tells handleChange which field
          to update, value reads from state, onChange fires on every keypress. */}
          <input
            id = "web-name-id" 
            className = "form-control"
            type="text"
            name="name" 
            value={formData.name}
            onChange={handleChange}
          />
          </div>

          <div className = "mb-3">
          <label htmlFor = "web-phoneNumber-id" className = "form-label">Phone Number</label>
          <input
            id = "web-phoneNumber-id"
            className = "form-control"
            type = "text"
            name = "phoneNumber"
            value = {formData.phoneNumber}
            onChange = {handleChange}
          />
          </div>
          
          <div className = "mb-3">
          <label htmlFor = "web-clinicAddress-id" className = "form-label"> Clinic Address</label>
          <input
            id = "web-clinicAddress-id"
            className = "form-control"
            type = "text"
            name = "address"
            value = {formData.address}
            onChange = {handleChange}
          />
          </div>

          <div className = "mb-3">
          <label htmlFor = "web-openingHours-id" className = "form-label">Clinic Opening Hours</label>
          <input
            id = "web-openingHours-id"
            className = "form-control"
            type = "text"
            name = "openingHours"
            value = {formData.openingHours}
            onChange = {handleChange}
          />
          </div>

          <div className = "mb-3">
          <label htmlFor = "web-animalsSeen-id" className = "form-label">Animals Seen</label>
          <input
            id = "web-animalsSeen-id"
            className = "form-control"
            type = "text"
            name = "animalsSeen"
            value = {formData.animalsSeen}
            onChange = {handleChange}
          />
          </div>

          <button type = "submit" className = "btn btn-primary"> Register Clinic </button>
          {success && (
            <div className = "alert alert-success">
                Clinic Profile Created successfully!
            </div>
          )}

          {error && (
            <div className = "alert alert-danger">
                Something went wrong
            </div>
          )}
        </form>
      </div>
    </div>
  );
}
