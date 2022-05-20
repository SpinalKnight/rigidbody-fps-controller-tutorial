using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform Spawn;

    public float groundDistance;
    public LayerMask deathMask;
    bool kill;

    public PlayerMovement player;
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            player.Timer = 0;
            player.moved = false;
            player.rb.velocity = Vector3.zero;
        }
    }

    private void LateUpdate()
    {
        transform.rotation = Spawn.transform.rotation;

    }
}
