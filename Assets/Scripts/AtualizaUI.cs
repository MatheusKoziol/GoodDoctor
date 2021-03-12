using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtualizaUI : MonoBehaviour
{

    public GameObject itemVelho;
    public GameObject itemNovo;

    public void TrocarUI()
    {
        itemVelho.SetActive(false);
        itemNovo.SetActive(true);
    }
}
