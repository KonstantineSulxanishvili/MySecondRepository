using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoovmentScript : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * jumpspeed);
        }
           if(Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector2.right * speed);
        }
          if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed);
        }
         if(Input.GetKey(KeyCode.S))
        {
           transform.Translate(Vector2.down * speed);
        }
    }
}
