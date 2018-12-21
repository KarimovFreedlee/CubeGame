using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCreate : MonoBehaviour {

    public GameObject circle;
    void Start()
    {
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj()
    {
        while(true)
        {
            
            Instantiate(circle, new Vector2(Random.Range(-8f,8f), Random.Range(2f,4f)), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f,3f));
        }
    }
   
}
