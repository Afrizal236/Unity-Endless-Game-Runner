using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerBird : Bird
{
    public Transform leader; 
    public float followDistance = 2f; 

    private Vector3 targetPosition;

    public override void Move()
    {
        if (leader != null)
        {
            targetPosition = leader.position - leader.forward * followDistance;
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void Update()
    {
        Move();
    }
}
