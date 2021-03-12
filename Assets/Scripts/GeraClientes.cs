using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeraClientes : MonoBehaviour
{
    public LojaScript Saldo;
    public PlayerControlller2D player;
    public int pagamento;
    public Text moneyText;
    public int tipoDeCliente;

    public GameObject cliente0;
    public GameObject cliente1;
    public GameObject cliente2;
    public GameObject cliente3;
    public GameObject cliente4;
    public GameObject cliente5;
    

    // Start is called before the first frame update
    void Start()
    {
        tipoDeCliente = 1;
    }

    void Update()
    {
        if (moneyText != null) moneyText.text = pagamento.ToString();

    }

    public void MudaCliente()
    {
        tipoDeCliente = (int)Random.Range(0, 5);
        if (tipoDeCliente == 0)
        {
            pagamento = 600;
            cliente0.SetActive(true);
            cliente1.SetActive(false);
            cliente2.SetActive(false);
            cliente3.SetActive(false);
            cliente4.SetActive(false);
            cliente5.SetActive(false);
        }
        if (tipoDeCliente == 1)
        {
            pagamento = 600;
            cliente0.SetActive(false);
            cliente1.SetActive(true);
            cliente2.SetActive(false);
            cliente3.SetActive(false);
            cliente4.SetActive(false);
            cliente5.SetActive(false);
        }
        if (tipoDeCliente == 2)
        {
            pagamento = 800;
            cliente0.SetActive(false);
            cliente1.SetActive(false);
            cliente2.SetActive(true);
            cliente3.SetActive(false);
            cliente4.SetActive(false);
            cliente5.SetActive(false);
        }
        if (tipoDeCliente == 3)
        {
            pagamento = 1000;
            cliente0.SetActive(false);
            cliente1.SetActive(false);
            cliente2.SetActive(false);
            cliente3.SetActive(true);
            cliente4.SetActive(false);
            cliente5.SetActive(false);
        }
        if (tipoDeCliente == 4)
        {
            pagamento = 1500;
            cliente0.SetActive(false);
            cliente1.SetActive(false);
            cliente2.SetActive(false);
            cliente3.SetActive(false);
            cliente4.SetActive(true);
            cliente5.SetActive(false);
        }
        if (tipoDeCliente == 5)
        {
            pagamento = 3000;
            cliente0.SetActive(false);
            cliente1.SetActive(false);
            cliente2.SetActive(false);
            cliente3.SetActive(false);
            cliente4.SetActive(false);
            cliente5.SetActive(true);
        }
    }
}

