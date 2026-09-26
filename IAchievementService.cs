
namespace GameServicesAndComponentsExercise;
/// <summary>
/// a service for manging achievements
/// </summary>
public interface IAchievementService
{
    /// <summary>
    /// updates an Achievement
    /// </summary>
    /// <param name="achievement">the Achievement name</param>
    /// <param name="progress">the Achievement progress</param>
    public void UpdateAchievement(string achievement, uint progress);
}