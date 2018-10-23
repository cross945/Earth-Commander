using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public float hp = 10;
    
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
