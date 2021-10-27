using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Transform Player;
    public float RotationForce;
    public float JumpForce = 100;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 vel = rb.velocity;
        vel.x = 5;
        rb.velocity = vel;
        if (Physics.Raycast(transform.position, Vector3.down, GetComponent<BoxCollider>().size.y / 2 + 0.4f))
        {
            Quaternion rot = Player.rotation;
            rot.z = Mathf.Round(rot.z / 90) * 90;
            Player.rotation = rot;
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector2.up * JumpForce, ForceMode.Impulse);
            }
        }
        else
        {
            Player.Rotate(Vector3.back * RotationForce);
        }
    }   
}

