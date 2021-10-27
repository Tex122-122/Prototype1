using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollwer : MonoBehaviour
{
    public GameObject Player;
    public float offset;

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + offset, this.transform.position.z); 

    }
}
