using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compra : MonoBehaviour
{
    public LojaScript Saldo;
    public int custo = 2000;
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
        if(Saldo.saldo >= custo)
        {
            Saldo.saldo -= custo;
            //trocaUI
            velho.SetActive(false);
            novo.SetActive(true);
            //TrocaBotao
            botaoVelho.SetActive(false);
            botaoNovo.SetActive(true);

            //upgrade itens
            if (luva) item.AtivaLuva2();

            if (mask) item.AtivaMask2();

            if (faca) item.AtivaFaca2();
        }
    }
}
