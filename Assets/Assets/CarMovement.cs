using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody2D backTyre, frontTyre;
    public float speed, movement;
    public float  gasBreak;
    // Start is called before the first frame update
    void Start()
    {
        gasBreak = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(speed);

        frontTyre.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backTyre.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }
    private void FixedUpdate()
    {
        //Debug.Log(speed);
        
       // car.AddTorque(movement * speed * Time.fixedDeltaTime);
    }
    public void Brake()
    {
       speed = 0f;
        movement = 0f;
    }
    public void Gas()
    {
        speed = gasBreak;
        movement = 1f;
    }
}
