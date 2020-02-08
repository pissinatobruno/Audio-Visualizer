using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    bool Pausado = false;

    public void pauseGame()
    {
        if (Pausado)
        {
            Time.timeScale = 1;
            Pausado = false;
        }
        else
        {
            Time.timeScale = 0;
            Pausado = true;
        }
    }
}
