using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame_sweet : MonoBehaviour {

    public void LoadTheGame()
    {
        SceneManager.LoadScene(4);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(1);
    }
}
