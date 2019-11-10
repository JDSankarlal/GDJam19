using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    Rigidbody GiftRb;
    // Start is called before the first frame update
    void Start()
    {
        GiftRb = gameObject.transform.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
          if (gameObject.transform.parent.tag=="Player") // And the parent is a Player
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

                GiftRb.AddForce(100, 0, 0);
                gameObject.transform.parent = null; //Child moves out

            }
        }
}

