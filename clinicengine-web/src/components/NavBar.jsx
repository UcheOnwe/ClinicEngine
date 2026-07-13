import { Link } from "react-router-dom";

export default function NavBar(){
    return(
        <nav className="navbar navbar-expand-lg navbar-dark bg-primary sticky-top">
            <div className="container px-5">
                <a href="/" className="navbar-brand">ClinicEngine</a>

                <button className="navbar-toggler" type="button" data-bs-toggle="collapse"
                data-bs-target="#expandablen-navBar"
                >
                    <span className="navbar-toggler-icon"></span>
                </button>

                <div className="collapse navbar-collapse" id="expandablen-navBar">
                    <ul className="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <a href="/" className="nav-link">Home</a>
                        </li>

                        <li className="nav-item">
                            <a href="#Features" className="nav-link">Features</a>
                        </li>

                        <li className="nav-item" id="how-it-works">
                            <a href="#How It Works" className="nav-link">How it works</a>
                        </li>

                        <li className="nav-item">
                            <a href="#About" className="nav-link">About</a>
                        </li>
                    </ul>

                    <Link to="/register" className="btn btn-light ms-3">Get Started</Link>

                </div>
            </div>

            
        </nav>
    )
}