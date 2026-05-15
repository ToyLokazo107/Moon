using UnityEngine;
using UnityEngine.SceneManagement;
public class AvanceButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}