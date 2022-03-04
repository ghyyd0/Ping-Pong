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
            GameStates.playerScore++;
        }
        Debug.Log(GameStates.playerScore + ":" + GameStates.npcScore);


        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
