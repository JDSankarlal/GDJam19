using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGiftBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount > 0) //If the Player has a child attached to it
        {
            if (gameObject.transform.GetChild(0)) //Get the first child (this should only ever be the Gift?)
            {   
                if (this.gameObject.name == "Player1")
                    ThrowGift(""); //No string because Player1 uses "Horizontal" input
                if (this.gameObject.name == "Player2")
                    ThrowGift("2");
                if (this.gameObject.name == "Player3")
                    ThrowGift("3");
                if (this.gameObject.name == "Player4")
                    ThrowGift("4");
            }
        }
        
    }

    void ThrowGift(string num)
    {
        if (Input.GetButton("Throw"+num))
        {
            Debug.Log("Gift Throw Pressed");
        }
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
