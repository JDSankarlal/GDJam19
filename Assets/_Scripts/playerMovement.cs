using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    public float acceleration = 2.5f;
    public int MaxSpeed = 25;
    Vector3 rotation = new Vector3();
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
              
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            speed+=Time.deltaTime * acceleration;
            if (speed >=MaxSpeed)
             speed = MaxSpeed;
        }

        if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
        {
            speed = 10;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        cc.Move(move * Time.deltaTime * speed);

        //if (move!=Vector3.zero)
          //  transform.forward = move;
        
    }
}
