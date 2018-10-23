using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    public bool playerClose;
    public bool isRecharging;

    public GameObject spawnEnemy1;
    public GameObject spawnEnemy2;

    private Transform _target;

   
    public float range;
    public float cooldown;

    // Use this for initialization
    void Start () {

        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, _target.position) < range)
        {
            playerClose = true;
        }
        else
        {
            playerClose = false;
        }

        if (playerClose == true)
        {
            if (isRecharging == false)
            {
                Instantiate(spawnEnemy1, GetSpawnablePosition(), transform.rotation);
                Instantiate(spawnEnemy2, GetSpawnablePosition(), transform.rotation);
                cooldown = Random.Range(3, 15);
                isRecharging = true;
            }
        }

        if (isRecharging == true)
        {
            cooldown -= Time.deltaTime;
        }
        if (cooldown <= 0)
            isRecharging = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public Vector3 GetSpawnablePosition()
    {
        Vector3 position;
        position = Random.insideUnitSphere * 2;
        position.y = Mathf.Abs(position.y);
        return position;
    }
}
