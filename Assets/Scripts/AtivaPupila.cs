using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaPupila : MonoBehaviour
{
    public Transform pupila;
    public Transform pos2;

    public bool canInteract;
    public GameObject pupilaUI;

    //preco
    public LojaScript Saldo;
    public int custo;

    void Update()
    {
        if(Input.GetKeyDown("e") && canInteract)
        {
            if (Saldo.saldo >= custo)
            {
                pupila.transform.position = pos2.transform.position;
                canInteract = false;
                Saldo.saldo -= custo;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canInteract = true;
            pupilaUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canInteract = false;
            pupilaUI.SetActive(false);
        }
    }
}
