using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private SpawnStone _stone;
    [SerializeField]
    private MoveCloud _cloud;
    [SerializeField]
    private Tools _tools;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (_stone)
            {
                _stone.Spawn();
            }
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            _cloud.Action();
        }
        if (Input.GetKeyDown(KeyCode.Space))
		{
			_tools.Action();
		}
    }
}
