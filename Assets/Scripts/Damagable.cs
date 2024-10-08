using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    public int health = 100;

    void Start()
    {
        
    }
    public void TakeDmg(int dmg)
    {
        health = health - dmg;
        print(health);
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
