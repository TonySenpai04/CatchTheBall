using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI: MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoretext;
    public GameObject gameoverPanel;
    public void setcoretext(string txt)
    {
        if (scoretext)
            scoretext.text = txt;
    }
    public void showgameoverpannel(bool isshow)
    {
        if (gameoverPanel)
            gameoverPanel.SetActive(isshow);
    }
}
