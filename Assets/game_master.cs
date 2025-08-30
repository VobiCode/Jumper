using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_master : MonoBehaviour
{
    public int hp;
    public int points;
    public Text hp_text;
    public Text points_text;
    public GameObject main_menu;
    public GameObject game_menu;
    public GameObject dead_menu;
    public GameObject spawner;
    public Text final_points;
    public float min_time; 
    public float max_time;  
    public float min_j; 
    public float max_j;
    public GameObject player_easy;
    public GameObject player_norm;
    public GameObject player_hard;
    public GameObject dis_menu;
    // Start is called before the first frame update
    void Start()
    {
        hp_text = GameObject.Find("Hp").GetComponent<Text>(); 
        points_text = GameObject.Find("Points").GetComponent<Text>();
        main_menu = GameObject.Find("main_menu");
        game_menu = GameObject.Find("game_menu");
        dead_menu = GameObject.Find("dead_menu");
        dis_menu = GameObject.Find("dis_menu");
        spawner = GameObject.Find("spawner");
        final_points = GameObject.Find("flp").GetComponent<Text>();
        player_easy = GameObject.Find("Chicken_001");
        player_norm = GameObject.Find("Pinguin_001");
        player_hard = GameObject.Find("Kitty_001");
        Open_main_menu();
        spawner.SetActive(false); 
        hp = 1; 
    }

    // Update is called once per frame 
    void Update()
    {
        hp_text.text = hp.ToString(); 
        points_text.text = points.ToString();
        final_points.text = points.ToString();
        if (hp <= 0)
        {
            Open_death_menu();
            hp = 0;  
        }
    }
    public void Open_main_menu()
    { 
        main_menu.SetActive(true);
        game_menu.SetActive(false);
        dead_menu.SetActive(false);
        dis_menu.SetActive(false);
        spawner.SetActive(false);
        points = 0;
        player_easy.SetActive(false);
        player_norm.SetActive(false);
        player_hard.SetActive(false);
        hp = 5; 
    } 
    public void Open_game_menu()
    {
        main_menu.SetActive(false);
        game_menu.SetActive(true); 
        dead_menu.SetActive(false);
        spawner.SetActive(true);
        dis_menu.SetActive(false);
        points = 0; 
    }
    public void Open_death_menu()
    {
        main_menu.SetActive(false);
        game_menu.SetActive(false);
        dead_menu.SetActive(true);
        spawner.SetActive(false);
        dis_menu.SetActive(false);
        hp = 5;
        player_easy.SetActive(false); 
        player_norm.SetActive(false);
        player_hard.SetActive(false); 
    }
    public void Easy_dif()
    { 
        min_time = 3;
        max_time = 5;
        min_j = 6;
        max_j = 8;
        player_easy.SetActive(true);
        hp = 5;
        game_menu.SetActive(true);
        main_menu.SetActive(false);
        spawner.SetActive(true);
    } 
    public void Norm_dif()
    {
        min_time = 1.5f;
        max_time = 3;
        player_norm.SetActive(true); 
        hp = 3;
        min_j = 6.5f;
        max_j = 7;
        game_menu.SetActive(true);
        main_menu.SetActive(false);
        spawner.SetActive(true);
    }


    public void Hard_dif()
    {
        min_time = 1.4f;
        max_time = 2.60f;
        min_j = 5.5f;  
        max_j = 6;
        player_hard.SetActive(true);
        hp = 1;
        game_menu.SetActive(true);
        main_menu.SetActive(false); 
        spawner.SetActive(true);
    }   
    public void Open_dis()
    {
        main_menu.SetActive(false);
        game_menu.SetActive(false);
        dis_menu.SetActive(true);
        dead_menu.SetActive(false);
    } 
     
    public void Exit()
    { 
        Application.Quit();
    }

}

 