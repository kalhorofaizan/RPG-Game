using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public Animator animator;
    public int facingDirection = 1;
    void FixedUpdate( )
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        animator.SetFloat("Horizental", Mathf.Abs(moveHorizontal));
        animator.SetFloat("Vertical", Mathf.Abs(moveVertical));
        if (moveHorizontal > 0 && transform.localScale.x < 0 || moveHorizontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }
        rb.linearVelocity= new Vector2(moveHorizontal, moveVertical) *  speed;
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    
}
