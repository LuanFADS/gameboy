using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    public float posX;
    public float posY;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // posX = transform.position.x;
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Input.GetAxis("Horizontal");
        float posY = Input.GetAxis("Vertical");
        
        transform.position = transform.position + new Vector3(posX * speed * Time.deltatime, posY * speed * Time.deltatime, 0);
        Debug.log(transform.position);   
    }
}
