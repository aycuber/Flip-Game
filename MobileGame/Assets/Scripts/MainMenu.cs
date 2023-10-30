using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
      SceneManager.LoadScene("GameScene");
    }

    public void GoToSettingsMenu()
    {
      SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu()
    {
      SceneManager.LoadScene("TitleScene");
    }

    public void QuitGame()
    {
      Application.Quit();
    }
    // Start is called before the first frame update

}
