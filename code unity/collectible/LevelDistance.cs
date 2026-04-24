using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelDistance : MonoBehaviour
{
    public GameObject DistanceDisplay;
    public GameObject DistanceEndDisplay;

    public int DistanceRun;
    public bool addingDistance = false;
    public float DistanceDelay = 0.35f;

    void Update()
    {
        if (!addingDistance)
        {
            addingDistance = true;
            StartCoroutine(AddDistance());
        }
    }

    IEnumerator AddDistance()
    {
        DistanceRun += 1;

        
        if (DistanceDisplay != null)
        {
            DistanceDisplay.GetComponent<TMP_Text>().text = DistanceRun.ToString();
        }

        
        if (DistanceEndDisplay != null)
        {
            DistanceEndDisplay.GetComponent<TMP_Text>().text = DistanceRun.ToString();
        }

        yield return new WaitForSeconds(DistanceDelay);
        addingDistance = false;
    }
}
