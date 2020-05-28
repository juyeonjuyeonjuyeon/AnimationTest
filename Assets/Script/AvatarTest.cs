using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarTest : MonoBehaviour
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

    public void OnMove(float value)
    {
        if(value > 0) { ani.SetLayerWeight(1, 1); }
        else { ani.SetLayerWeight(1, 0); }
        
        ani.SetFloat("Speed", value);
    }
}
