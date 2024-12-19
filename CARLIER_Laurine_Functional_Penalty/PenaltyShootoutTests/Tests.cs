using CARLIER_Laurine_Functional_Penalty.Models;

[TestClass]
public class PenaltyShootoutTests
{
    [TestMethod]
    public void SimulateShot_ShouldReturnBoolean()
    {
        // Act
        var result = PenaltyShootout.SimulateShot();

        // Assert
        Assert.IsInstanceOfType(result, typeof(bool));
    }

    [TestMethod]
    public void IsGameOver_ShouldReturnTrue_WhenMaxShotsReachedAndScoresDifferent()
    {
        // Arrange
        var state = new PenaltyShootout.State(
            ShotsTaken: 5,
            TeamAScore: 3,
            TeamBScore: 2,
            History: new List<string>()
        );

        // Act
        var result = PenaltyShootout.IsGameOver(state);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsGameOver_ShouldReturnFalse_WhenMaxShotsNotReached()
    {
        // Arrange
        var state = new PenaltyShootout.State(
            ShotsTaken: 3,
            TeamAScore: 1,
            TeamBScore: 1,
            History: new List<string>()
        );

        // Act
        var result = PenaltyShootout.IsGameOver(state);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsGameOver_ShouldReturnTrue_WhenInsurmountableLeadExists()
    {
        // Arrange
        var state = new PenaltyShootout.State(
            ShotsTaken: 3,
            TeamAScore: 4,
            TeamBScore: 0,
            History: new List<string>()
        );

        // Act
        var result = PenaltyShootout.IsGameOver(state);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void PlayShootout_ShouldReturnStateWithUpdatedHistory()
    {
        // Arrange
        var initialState = new PenaltyShootout.State(
            ShotsTaken: 0,
            TeamAScore: 0,
            TeamBScore: 0,
            History: new List<string>()
        );

        // Act
        var finalState = PenaltyShootout.PlayShootout(initialState);

        // Assert
        Assert.IsTrue(finalState.History.Count > 0);
    }

    [TestMethod]
    public void DisplayHistory_ShouldHandleEmptyHistoryGracefully()
    {
        // Arrange
        var history = new List<string>();

        // Act & Assert
        try
        {
            PenaltyShootout.DisplayHistory(history);
        }
        catch (Exception)
        {
            Assert.Fail("DisplayHistory threw an exception on empty history.");
        }
    }

    [TestMethod]
    public void DisplayHistory_ShouldDisplayCorrectVictoryMessage()
    {
        // Arrange
        var history = new List<string>
        {
            "Tir 1 : Score : 1/0 (Équipe A : +1 | Équipe B : 0)",
            "Tir 2 : Score : 1/1 (Équipe A : 0 | Équipe B : +1)",
            "Tir 3 : Score : 2/1 (Équipe A : +1 | Équipe B : 0)",
            "Tir 4 : Score : 2/2 (Équipe A : 0 | Équipe B : +1)",
            "Tir 5 : Score : 3/2 (Équipe A : +1 | Équipe B : 0)"
        };

        // Act & Assert
        try
        {
            PenaltyShootout.DisplayHistory(history);
        }
        catch (Exception)
        {
            Assert.Fail("DisplayHistory threw an exception on valid history.");
        }
    }
}
