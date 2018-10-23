using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public float life;

    void Update()
    {
        gameObject.transform.Translate(0f, 0f, speed * Time.deltaTime);
        life -= Time.deltaTime;

        if (life <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Player>() != null)
            col.gameObject.GetComponent<Player>().hp -= 1;

    }
}
