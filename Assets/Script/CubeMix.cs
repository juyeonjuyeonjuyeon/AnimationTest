using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMix : MonoBehaviour
{
    Animation ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnim(int num)
    {
        switch (num)
        {
            case 1: ani.Play("Cube_Mix1"); return;
            case 2: ani.Play("Cube_Mix2"); return;
            case 3: 
                if(ani.IsPlaying("Cube_Mix1")) ani.Blend("Cube_Mix2");
                else ani.Blend("Cube_Mix1");
                return;
            default: ani.Stop(); return;
        }
    }
}
