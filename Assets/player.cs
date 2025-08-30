using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    public game_master gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("game_master").GetComponent<game_master>();
        rb = gameObject.GetComponent<Rigidbody>();

    }  

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < 3)
            if(Input.GetKeyDown(KeyCode.Space) == true)
            {
             rb.AddForce(new Vector3(0, 1, 0) * Random.Range(gm.min_j, gm.max_j), ForceMode.Impulse);
            }
    }  
} 
