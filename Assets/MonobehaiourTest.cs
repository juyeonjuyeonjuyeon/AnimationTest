using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonobehaiourTest : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(" Awake ");
    }

    void OnEnable()
    {
        Debug.Log(" OnEnable ");
    }

    void Start()
    {
        Debug.Log(" Start ");    
    }

    void Update()
    {
        Debug.Log("<color=orange> Update </color>");    
    }

    void LateUpdate()
    {
        Debug.Log("<color=green> LateUpdate </color>");    
    }
}
