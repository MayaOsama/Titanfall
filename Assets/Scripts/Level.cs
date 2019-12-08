using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToLoadouts()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCombatLevel()
    {
        SceneManager.LoadScene("Level 1"); // TODO change to correct scene name
    }

    public void GoToParkourLevel()
    {
        SceneManager.LoadScene("Parkour");
    }

    public void GoToGameOverParkour()
    {
        SceneManager.LoadScene("Game Over - Parkour");
    }

    public void GoToGameOverCombat()
    {
        SceneManager.LoadScene("Game Over - Combat");
    }

    public void GoToWin()
    {
        SceneManager.LoadScene("Win");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
