import { Link } from "react-router-dom";

export default function NavBar(){
    return(
        <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
            <div className="container px-5">
                <Link to="/" className="navbar-brand">ClinicEngine</Link>

                <button className="navbar-toggler" type="button" data-bs-toggle="collapse"
                data-bs-target="#expandablen-navBar"
                >
                    <span className="navbar-toggler-icon"></span>
                </button>

                <div className="collapse navbar-collapse" id="expandablen-navBar">
                    <ul className="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <Link to="/" className="nav-link">Home</Link>
                        </li>

                        <li className="nav-item">
                            <Link to="#Features" className="nav-link">Features</Link>
                        </li>

                        <li className="nav-item">
                            <Link to="#How it works" className="nav-link">How it works</Link>
                        </li>

                        <li className="nav-item">
                            <Link to="#About" className="nav-link">About</Link>
                        </li>
                    </ul>

                    <Link to="/register" className="btn btn-light ms-3">Get Started</Link>

                </div>
            </div>

            
        </nav>
    )
}