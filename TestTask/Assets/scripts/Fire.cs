using System.Collections;
using UnityEngine;
using Assets.scripts;



public class Fire : MonoBehaviour
{
    
    public GameObject cube;
    public GameObject bullet;
    private Vector2 bulletPos;
    private Settings cubeSettings = new Settings();
    void Awake()
    {
        
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj()
    {

        while (true)
        {
            
            bulletPos = cube.transform.position;
            bulletPos += new Vector2(0f, +1f);
            Instantiate(bullet, bulletPos, Quaternion.identity);
            yield return new WaitForSeconds(cubeSettings.speed);
        }
    }
    
}