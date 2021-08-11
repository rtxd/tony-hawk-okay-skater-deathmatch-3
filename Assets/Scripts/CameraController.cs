using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skater;
    public Vector3 distanceFromSkater;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(skater.transform.position.x - distanceFromSkater.x, skater.transform.position.y - distanceFromSkater.y, skater.transform.position.z - distanceFromSkater.z);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }
}
