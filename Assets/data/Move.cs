using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var move = Input.GetAxis("Horizontal");
        //transform.position +=new  Vector3(move*speed*Time.deltaTime, 0, 0);
        rb.velocity=new Vector2(move*speed,rb.velocity.y);
    }
}
