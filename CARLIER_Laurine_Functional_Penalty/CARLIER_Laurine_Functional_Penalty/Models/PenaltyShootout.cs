namespace CARLIER_Laurine_Functional_Penalty.Models
{
    public static class PenaltyShootout
    {
        private const int MaxShots = 5;

        public record State(
            int ShotsTaken,
            int TeamAScore,
            int TeamBScore,
            List<string> History
        );

        public static State PlayShootout(State state)
        {
            // Base case: Check if the game is over
            if (IsGameOver(state)) return state;

            // Simulate a shot for each team
            var teamAShot = SimulateShot();
            var teamBShot = SimulateShot();

            // Update scores and history
            var newTeamAScore = state.TeamAScore + (teamAShot ? 1 : 0);
            var newTeamBScore = state.TeamBScore + (teamBShot ? 1 : 0);
            var newHistory = state.History.Append($"Tir {state.ShotsTaken + 1}: Score: {newTeamAScore}/{newTeamBScore} " +
                                                  $"(Équipe A: {(teamAShot ? "+1" : "0")} | Équipe B: {(teamBShot ? "+1" : "0")})").ToList();

            var newState = state with
            {
                ShotsTaken = state.ShotsTaken + 1,
                TeamAScore = newTeamAScore,
                TeamBScore = newTeamBScore,
                History = newHistory
            };

            return PlayShootout(newState); // Recursive call
        }

        public static bool IsGameOver(State state)
        {
            // Check if maximum shots have been taken and scores are unequal
            if (state.ShotsTaken >= MaxShots && state.TeamAScore != state.TeamBScore)
                return true;

            // Check if one team has an insurmountable lead
            var remainingShots = MaxShots - state.ShotsTaken;
            if (state.TeamAScore > state.TeamBScore + remainingShots ||
                state.TeamBScore > state.TeamAScore + remainingShots)
                return true;

            return false;
        }

        public static bool SimulateShot()
        {
            // Simulate a random shot result (true = scored, false = missed)
            return new Random().Next(2) == 1;
        }

        public static void DisplayHistory(IEnumerable<string> history)
        {
            foreach (var line in history)
            {
                Console.WriteLine(line);
            }

            var lastLine = history.LastOrDefault();
            if (lastLine == null)
            {
                Console.WriteLine("Aucune donnée dans l'historique.");
                return;
            }

            // Tente d'extraire les scores avec une validation
            var parts = lastLine.Split(':');
            if (parts.Length < 2)
            {
                Console.WriteLine("Format inattendu de la dernière ligne.");
                return;
            }

            var scorePart = parts[1].Trim();
            var scoreTokens = scorePart.Split('/');
            if (scoreTokens.Length != 2 ||
                !int.TryParse(scoreTokens[0], out var teamAScore) ||
                !int.TryParse(scoreTokens[1], out var teamBScore))
            {
                Console.WriteLine("Impossible de lire les scores dans la dernière ligne.");
                return;
            }

            // Affiche le résultat final
            Console.WriteLine($"Victoire: {(teamAScore > teamBScore ? "Équipe A" : "Équipe B")} (Score: {teamAScore}/{teamBScore})");
        }

    }

}
