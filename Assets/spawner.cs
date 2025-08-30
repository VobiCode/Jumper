using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMOveANIMAL : MonoBehaviour
{
    public GameObject[] item;
    public float timer;
    public float NumbTimer;
    public game_master gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("game_master").GetComponent<game_master>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > NumbTimer) 
        {
            Instantiate(item[Random.Range(0, 2)], new Vector3(46.5f, 2, 57.71f), gameObject.transform.rotation);
            timer = 0;
            NumbTimer = Random.Range(gm.min_time, gm.max_time);
        } 

        timer += Time.deltaTime;
    }
}