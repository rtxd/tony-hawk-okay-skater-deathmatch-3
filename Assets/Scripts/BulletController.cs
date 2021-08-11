using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float delayToDestroy = 10;
    public float speed = 2;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Let's Go!");
        transform.position += transform.forward * Time.deltaTime * speed;

    }
}
