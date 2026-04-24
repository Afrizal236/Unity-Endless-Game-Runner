using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleFollow : PlayerMove
{
    private Transform playerTransform; 
    private Vector3 offset; 

    void Start()
    {
        
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;

            offset = new Vector3(2, 0, 0);
        }
        else
        { 
            Debug.LogError("Player not found! Make sure it has the tag 'Player'.");
        }
    }

    protected override void Update()
    {
        
        if (playerTransform != null)
        {
            
            Vector3 targetPosition = playerTransform.position + offset;


            targetPosition.y = transform.position.y;

            
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5);
        }

        
        
    }
}
