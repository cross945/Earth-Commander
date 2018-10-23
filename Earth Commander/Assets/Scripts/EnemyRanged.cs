using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanged : MonoBehaviour {

    private Transform _target;
    public Transform RefPos;

    public float movementSpeed;
    public float cooldown = 4;

    public GameObject bullet;

    public bool isInRange;
    public bool isRecharging;

    public float range;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.LookAt(_target);

        if (Vector3.Distance(transform.position, _target.position) < range)
        {
            isInRange = true;
        }
        else
        {
            isInRange = false;
        }
        
        if(isInRange == false)
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        }

        if(isInRange == true)
        {
            if (isRecharging == false)
                Shoot(RefPos);
        }
        
        if (cooldown <= 0)
        {
            isRecharging = false;
        }
        else
            isRecharging = true;

        if(isRecharging == true)
        {
            cooldown -= Time.deltaTime;
        }

    }

    private void Shoot(Transform reference)
    {
        Instantiate(bullet, reference.position, reference.rotation); ;
        cooldown = 4;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
