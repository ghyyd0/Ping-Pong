using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGamesScene()
    {
        GameStates.npcScore = 0;
        GameStates.playerScore = 0;
        SceneManager.LoadScene("Game");
    }
    public void ApplicationExit()
    {
        Application.Quit();
    }
 
}
