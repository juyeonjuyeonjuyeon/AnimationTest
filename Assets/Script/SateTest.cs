using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateTest : MonoBehaviour
{
    Animator ani;
    // Start is called before the first frame update
    bool playByUpdate;
    float m_PlayTime;
    
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(playByUpdate)
        {
            m_PlayTime += 0.1f;
            ani.SetFloat("PlayTime", m_PlayTime);
        }
    }

    public void OnChangeSpeed(float value)
    {
        ani.SetFloat("Speed", value);
    }

    public void OnChangeTime(float value)
    {
        ani.SetFloat("PlayTime", value);
    }

    public void OnPlayByUpdate(bool value)
    {
        playByUpdate = value;
        ani.SetBool("playByUpdate", value);
    }

    public void GetInfo()
    {

    }

}
