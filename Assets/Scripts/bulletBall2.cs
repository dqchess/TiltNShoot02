﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBall2 : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody rb;




    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }
}