using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
   public void Pausegame()
    {
        Time.timeScale = 0f;
    }
    public void Resumagame()
    {
        Time.timeScale = 1.0f;
    }
}
