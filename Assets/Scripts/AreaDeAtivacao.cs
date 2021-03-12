using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDeAtivacao : MonoBehaviour
{
    public GameObject ativo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ativo.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ativo.SetActive(false);
        }
    }
}
