using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Transform Target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, Target.position);
        Vector3 targerPos;
        if (dis <= 8) 
        {
            targerPos = new Vector3(transform.position. x, 0.5f, transform.position.z);
        }
        else 
        {
            targerPos = new Vector3(transform.position.x, -2, transform.position.z);

        }
        transform.position = Vector3.Lerp(transform.position, targerPos, 0.05f);
        
    }
}
