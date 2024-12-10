using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public static LoadingManager instance { get; private set; }

    // private void Awake()
    // {
    //     //Keep this object even when we go to new scene
    //     if (instance == null)
    //     {
    //         instance = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    //     //Destroy duplicate gameobjects
    //     else if (instance != null && instance != this)
    //         Destroy(gameObject);
    // }

    // public void LoadCurrentLevel()
    // {
    //     int currentLevel = PlayerPrefs.GetInt("currentLevel", 1);
    //     SceneManager.LoadScene(currentLevel);
    // }
    public void Restart()
    {
        //SceneManager.LoadScene(currentLevel);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                SceneManager.LoadScene(0);
            } else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        //if last scene is reached, load the first scene

    }
}