import { Link } from "react-router-dom";

export default function FeatureSection() {
  return (
    <section className="py-5 bg-light" id="Features">
      <div className="container">
        <h2 className="text-center fw-bold mb-5">
          Everything Your Clinic Needs
        </h2>

        <div className="row g-4">

          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">AI Call Handling</h5>
                <p className="card-text text-muted">
                  Never miss a call. Our AI answers patient calls, responds to common questions,
                  and helps book appointments automatically.
                </p>
              </div>
            </div>
          </div>


          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">Smart Appointment Booking</h5>
                <p className="card-text text-muted">
                  Let patients view available times and request appointments through a 
                  simple booking experience connected to your clinic.
                </p>
              </div>
            </div>
          </div>


          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">Patient Communication</h5>
                <p className="card-text text-muted">
                  Keep patients connected with your clinic through clear, timely communication 
                  before and after their appointments.
                </p>
              </div>
            </div>
          </div>


          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">Clinic Dashboard</h5>
                <p className="card-text text-muted">
                  Manage appointments, patient activity, and clinic operations from one centralized
                  and easy-to-use dashboard.
                </p>
              </div>
            </div>
          </div>

          
          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">Automated Notifications</h5>
                <p className="card-text text-muted">
                  Send automatic appointment confirmations, reminders, and updates to help 
                  reduce missed appointments and keep patients informed.
                </p>
              </div>
            </div>
          </div>


          <div className="col-md-4">
            <div className="card h-100 border-0 shadow-sm">
              <div className="card-body">
                <h5 className="card-title fw-bold">Booking Link</h5>
                <p className="card-text text-muted">
                  Give your clinic a personalized booking link that patients can use to request
                  appointments quickly from any device.
                </p>
              </div>
            </div>
          </div>

          
        

        </div>
      </div>
    </section>
  );
}
