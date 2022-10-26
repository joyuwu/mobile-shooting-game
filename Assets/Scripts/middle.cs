using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player.position + enemy.position) / 2;
    }
}
