using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public LojaScript saldo;
    public Text moneyText;
    // Update is called once per frame
    void Update()
    {
        if(moneyText != null)moneyText.text = saldo.saldo.ToString();
    }
}
