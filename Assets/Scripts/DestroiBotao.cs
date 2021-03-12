using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiBotao : MonoBehaviour
{
    public GameObject ObjDestruido;

    public void Destruir()
    {
        Destroy(ObjDestruido);
    }
}
