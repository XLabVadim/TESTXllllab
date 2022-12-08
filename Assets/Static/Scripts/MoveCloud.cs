using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    [SerializeField]
    private CloudAnimation m_cloud;
    [SerializeField]
    private Transform[] villagers;
    private Transform cloud;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private int i =0;

    public void Action()
    {
        if(cloud == null)
        {
            m_cloud.StopRain();
            cloud = villagers[i];
            if (++i >= villagers.Length)
            {
                i = 0;
            }
        }
    }
    
    void Update()
    {
        MoveToTarget();
        /*if(Input.GetKey(KeyCode.Z))
        {
            transform.position = Vector3.MoveTowards(transform.position, villagers[i].position, speed * Time.deltaTime);
            if (transform.position == villagers[i].position)
            {
                i++;
            }
            if(i > 2) i = 0;
        }*/
    }

    private void MoveToTarget()
    {
        if (cloud != null)
        {
            var cloudPos = m_cloud.transform.position;
            var pos = cloud.position;
            pos.y = cloudPos.y;
            cloudPos = Vector3.Lerp(cloudPos, pos, Time.deltaTime * speed);
            if (Vector3.Distance(cloudPos, pos) < 0.1f)
            {
                cloud = null;
                OnMoveComplete();
            }
            m_cloud.transform.position = cloudPos;
        }
    }

    private void OnMoveComplete()
    {
        m_cloud.StartRain();
    }
}
