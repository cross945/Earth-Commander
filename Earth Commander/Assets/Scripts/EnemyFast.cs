using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFast : MonoBehaviour {

    private Transform _target;
    public float movementSpeed;


    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    void Update()
    {
        transform.LookAt(_target);
        transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Player>() != null)
            col.gameObject.GetComponent<Player>().hp -= 1;

    }
}
