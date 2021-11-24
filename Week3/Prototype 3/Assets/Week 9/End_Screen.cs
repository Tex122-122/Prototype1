using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Screen : MonoBehaviour
{
    public GameObject EndScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            EndScreen.gameObject.SetActive(true);
        }
    }
}
