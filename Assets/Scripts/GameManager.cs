using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoverCanvas;

    void Start()
    {
        Time.timeScale =  1;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public  void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
