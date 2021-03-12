using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlller2D : MonoBehaviour
{
    //pagamento
    public GeraClientes cliente;
    public LojaScript Saldo;

    public float successChance;
    public int tentativa;
    public GameObject success;
    public GameObject failed;
    
    public float speed;
    public bool canInteract;
    public bool jaInteragiu;
    float h;
    Rigidbody2D rb2d;

    //pupila
    public Puplia pupila;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown("e") && canInteract && !jaInteragiu)
        {
            Debug.Log("Interagiu");
            tentativa = (int)Random.Range(0f, 100f);
            jaInteragiu = true;

            if (tentativa < successChance)
            {
                success.SetActive(true);
                Saldo.saldo += cliente.pagamento;
                cliente.MudaCliente();
                pupila.transform.position = pupila.Pos1.transform.position;
            }
            else
            {
                failed.SetActive(true);
                if(cliente.pagamento > 400)cliente.pagamento -= 200;
            }
        }
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(h * speed, rb2d.velocity.y);
        if (h == 0) rb2d.velocity = new Vector2(0, rb2d.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interacao")
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interacao")
        {
            canInteract = false;
            jaInteragiu = false;
            failed.SetActive(false);
            success.SetActive(false);
        }
    }



}
