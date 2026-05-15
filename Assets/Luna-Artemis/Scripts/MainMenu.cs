using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject optionsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }
    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

}
