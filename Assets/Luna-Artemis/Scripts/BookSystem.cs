using UnityEngine;

public class BookSystem : MonoBehaviour
{
    public GameObject bookPanel;
    public GameObject bookPanel2;
    public void OpenBook()
    {
        bookPanel.SetActive(true);
        bookPanel2.SetActive(false);
    }
    public void CloseBook()
    {
        bookPanel.SetActive(false);
        bookPanel2.SetActive(false);
    }

    public void NextPage()
    {
        bookPanel.SetActive(false);
        bookPanel2.SetActive(true);
    }
    public void Retry()
    {
        bookPanel.SetActive(true);
        bookPanel2.SetActive(false);
    }
}
