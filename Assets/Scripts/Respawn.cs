using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform Spawn;

    public float groundDistance;
    public LayerMask deathMask;
    bool kill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kill = Physics.CheckSphere(transform.position, groundDistance, deathMask);

        if (kill)
        {
            Debug.Log("DEATH");
            transform.position = Spawn.position;
        }
    }
}
