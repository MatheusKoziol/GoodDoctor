using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compra2 : MonoBehaviour
{
    public LojaScript Saldo;
    public int custo = 5000;
    // troca ui
    public GameObject velho;
    public GameObject novo;
    //troca botao
    public GameObject botaoVelho;
    public GameObject botaoNovo;

    //aumenta level do item
    public bool luva;
    public bool mask;
    public bool faca;
    public Inventario item;

    //reduz o saldo
    public void Comprar()
    {
        if (Saldo.saldo >= custo)
        {
            Saldo.saldo -= custo;
            //trocaUI
            velho.SetActive(false);
           if(novo!= null) novo.SetActive(true);
            //TrocaBotao
            botaoVelho.SetActive(false);
            if(botaoNovo != null)botaoNovo.SetActive(true);

            //upgrade itens
            if (luva) item.AtivaLuva3();

            if (mask) item.AtivaMask3();

            if (faca) item.AtivaFaca3();
        }
    }
}
