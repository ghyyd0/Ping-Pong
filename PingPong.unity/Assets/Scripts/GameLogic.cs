using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (GameStates.isPlayerShoot)
        {
            GameStates.playerScore++;
        }
        else
        {
            GameStates.npcScore++;
        }
        Debug.Log(GameStates.playerScore + ":" + GameStates.npcScore);


        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
    private void Update()
    {
        if (GameStates.npcScore > 10 || GameStates.playerScore > 10)
            SceneManager.LoadScene("Finish");
    }
}
