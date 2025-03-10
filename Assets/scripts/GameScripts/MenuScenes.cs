using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScenes : MonoBehaviour
{
    public string menuSceneName = "MainMenu";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ReturnToMainMenu();
        }
    }

    void ReturnToMainMenu()
    { 
        SceneManager.LoadScene(menuSceneName);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Debug.Log("Игра завершилась");
        Application.Quit();
    }
}
