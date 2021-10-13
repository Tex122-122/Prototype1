using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    public Transform Camera;
    public GameObject Arrow;
    public float speed = 100f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject arrow = Instantiate(Arrow, transform.position, Camera.rotation);
            arrow.transform.rotation = Quaternion.Euler(Camera.forward);
            Rigidbody arrowRB = arrow.GetComponent<Rigidbody>();
            arrowRB.AddForce(arrow.transform.forward * speed);
        }
    }
}
