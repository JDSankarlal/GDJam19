using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    public float acceleration = 5f;
    public int MaxSpeed = 25;
    Vector3 rotation = new Vector3();
    private CharacterController cc1;
    private CharacterController cc2;
    private CharacterController cc3;
    private CharacterController cc4;
    // Start is called before the first frame update
    void Start()
    {
        cc1 = GameObject.Find("Player1").GetComponent<CharacterController>();
        cc2 = GameObject.Find("Player2").GetComponent<CharacterController>();
        cc3 = GameObject.Find("Player3").GetComponent<CharacterController>();
        cc4 = GameObject.Find("Player4").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag=="Player")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,.58f,gameObject.transform.position.z);
        }

        if (GameObject.Find("Cube").transform.position.y < 0.5800052f)
        {
            GameObject.Find("Cube").transform.position =  new Vector3(0.0f, 0.5800052f, 0.0f);
        }

        if (this.gameObject.name == "Player1")
        {
            if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                speed += Time.deltaTime * acceleration;
                if (speed >= MaxSpeed)
                    speed = MaxSpeed;
            }

            if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
            {
                speed = 10;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            cc1.Move(move * Time.deltaTime * speed);
        }

        if (this.gameObject.name == "Player2")
        {
            if (Input.GetButton("Horizontal2") || Input.GetButton("Vertical2"))
            {
                speed += Time.deltaTime * acceleration;
                if (speed >= MaxSpeed)
                    speed = MaxSpeed;
            }

            if (Input.GetButtonUp("Horizontal2") || Input.GetButtonUp("Vertical2"))
            {
                speed = 10;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
            cc2.Move(move * Time.deltaTime * speed);
        }

        if (this.gameObject.name == "Player3")
        {
            if (Input.GetButton("Horizontal3") || Input.GetButton("Vertical3"))
            {
                speed += Time.deltaTime * acceleration;
                if (speed >= MaxSpeed)
                    speed = MaxSpeed;
            }

            if (Input.GetButtonUp("Horizontal3") || Input.GetButtonUp("Vertical3"))
            {
                speed = 10;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal3"), 0, Input.GetAxis("Vertical3"));
            cc3.Move(move * Time.deltaTime * speed);
        }

        if (this.gameObject.name == "Player4")
        {
            if (Input.GetButton("Horizontal4") || Input.GetButton("Vertical4"))
            {
              speed += Time.deltaTime * acceleration;
                if (speed >= MaxSpeed)
                    speed = MaxSpeed;
            }

            if (Input.GetButtonUp("Horizontal4") || Input.GetButtonUp("Vertical4"))
            {
                speed = 10;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal4"), 0, Input.GetAxis("Vertical4"));
            cc4.Move(move * Time.deltaTime * speed);
        }

        //if (move!=Vector3.zero)
        //  transform.forward = move;

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gift")
        {
            Debug.Log("touched gift");
            collision.gameObject.transform.SetParent(gameObject.transform);
            //collision.gameObject.transform.position= new Vector3(collision.gameObject.transform.position.x,collision.gameObject.transform.position.y,collision.gameObject.transform.position.z);
        }
    }
}
