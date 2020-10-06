Team (Class)
* TeamMembers (List<Persons>)
* TeamName (String)

Person (Class)
* FirstName (String)
* LastName (String)
* EmailAddress (String)
* CellphoneNumber (String)

Tournament (Class)
* TournamentName (String)
* EntreeFee (Decimal)
* ParticipatingTeams (List<Teams>)
* Prizes (List<Prizes>)
* Rounds (List<List<Matches>>)

Prize (Class)
* PlacedNumber (Int)
* PlacedName (String)
* PrizeAmount (Decimal)
* PrizePercentage (Double)

Match
* Entries (List<MatchupEntries>)
* Winner (Team)
* RoundNumber (Int)

MatchupEntry

* MatchEntry (Team)
* Score (Double)
* ParentMatchup (Matchup)
