using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToString : MonoBehaviour
{
    public PlayerControlller2D sucesso;
    public Text successText;
    // Update is called once per frame
    void Update()
    {
        if (successText != null) successText.text = sucesso.successChance.ToString();
    }
}
