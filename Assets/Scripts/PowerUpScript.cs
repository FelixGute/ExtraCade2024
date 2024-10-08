using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public Rigidbody2D RG;
    public GameObject plr;
    void Start()
    {

        RG.velocity = new Vector3(0, -Random.Range(1f, 1.5f), 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        plr.GetComponent<PlayerMovement>().PowerUp();
       
        Destroy(gameObject);
    }
    void Update()
    {

    }
}
