using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public Rigidbody2D RG;
    float timeDest;
    void Start()
    {
        RG.velocity = new Vector3(0, 1.5f, 0);
        timeDest = Time.time;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Damagable>())
        {
            collision.gameObject.GetComponent<Damagable>().TakeDmg(25);
        }
        Destroy(gameObject);
    }
    void Update()
    {
        if (Time.time > timeDest + 3)
        {
            Destroy(gameObject);

        }
    }
}
