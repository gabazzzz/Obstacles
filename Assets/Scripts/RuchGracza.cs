using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchGracza : MonoBehaviour
{
            float yValue = 0;
            [SerializeField]float Speed = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }

    void PrintInstruction()
    {
        Debug.Log("Witaj w grze");
        Debug.Log("Zaczynamy");
        Debug.Log("Koniec");
    }

    void Move()
    {
         float xValue = Input.GetAxis("Horizontal")*Time.deltaTime* Speed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime* Speed;
        transform.Translate(xValue, yValue, zValue);

    }

}
