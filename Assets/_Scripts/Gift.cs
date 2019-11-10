using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    Rigidbody GiftRb;

    public bool resetTimer;
    // Start is called before the first frame update
    void Start()
    {
        GiftRb = gameObject.transform.GetComponent<Rigidbody>();
        resetTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent.tag == "Player") // And the parent is a Player
        {
            if (this.gameObject.transform.parent.name == "Player1") //Check which player
                ThrowGift(""); //No string because Player1 uses "Horizontal" input
            if (this.gameObject.transform.parent.name == "Player2")
                ThrowGift("2");
            if (this.gameObject.transform.parent.name == "Player3")
                ThrowGift("3");
            if (this.gameObject.transform.parent.name == "Player4")
                ThrowGift("4");
        }

    }

    void ThrowGift(string num)
    {
        if (Input.GetButton("Throw" + num))
        {
            Debug.Log("Gift Throw Pressed");

            GiftRb.AddForce(gameObject.transform.forward * 100);
            gameObject.transform.parent = null; //Child moves out

        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            resetTimer = true;
            Debug.Log("touched gift");
            gameObject.transform.SetParent(collision.gameObject.transform);
            //collision.gameObject.transform.position= new Vector3(collision.gameObject.transform.position.x,collision.gameObject.transform.position.y,collision.gameObject.transform.position.z);
        }
    }
}

