using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject Gift;
    public GameObject p1,p2,p3,p4;

    // Start is called before the first frame update
    void Start()
    {
          GameObject[] players = new GameObject[4] {p1,p2,p3,p4};
          
          Gift.transform.SetParent(players[Random.Range(0,3)].transform);
          Gift.transform.position = Gift.transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
