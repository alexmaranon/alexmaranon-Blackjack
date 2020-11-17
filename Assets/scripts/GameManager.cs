using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] PlayerHand = new GameObject[10];
    public GameObject[] DealerHand = new GameObject[10];

    private int CurrentPlayerCard =0;
    private int CurrentDealerCard =0;

    private int PlayerPoints = 0;
    private int DealerPoints = 0;
    public Text TextJugador;
    public Text TextDealer;
    public Text ganar;
    public Text perder;
    public Text empatar;
    public Text lose;
    int guardar;
    public Button boton;
    public Button pasar;
    int dealerguarda;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHand = GameObject.FindGameObjectsWithTag("Jugador");
        DealerHand = GameObject.FindGameObjectsWithTag("Dealer");

    }

    
    public void Next()
    {
        
            PlayerHand[CurrentPlayerCard].GetComponent<Card>().Toggle();

        GetPoints();
    
        CurrentPlayerCard++;
        
    }
    void GetPoints()
    {

        int rango = PlayerHand[CurrentPlayerCard].GetComponent<Card>().Rank;
        int valor = PlayerHand[CurrentPlayerCard].GetComponent<Card>().Value;
        if (guardar >= 11 && rango == 1)
        {
            valor = 1;
        }

       
        guardar = guardar + valor;
        Debug.Log(guardar);
        if (guardar > 21)
        
        {
            Debug.Log("Has perdido");
            lose.text = "HAS PERDIDO ";

            boton.interactable = false;


        }

        TextJugador.text = "Puntuación: "+guardar;

        
        



            
    }
    public void DealerTurn()
    {
        

        DealerHand[CurrentDealerCard].GetComponent<Card>().Toggle();
        boton.interactable = false;
        int range = DealerHand[CurrentDealerCard].GetComponent<Card>().Rank;
        int valores = DealerHand[CurrentDealerCard].GetComponent<Card>().Value;
        if (dealerguarda >= 11 && range == 1)
        {
            valores = 1;
        }
        dealerguarda = dealerguarda + valores;
        if (dealerguarda >= 17)
        {
            pasar.interactable = false;
        }
        
        TextDealer.text = "Puntuación: " + dealerguarda;
        
            CurrentDealerCard++;
       

    }
    
    
    // Update is called once per frame
    void Update()
    {
        if(dealerguarda >= 17)
        {
            if (dealerguarda < guardar)
            {
                ganar.text = "HAS GANADO";
            }
            else
            {
                if(dealerguarda > guardar)
                {
                    perder.text = "HAS PERDIDO";
                }
                else
                {
                    empatar.text = "HAS EMPATADO";
                }
            }
        }
        
    }
}
