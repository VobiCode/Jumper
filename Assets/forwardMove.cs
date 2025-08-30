using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FOrwardmove : MonoBehaviour
{
    public game_master gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("game_master").GetComponent<game_master>();

    }

    // Update is called once per frame 
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(1, 0, 0) * Time.deltaTime * 3;
        if (gameObject.transform.position.x > 56)
        {
            gm.points++;
            Destroy(gameObject);
        }
    } 

     
    private void OnTriggerEnter(Collider other)
    {
        gm.hp--;
        Destroy(gameObject);
    } 
} 
 