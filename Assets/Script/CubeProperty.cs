using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeProperty : MonoBehaviour
{
    public float m_FloatType;
    public Color m_Color;
    public Vector2 m_Vec2;
    public Vector3 m_Vec3;
    public Vector4 m_Vec4;
    public Quaternion m_Quaternion;
    public bool m_Bool;
    private float p_FloatType;
    private Color p_Color;
    private Vector2 p_Vec2;
    private Vector3 p_Vec3;
    private Vector4 p_Vec4;
    private Quaternion p_Quaternion;
    private bool p_Bool;
    public GameObject label;
    Text t;

    public float FloatType
    {
        get { return p_FloatType; }
        set { p_FloatType = value; }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        t = label.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
       t.color = m_Color;
    }
}
