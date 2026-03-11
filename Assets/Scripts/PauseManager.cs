using UnityEngine;

public class PauseManager : MonoBehaviour
{

    private bool isGamePaused = false;

    [SerializeField]
    private GameObject pauseMenuUI;

    private void Awake ()
        {
            pauseMenuUI.SetActive(false);
        }
    
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;

            

            if (isGamePaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
        }
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
 
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    
}
