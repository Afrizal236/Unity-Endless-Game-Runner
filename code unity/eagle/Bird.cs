using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : MonoBehaviour, IBird
{
    protected float speed = 10f; 
    public abstract void Move();
}
