using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class PlayerShoot : MonoBehaviour
{
    public GameObject project;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(project, transform.position, Quaternion.identity);
            

        }
    }
}
