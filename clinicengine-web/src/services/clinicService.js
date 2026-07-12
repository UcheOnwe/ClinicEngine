const API_URL = "http://localhost:5145/api/clinics";

export async function createClinic(data){
    const response = await fetch(API_URL, {
        method: "POST",
        headers: { "Content-Type": "application/json" }, //Telling the server what format the
                                                        //request body is in
        body: JSON.stringify(data)
    });

    if(!response.ok){
        const error = await response.json();
        throw error;
    }

    return await response.json();
}

export async function getClinicById(id){
    //string interpolation concept happening with the API URL
    const response = await fetch (`${API_URL}/${id}`, {
        "method": "GET"
    });

    if(!response.ok){
        //read the error from the response and store it in variable error
        const error = await response.json();
        throw error;
    }
    
    return await response.json();
}


