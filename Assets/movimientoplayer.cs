using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speedZ;
    public float speedgiro;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speedZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speedZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, speedgiro, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -speedgiro, 0);
        }
    }
}
