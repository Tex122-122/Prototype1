using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollwer : MonoBehaviour
{
    public GameObject Player;

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z); 

    }
}
