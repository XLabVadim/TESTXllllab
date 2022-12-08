using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpaw : MonoBehaviour

{
    public GameObject stonee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(stonee, transform.position, Quaternion.identity);
        }
    }
}
