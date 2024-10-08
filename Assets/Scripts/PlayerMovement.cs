using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 400f;
    float PowerUpTime;
    public Rigidbody2D RG;
    void Start()
    {
        
    }

    public void PowerUp()
    {
        PowerUpTime = Time.time + 10;
        speed = 800f;
    }
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        RG.velocity = new Vector3(Horizontal*speed*Time.fixedDeltaTime,Vertical*speed*Time.fixedDeltaTime,0);
        if (Time.time > PowerUpTime) {
            speed = 400f;

        }
    }
}
