using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public MeshFilter firstTools;
    public Mesh NewTools;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            firstTools.mesh = NewTools;
        }
    }
}
