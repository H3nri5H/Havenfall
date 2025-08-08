using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private void Awake()
    {
        // Sicherstellen, dass nur eine Instanz existiert
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);

        // Nach 1 Sekunde ins Hauptmenü wechseln
        Invoke(nameof(LoadMainMenu), 1f);
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
