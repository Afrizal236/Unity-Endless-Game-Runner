using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        if (coinCountDisplay != null)
        {
            coinCountDisplay.GetComponent<TMP_Text>().text = coinCount.ToString();
        }

        if (coinEndDisplay != null)
        {
            coinEndDisplay.GetComponent<TMP_Text>().text = coinCount.ToString();
        }
    }
}
