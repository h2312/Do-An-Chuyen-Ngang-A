﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dichuyennhanvat : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;
    [SerializeField]
    private float forwardMoveSpeed = 7.5f;
    [SerializeField]
    private float backwardMoveSpeed = 3;
    [SerializeField]
    private float turnSpeed = 150f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);

        //characterController.SimpleMove(movement * Time.deltaTime * forwardMoveSpeed);
        //animator.SetFloat("Speed", movement.magnitude);
        //if (movement.magnitude > 0)
        //{
        //    Quaternion newDirection = Quaternion.LookRotation(movement);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, newDirection, Time.deltaTime * turnSpeed);
        //}

        animator.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
        if (vertical != 0)
        {
            float moveSpeedToUse = (vertical > 0) ? forwardMoveSpeed : backwardMoveSpeed;
            characterController.SimpleMove(transform.forward * moveSpeedToUse * vertical);
        }
    }
}

