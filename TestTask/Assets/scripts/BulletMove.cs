using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    private Rigidbody2D cubeBody;
    private void Start()
    {
        cubeBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update () {
        cubeBody.velocity = new Vector2(0f, 25f);
	}
}
