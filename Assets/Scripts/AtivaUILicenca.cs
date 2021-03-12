using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaUILicenca : MonoBehaviour
{

    public LojaScript Saldo;
    public GameObject UILicenca;
    public GameObject UIVitoria;
    public bool canInteract;

    public GameObject[] inativos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && canInteract && Saldo.saldo >= 30000)
        {
            Saldo.saldo -= 30000;
            UIVitoria.SetActive(true);
            Time.timeScale = 0;

            for (int i = 0; i < inativos.Length; i++)
            {
                inativos[i].SetActive(false);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UILicenca.SetActive(true);
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UILicenca.SetActive(false);
        canInteract = false;
    }


}
