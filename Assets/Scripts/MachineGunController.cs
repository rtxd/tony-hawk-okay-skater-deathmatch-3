using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MachineGunController : MonoBehaviour
{
    public GameObject bullet;
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
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
