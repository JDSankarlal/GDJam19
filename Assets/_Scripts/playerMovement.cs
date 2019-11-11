using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    public float acceleration = 80f;
    public int MaxSpeed = 35;
    Vector3 rotation = new Vector3();
    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
      
    }

    // Update is called once per frame
    void Update()
    {
      

        if (this.gameObject.name == "Player1")
        {
           movePlayer("");
        }

        if (this.gameObject.name == "Player2")
        {
            movePlayer("2");
        }

        if (this.gameObject.name == "Player3")
        {
           movePlayer("3");
        }

        if (this.gameObject.name == "Player4")
        {
            movePlayer("4");
        }

        //if (move!=Vector3.zero)
        //  transform.forward = move;

    }


    void movePlayer(string num)
    {
        if (Input.GetButton("Horizontal"+num) || Input.GetButton("Vertical"+num))
        {
          speed += Time.deltaTime * acceleration;
            if (speed >= MaxSpeed)
                speed = MaxSpeed;
        }

        if (Input.GetButtonUp("Horizontal"+num) || Input.GetButtonUp("Vertical"+num))
        {
            speed = 10;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"+num), 0, Input.GetAxis("Vertical"+num));
        transform.rotation = Quaternion.LookRotation(move);
        cc.Move(move * Time.deltaTime * speed);
    }

    void LateUpdate()
    {
        if (gameObject.tag=="Player")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,.58f,gameObject.transform.position.z);
        }

        // if (GameObject.Find("Gift").transform.position.y < 0.5800052f)
        // {
        //     GameObject.Find("Gift").transform.position =  new Vector3(GameObject.Find("Gift").transform.position.x, 0.5800052f, 
        //             GameObject.Find("Gift").transform.position.z);
        // }
    }
    
}
