using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform RefPos;
    public GameObject bullet;

    public int damage;

    public float range;

    public bool IsLoaded = true;

    public int BulletCount;

    // Use this for initialization
    void Start()
    {
        BulletCount = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsLoaded == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot(RefPos);
                BulletCount--;
            }
        }
        if(BulletCount <= 0)
        {
            IsLoaded = false;
        }
        else if (BulletCount >= 1)
        {
            IsLoaded = true;
        }
        Reload();
    }

    private void Shoot(Transform reference)
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range))
        {
            if (hit.collider.GetComponent<Enemy>() != null)
                hit.transform.gameObject.GetComponent<Enemy>().hp -= 1 * damage;

            print(hit.transform.name);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward);
    }

    private void Reload()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            BulletCount = 30;
        }
    }
}