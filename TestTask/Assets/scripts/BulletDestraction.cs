using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestraction : MonoBehaviour {

	
	
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            Destroy(gameObject);
        }
    }
}
