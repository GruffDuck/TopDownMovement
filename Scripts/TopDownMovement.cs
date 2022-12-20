using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Joystick joystick;
    public Transform sprite;
    public Animator animator;

    public float speed = 3f;
    private void FixedUpdate()
    {
        if (joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            animator.SetBool("Walking", true);
            sprite.gameObject.SetActive(true);
            sprite.position = new Vector3(joystick.Horizontal + transform.position.x, 0.01f, joystick.Vertical + transform.position.z);
            transform.LookAt(new Vector3(sprite.position.x, 0, sprite.position.z));
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            transform.Translate(Vector3.forward*speed * Time.deltaTime);


        }
        else
        {
            sprite.gameObject.SetActive(false);
            animator.SetBool("Walking", false);
        }

    }
}
