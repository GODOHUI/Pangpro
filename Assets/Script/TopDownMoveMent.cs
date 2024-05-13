using System;
using UnityEngine;

public class TopDownMoveMent : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D moverigidbody;
    private Vector2 movementdirection= Vector2.zero;
    private Animation animation;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        moverigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animation>();
        


    }



    private void Start()
    {
        controller.OnMoveEvent += Move;
        
      

    }


    private void Move(Vector2 direction)
    {
        movementdirection = direction;
        //Debug.Log("왜 안움직임..."+movementdirection.x);
        if (movementdirection != Vector2.zero )
        {
            animation.Walk(true);
        }
        else
        {
            animation.Walk(false);
        }
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementdirection);
    }

    private void ApplyMovement(Vector2 direction) 
    {
        direction = direction * 5;
        moverigidbody.velocity = direction;
    }
}
