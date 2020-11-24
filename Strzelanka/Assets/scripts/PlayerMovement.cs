using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = 0;
        float vAxis = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hAxis = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hAxis = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vAxis = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vAxis = 1;
        }

        transform.Translate(new Vector2(hAxis, vAxis) * speed * Time.deltaTime);
    }
}
