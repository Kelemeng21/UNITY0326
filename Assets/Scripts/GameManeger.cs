using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class GameManeger : MonoBehaviour
{
   public static GameManeger instance;

    [SerializeField]
    private GameObject _GameOverCanvas;

    private void Awake()
    {
        if (instance == null) { 
            instance = this;
        }
    }

    public void GameOver()
    {
        _GameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    
}
