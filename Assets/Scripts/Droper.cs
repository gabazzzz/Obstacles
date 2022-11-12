using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    Rigidbody body;
    MeshRenderer render;
    [SerializeField] float Timer;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        render.enabled = false;
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > Timer)
        {
            render.enabled = true;
            body.useGravity = true;


        }
    }
}
