import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  //Filters to show only the two teams
  const filteredBowlers = bowlerData.filter(
    (bowler) =>
      bowler.team.teamName === 'Marlins' || bowler.team.teamName === 'Sharks',
  );

  // stops constant refreshing
  useEffect(() => {
    const fetchBowlerData = async () => {
      //Access JSON data fron the .NET side
      const rsp = await fetch('http://localhost:5233/Bowler');
      const f = await rsp.json();
      setBowlerData(f);
    };

    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Best Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>PhoneNumber</th>
          </tr>
        </thead>
        <tbody>
          {filteredBowlers.map((bowler) => (
            <tr key={bowler.bowlerId}>
              <td>
                {/* Full name in one column */}
                {bowler.bowlerFirstName} {bowler.bowlerMiddleInit}{' '}
                {bowler.bowlerLastName}
              </td>
              <td>{bowler.team.teamName}</td>
              <td>{bowler.bowlerAddress}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
// export to be able to use in App.tsx
export default BowlerList;
