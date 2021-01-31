using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //Exit the game when not launched from inside the Unity Editor.
        Application.Quit();
        //For use inside Unity Engine
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Level1Select()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2Select()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3Select()
    {
        SceneManager.LoadScene(3);
    }
}
