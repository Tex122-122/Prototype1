using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
   public GameObject Arrow;
    public float speed = 10000f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject arrow = Instantiate(Arrow, transform.position, Arrow.transform.rotation);
            arrow.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.forward, Camera.main.transform.up);
            Rigidbody arrowRB = arrow.GetComponent<Rigidbody>();
            arrowRB.AddForce(-arrow.transform.forward * speed);
        }
    }
}
