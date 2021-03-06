﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    // Sound that will be played when player jumps
    public AudioClip jumpSound = new AudioClip();
    // Adjust this speed for movement speed
    public float speed = 200F;
    // Adjust this speed for jump height
    public float jumpSpeed = 50F;
    // We can switch this off if we want the player to not move
    public bool canMove = true;

    // Velocity vector
    private Vector2 mov;
    // Boolean to tell whether or not the jump key was pressed
    private bool isJumping = false;
    // Private reference to the animator component
    private Animator animator;

    public bool IsGrounded()
    {
        // Get IsGrounded bool from the Grounded script
        return GetComponent<Grounded>().IsGrounded;
    }

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        // Switch this boolean if the player pressed jump in one of the faster updates
        if (Input.GetKeyDown("space"))
        {
            isJumping = true;
        }


        // Set Direction
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            animator.SetBool("IsRight", false);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            animator.SetBool("IsRight", true);

        if(GetComponentInChildren<ShieldControls>() != null)
            GetComponentInChildren<ShieldControls>().canMove = canMove;
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float v = 0F;

            if (isJumping && IsGrounded())
            {
                v = jumpSpeed;
                //AudioSource.PlayClipAtPoint(jumpSound, transform.position);
            }
            else
                v = rigidbody2D.velocity.y;

            mov = new Vector2(h, v);

            rigidbody2D.velocity = mov;

            if (GetComponentInChildren<BatteryManager>() != null)
                GetComponentInChildren<BatteryManager>().isUsingShield = Input.GetMouseButton(0);
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }

        // Reset jumping
        isJumping = false;

        // Set Animation
        animator.SetBool("IsWalking", Mathf.Abs(rigidbody2D.velocity.x) > 0);
    }
}