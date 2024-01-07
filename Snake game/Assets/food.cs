using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="snake")
        {
            float x = Random.Range(-35f, 35f);
            float y = Random.Range(-34f, 38f);
            transform.position=new Vector3(x,y,0);
        }
    }
    
}
