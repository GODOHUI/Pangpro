using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        target =GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        target.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        target.position = new Vector3(transform.position.x ,transform.position.y ,-10f);
    }
}
