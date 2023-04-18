using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScriptStart : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

    public void playDecisionOne() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void playDecisionTwo() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
