using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public GameObject levelWonUI;

    public void GameOver()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Restart();
        }
        
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LevelComplete()
    {
        levelWonUI.SetActive(true);
    }
}
