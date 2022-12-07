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
    private bool m_isDown;
    void Update()
    {   
        var angels = m_tools.localEulerAngles;
        m_timer += Time.deltaTime;
        //var x = Mathf.Cos(Mathf.PI * m_timer * speed) * range;
        //var target = range * (m_isDown & -1f : 1f);
        //var x = Mathf.MoveTowardsAngle(angels.x, )
        angels.x = x;


        m_tools.localEulerAngles = angels;
    }
    void Up()
}
