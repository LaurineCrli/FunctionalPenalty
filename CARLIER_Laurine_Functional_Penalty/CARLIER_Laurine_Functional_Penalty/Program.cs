using static CARLIER_Laurine_Functional_Penalty.Models.PenaltyShootout;

namespace CARLIER_Laurine_Functional_Penalty
{
    internal class Program
    {
        static void Main()
        {
            var initialState = new State(0, 0, 0, new List<string>());
            var finalState = PlayShootout(initialState);

            DisplayHistory(finalState.History);
        }
    }
}
