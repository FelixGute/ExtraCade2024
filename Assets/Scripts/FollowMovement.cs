using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : EnemyMove
{
    public GameObject GO;
    //void Start()
    //{
    //    print("test");
    //}
    override protected void OnStart()
    {
        GO = GameObject.FindWithTag("Player");
        base.OnStart();
    }
    void Update()
    {
        float plrx = GO.transform.position.x;

        if (plrx < transform.position.x)
        {
            RG.velocity = new Vector2(-speed, -speed);
        } else
        {
            RG.velocity = new Vector2(speed, -speed);

        }

    }
}
