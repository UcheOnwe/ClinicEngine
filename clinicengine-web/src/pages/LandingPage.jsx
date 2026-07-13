import { Link } from "react-router-dom";
import NavBar from "../components/NavBar";
import FeattureSection from "../components/FeatureSection";
import HowItWorks from "../components/HowItWorks";
import Footer from "../components/Footer";

export default function LandingPage() {
  return (
    <>
      <NavBar />

      <main>
        <section className="py-5 text-center">
          <div className="container">
            <h1 className="display-4 fw-bold">
              Never Miss a Clinic Call Again
            </h1>

            <p className="lead text-muted">
              ClinicEngine automates appointment booking, handles calls with AI,
              and keeps your clinic running smoothly - 24/7
            </p>

            <div className="d-flex gap-3 justify-content-center">
              <Link to="/register" className="btn btn-primary">
                Get Started
              </Link>
              <a href="#Features" className="btn btn-outline-secondary btn-lg">
                See How It Works
              </a>
            </div>
          </div>
        </section>

        <FeattureSection />
        <HowItWorks/>
        <Footer/>
      </main>
    </>
  );
}
