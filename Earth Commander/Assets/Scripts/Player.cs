using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float MovSpeed = 10f;
    public float rotateSpeed = 300f;

    public int hp = 5;


    private void Start()
    {

    }

    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0f, 0f, MovSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0f, 0f, -MovSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(MovSpeed * Time.deltaTime,0f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-MovSpeed * Time.deltaTime , 0f, 0f);
        }
        
    }
}
