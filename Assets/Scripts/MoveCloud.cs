using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    [SerializeField]
    private Transform[] villagers;
    public Transform cloud;
    float speed = 10f;
    int i =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            transform.position = Vector3.MoveTowards(transform.position, villagers[i].position, speed * Time.deltaTime);
            if (transform.position == villagers[i].position)
            {
                i++;
            }
            if(i > 2) i = 0;
        }
    }
}
