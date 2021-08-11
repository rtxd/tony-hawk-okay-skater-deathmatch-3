using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MachineGunController : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnTransform;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            fire();
        }
    }

    void fire()
    {
        Instantiate(bullet, transform.position, spawnTransform.rotation);
    }
}
