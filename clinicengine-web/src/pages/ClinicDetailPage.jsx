import { getClinicById } from "../services/clinicService";
import React from "react";
import {useState} from "react";
import { useEffect } from "react";
import { useParams } from "react-router-dom"

export default function ClinicDetailPage(){
    const {id} = useParams(); //use param returns an object
                              //const {id} extracts the id property

    const[clinic, setClinic] = useState(null); //clinic - current clinic data in memory
                                               //setClinic - the function used to update clinic data
    

    //Call getCliniById(id)
    //When the API response arrives: place the response into a variable called clinicData
    //call setClinic(data)
    useEffect(() => {
        getClinicById(id).then((clinicData) => {
            setClinic(clinicData);
        });
    }, []);//short form arrow function declared in useEffect
                //[]dependency arrray, controls when the effect runs
                //[] run this once when the component first appears.
                //[id] runs when id changes

    if(!clinic){
        return(
            <p>Loading Clinic...</p>
        )    
    }

    return(
        <div className="container mt-5">
            <div className="card">
                <div className="card-body">
                    <h2>{clinic.name}</h2>
                    <p>phone: {clinic.phoneNumber}</p>
                    <p>Address: {clinic.address}</p>
                    <p>Your Booking Link: app.clinicengine.com/book/{clinic.slug}</p>
                    <p>Opening Hours: {clinic.openingHours}</p>
                    <p>Animals Seen: {clinic.animalsSeen}</p>
                </div>
            </div>
        </div>
    )

}