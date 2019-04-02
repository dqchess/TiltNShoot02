﻿
using UnityEngine;

public class TouchShootAngle2 : MonoBehaviour
{
    public float range = 100f;

    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TouchShootAngle2");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }


    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }


}
