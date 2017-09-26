using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Se encarga de administrar las escenas

public class LevelManager : MonoBehaviour {

    public void LoadLevel (string LevelName) //Carga nivel
    {
        SceneManager.LoadScene(LevelName);
        Time.timeScale = 1f; // 0 = quieto, 1 = velocidad de juego normal (100%)

    }
}
