//Header function to explain the app
import logo from './logo.svg';

function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        {/* Uses the logo */}
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        {/* Receives props passed from app.tsx */}
        <h1 className="text-white">{props.title}</h1>
        <p className="text-white">
          This is part of a database that lists the Bowlers and their
          information on the Marlins and Sharks teams.
        </p>
      </div>
    </header>
  );
}

export default Header;
