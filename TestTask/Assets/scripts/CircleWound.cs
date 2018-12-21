using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleWound : MonoBehaviour {
    public GameObject bullet;
    private Color circleHit;
    private Color defaultColor;
    private int circleHp;
    

    private void Awake()
    {     
        circleHit = GetComponent<Renderer>().material.color;
    }

    void Start ()
    {
       
        defaultColor = GetComponent<Renderer>().material.color;
       circleHp = Random.Range(2, 5);
      
    }
    void Update()
    {

       
        if (circleHit != defaultColor)
        {
            new WaitForSeconds(0.5f);
            circleHit = defaultColor;
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            circleHit = Color.blue;
            circleHp--;
            if (circleHp <= 0)
            {
                circleDestroy(circleHp); 
            }
            
        }
        
    }
    
    private void circleDestroy(int circleHp)
    {
       
        if(circleHp==0)
        {
            Destroy(gameObject);
            
        }
        
    }
}
