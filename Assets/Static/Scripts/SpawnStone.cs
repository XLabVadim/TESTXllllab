using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public GameObject stone;
    
    public void Spawn()
    {
        var position = transform.position;
        var rotation = transform.rotation;
        GameObject.Instantiate(stone, position, rotation);
    }
}
