using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public GameObject ball;
    public float spawntime;
    int m_core;
    public float m_spawntime;
    bool m_gameover;
    UI m_ui;
    void Start()
    {
        m_spawntime = 0;
        m_ui=FindObjectOfType<UI>();
        m_ui.setcoretext("Scre:"+m_core);
    }

    void Update()
    {
        m_spawntime -= Time.deltaTime;
        if (m_gameover == true)
        {
            m_spawntime = 0;
            m_ui.showgameoverpannel(true);
            Time.timeScale = 0f;
            return;
        }
        else if (m_spawntime <= 0)
        {
            SpawnBall();
            m_spawntime = spawntime;
        }
    }
    public void replay()
    {
        m_core = 0;
        m_gameover = false;
        m_ui.setcoretext("Score:" + m_core);
        m_ui.showgameoverpannel(false);
        Time.timeScale = 1;
    }
    public void setcore(int value)
    {
        m_core = value;
    }
    public int getcore()
    {
        return m_core;
    }
    public void Incrementcore()
    {
        m_core++;
        m_ui.setcoretext("Score:" + m_core);
        if (m_core == 20)
        {
            spawntime = 1.5f;
        }
        if(m_core == 50)
        {
            spawntime = 1;
        }
    }
    public void SpawnBall()
    {
        GameObject Ball1 = ObjectPoling.Instance.GetPoolObject();
        if (Ball1 != null)
        {
            Vector2 NewPoint= new Vector2(Random.Range(-7, 7), 6);
            Ball1.transform.position = NewPoint;
            Ball1.gameObject.SetActive(true);
        }
    }
    public bool isgameover()
    {
        return m_gameover;
    }
    public void setgameover(bool state)
    {
        m_gameover = state;
    }
    public void spawnball()
    {
       Vector2 spawnball = new Vector2(Random.Range(-7, 7), 6);

        if (ball)
        {
             Instantiate(ball, spawnball, Quaternion.identity);
            //ball.SetActive(true);
          
        }
    }
}
