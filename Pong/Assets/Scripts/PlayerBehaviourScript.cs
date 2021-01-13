using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{

    public KeyCode upKey;
    public KeyCode downKey;
    public float speed = 6.0f;
    int limit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey)) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(downKey))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

    }
}
