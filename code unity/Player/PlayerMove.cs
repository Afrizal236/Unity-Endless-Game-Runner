using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 9;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool Jumping = false;
    public bool comingDown = false;
    public GameObject playerObject;

   
    protected virtual void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.x > Level.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed, Space.World);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.x < Level.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed, Space.World);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (Jumping == false)
                {
                    Jumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }

        if (Jumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        Jumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }

}
