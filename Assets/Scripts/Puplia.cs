using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puplia : MonoBehaviour
{
    public Transform Pos1;
    public Transform Pos2;
    public PlayerControlller2D player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Pos1.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Interacao")
        {
            player.successChance += 20;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interacao")
        {
            player.successChance -= 20;
        }
    }
}
