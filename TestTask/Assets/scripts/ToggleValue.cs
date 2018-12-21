using UnityEngine;
using UnityEngine.UI;



public class ToggleValue : MonoBehaviour
{
    public GameObject ToggleGroup;
    public Toggle FastFire;
    public Toggle Medium;
    public Toggle Slow;
    public float fireSpeed
    {
        set
        {
            if (FastFire.isOn)
            {
                fireSpeed = 0.2f;
            }
            else if (Medium.isOn)
            {
                fireSpeed = 1.5f;
            }
            else { fireSpeed = 0.2f; }
        }
    }
}
