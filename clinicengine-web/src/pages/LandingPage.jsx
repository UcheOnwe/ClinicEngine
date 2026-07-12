import { Link } from "react-router-dom";
import NavBar from "../components/NavBar";

export default function LandingPage() {
  return (
    <>
        <NavBar/>
        
        <main>
        

        <div>
            <h1>ClinicEngine</h1>
        </div>

        <div>
            <p>
            Manage your clinic, appointments, and patient communication from one
            platform
            </p>
        </div>

        <Link to="/register" className="btn btn-primary">
            Get Started
        </Link>
        </main>
    </>
  );
}
