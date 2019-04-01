﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon02 : MonoBehaviour
{
    public Button fireButton;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start()
    {
        Debug.Log("Weapon02");

        //add an onclick event to your UI button
        fireButton.onClick.AddListener(() => Shoot());
    }

    // Update is called once per frame
   // void Update()
  //  {
   //     if(Input.GetButtonDown("Fire1"))
   //     {
   //         Shoot();
    //    }

   // }

    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    }

}
