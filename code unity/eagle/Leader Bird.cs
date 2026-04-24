using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBird : Bird
{
    private Vector3 direction;

    private void Start()
    {
        direction = Vector3.forward; 
    }

    public override void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void Update()
    {
        Move();
    }
}


