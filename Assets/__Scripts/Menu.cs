using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Canvas MainCanvas;
    public Canvas HelpCanvas;

    void Awake() {
        HelpCanvas.enabled = false;
    }

    public void HelpOn()
    {
        HelpCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        HelpCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene("__Bartok_Scene_0");
    }
}
