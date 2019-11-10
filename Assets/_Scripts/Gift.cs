using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    Rigidbody GiftRb;
    public bool resetTimer = false;
    private bool isHeld = false;
    // Start is called before the first frame update
    void Start()
    {
        GiftRb = gameObject.transform.GetComponent<Rigidbody>();
        gameObject.GetComponent<ParticleSystem>().Stop();


    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent.tag == "Player") // And the parent is a Player
        {
            if (this.gameObject.transform.parent.name == "Player1") //Check which player
                ThrowGift("1"); //No string because Player1 uses "Horizontal" input
            if (this.gameObject.transform.parent.name == "Player2")
                ThrowGift("2");
            if (this.gameObject.transform.parent.name == "Player3")
                ThrowGift("3");
            if (this.gameObject.transform.parent.name == "Player4")
                ThrowGift("4");
        }

         isBeingHeld(isHeld);

    }

    void ThrowGift(string num)
    {
        if (Input.GetButton("Throw" + num))
        {
            GiftRb.isKinematic = false;
            isHeld = false;
            GameObject.Find("Player" + num).GetComponentInChildren<ParticleSystem>().Stop();

            Debug.Log("Gift Throw Pressed");
            GiftRb.AddForce(gameObject.transform.parent.forward * 1000);
            gameObject.transform.parent = null; //Child moves out
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<ParticleSystem>().Play();

        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            gameObject.transform.SetParent(collision.gameObject.transform);
            gameObject.GetComponent<ParticleSystem>().Stop();
            Debug.Log("touched gift");
            isHeld = true;
            resetTimer = true;
            //collision.gameObject.transform.position= new Vector3(collision.gameObject.transform.position.x,collision.gameObject.transform.position.y,collision.gameObject.transform.position.z);
        }
    }

    void isBeingHeld(bool _isHeld)
    {
        if (_isHeld)
        {
            GiftRb.isKinematic = true;
            GiftRb.velocity = Vector3.zero;
            GiftRb.angularVelocity = Vector3.zero;  
            gameObject.transform.localPosition = new Vector3(0,0,3);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        
    }

    void LateUpdate()
    {
      
    }
}

