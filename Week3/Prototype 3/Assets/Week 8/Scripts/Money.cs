using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    public static int currentMoney = 0;

    public Text text;

    private void Update()
    {
        text.text = "$" + currentMoney;
    }
}
