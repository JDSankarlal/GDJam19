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
