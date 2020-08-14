
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool GamehasEnded=false;
    public float RestartDelay = 1f;

    public GameObject completeLevelui;
    public void CompletedLevel()
    {
        completeLevelui.SetActive(true);
    }
   public void EndGame()
    {
        if(GamehasEnded==false)
        {
            GamehasEnded = true;
            Debug.Log("Game Ended");
            Invoke("Restart", RestartDelay);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
