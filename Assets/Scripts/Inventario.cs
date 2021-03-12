using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{

    public PlayerControlller2D player;

    public bool luvaLvl1 = true;
    public bool luvaLvl2;
    public bool luvaLvl3;

    public bool facaLvl1 = true;
    public bool facaLvl2;
    public bool facaLvl3;

    public bool maskLvl1 = true;
    public bool maskLvl2;
    public bool maskLvl3;


    private void Start()
    {
        player.successChance = 30;
    }

    //Mascaras
    public void AtivaMask2()
    {
        player.successChance += 5;
    }
    public void AtivaMask3()
    {
        player.successChance += 5;
    }
    //Luvas
    public void AtivaLuva2()
    {
        player.successChance += 5;
    }
    public void AtivaLuva3()
    {
        player.successChance += 5;
    }
    //Facas
    public void AtivaFaca2()
    {
        player.successChance += 5;
    }
    public void AtivaFaca3()
    {
        player.successChance += 5;
    }

}
