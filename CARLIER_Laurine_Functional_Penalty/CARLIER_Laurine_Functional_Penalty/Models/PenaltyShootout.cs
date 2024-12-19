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
            // Vérification de la fin du jeu
            if (IsGameOver(state)) return state;

            // Simulation d'un tir pour chaque équipe
            var teamAShot = SimulateShot();
            var teamBShot = SimulateShot();

            // Mise à jour des scores et de l'historique
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

            return PlayShootout(newState); // Appel récursif
        }

        public static bool IsGameOver(State state)
        {
            // Vérification de si le nombre de tirs maximum a été atteint et si les scores sont inégaux
            if (state.ShotsTaken >= MaxShots && state.TeamAScore != state.TeamBScore)
                return true;

            // Vérification de si une équipe a un avantage conséquent / insurmontable
            var remainingShots = MaxShots - state.ShotsTaken;
            if (state.TeamAScore > state.TeamBScore + remainingShots ||
                state.TeamBScore > state.TeamAScore + remainingShots)
                return true;

            return false;
        }

        public static bool SimulateShot()
        {
            // Simulation d'un tir aléatoire
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

            // Tentative d'extraction des scores avec une validation
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

            // Affichage du résultat final
            Console.WriteLine($"Victoire: {(teamAScore > teamBScore ? "Équipe A" : "Équipe B")} (Score: {teamAScore}/{teamBScore})");
        }

    }

}
