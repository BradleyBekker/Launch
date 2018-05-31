using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class part5 : MonoBehaviour
{


    public GameObject P1rocket;
    public GameObject P2rocket;
    [SerializeField] private Image Player1part;
    [SerializeField] private Image Player2part;


    private void Update()
    {
        Imagechecks();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1" && P1rocket.GetComponent<P1rocket>().part5 == false)
        {
            print("p1 got 3");
            P1rocket.GetComponent<P1rocket>().part5 = true;
            DestroyObject(gameObject);
            Player1part.enabled = true;
        }
        if (collision.gameObject.tag == "player2" && P2rocket.GetComponent<P2rocket>().part5 == false)
        {
            print("p2 got 3");
            P2rocket.GetComponent<P2rocket>().part5 = true;
            DestroyObject(gameObject);
            Player2part.enabled = true;
        }

    }
    void Imagechecks()
    {
        if (P1rocket.GetComponent<P1rocket>().part5 == true)
        {
            Player1part.enabled = true;
        }
        if (P1rocket.GetComponent<P1rocket>().part5 == false)
        {
            Player1part.enabled = false;
        }

        if (P2rocket.GetComponent<P2rocket>().part5 == true)
        {
            Player2part.enabled = true;
        }
        if (P2rocket.GetComponent<P2rocket>().part5 == false)
        {
            Player2part.enabled = false;
        }
    }
}

