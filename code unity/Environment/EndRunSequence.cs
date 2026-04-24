using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDistance;
    public GameObject EndScreen; 
    public GameObject fadeOut;

   
    public void TriggerEndSequence()
    {
        StartCoroutine(EndSequence());
    }

    private IEnumerator EndSequence()
    {
        
        liveCoins.SetActive(false);
        liveDistance.SetActive(false);

        
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(5);

        
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
