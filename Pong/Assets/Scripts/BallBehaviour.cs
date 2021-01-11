using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float speed = 5.0f;
    bool haChocado = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;
        if (haChocado)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else {
        
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        haChocado = !haChocado;
        Debug.Log("Me choqué");   
    }
}
