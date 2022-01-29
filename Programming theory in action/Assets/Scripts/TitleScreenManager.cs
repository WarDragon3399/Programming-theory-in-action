using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class TitleScreenManager : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;

    private void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClick);
        quitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnStartButtonClick()
    {
        GameManager.instance.StartGame();
    }

    private void OnQuitButtonClick()
    {
        GameManager.instance.QuitGame();
    }
}
