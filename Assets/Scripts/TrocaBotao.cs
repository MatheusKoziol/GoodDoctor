using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaBotao : MonoBehaviour
{

    public GameObject itemVelho;
    public GameObject itemNovo;

    public void TrocarOBotao()
    {
        itemVelho.SetActive(false);
        itemNovo.SetActive(true);
    }
}
