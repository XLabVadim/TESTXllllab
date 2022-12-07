using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform m_tools;

    public float range = 30f;
    public float speed = 1f;
    private float m_timer = 0f; 
    // Update is called once per frame
    void Update()
    {
        var angels = m_tools.localEulerAngles;
        m_timer += Time.deltaTime;
        var x = Mathf.Cos(Mathf.PI * m_timer * speed) * range;
        angels.x = x;


        m_tools.localEulerAngles = angels;
    }
}
