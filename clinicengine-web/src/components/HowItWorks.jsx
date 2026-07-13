import { Link } from "react-router-dom";

export default function HowItWorks() {
  return (
    <section className="py-5" id="How It Works">
      <div className="container">
        <h2 className="text-center fw-bold mb-5">How It Works</h2>
        <div className="row g-4 text-center">
          <div className="col-md-4">
            <div className="display-4 fw-bold text-primary mb-3">1</div>
            <h5 className="fw-bold">Sign Up</h5>
            <p className="text-muted">
              Create your account and select Veterinary Clinic as your business
              type.
            </p>
          </div>

          <div className="col-md-4">
            <div className="display-4 fw-bold text-primary mb-3">2</div>
            <h5 className="fw-bold">Configure Your Clinic</h5>
            <p className="text-muted">
              Add your clinic details, opening hours, services, and staff.
            </p>
          </div>

          <div className="col-md-4">
            <div className="display-4 fw-bold text-primary mb-3">3</div>
            <h5 className="fw-bold">Go Live</h5>
            <p className="text-muted">
              Your AI service activates instantly. Start receiving bookings and
              never miss a call.
            </p>
          </div>
        </div>
      </div>
    </section>
  );
}
