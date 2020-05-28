using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRed(float value)
    {
        ani.SetFloat("Red", value);
    }

    public void SetGreen(float value)
    {
        ani.SetFloat("Green", value);
    }

    public void SetBlue(float value)
    {
        ani.SetFloat("Blue", value);
    }
}
