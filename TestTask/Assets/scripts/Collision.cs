using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
    private int cubeHp = 3;
    public Text hpText;
    public GameObject restartMenu;
    public static bool gameOn ;

    void Start()
    {
        hpText.text = ("Your hp: " + cubeHp);
    }
    void Update()
    {
        hpText.text = ("Your hp: " + cubeHp);
        if (cubeHp<=0)
        {
            Lose();
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Circle")
        {
            cubeHp--;
            
        }
    }
    private void Lose()
    {
            Time.timeScale = 0f;
            restartMenu.SetActive(true);
              
    }

    
}

