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

    public void GoToFirstLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
