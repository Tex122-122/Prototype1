using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Speed * Vector3.forward * Time.deltaTime;
    }
}
