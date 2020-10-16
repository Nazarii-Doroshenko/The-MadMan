using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenButton : MonoBehaviour
{
    public GameObject b;
    public void OnTriggerEnter(Collider other)
    {
        b.SetActive(true);
    }
    public void OnTriggerExit(Collider other)
    {
        b.SetActive(false);
    }
}
