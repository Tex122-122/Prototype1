using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Paid : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Animator Anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Counter")
        {
            text.text = "$30";

        }

    }

    public void Click()
    {
        Anim.SetBool("Paid", true);
        text.text = "";
        Money.currentMoney += 30;
    }


}
