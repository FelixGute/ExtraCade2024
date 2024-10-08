using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    protected float speed = 1f;
    public Rigidbody2D RG;
     
    void Start()
    {       
        OnStart();
    }
    
    virtual protected void OnStart()
    {
        RG.velocity = new Vector3(-speed, -Random.Range(1f, 1.5f), 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Damagable>())
        {
            collision.gameObject.GetComponent<Damagable>().TakeDmg(25);
        }

        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
