using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite back;
    public Sprite front;
    public Sprite[] imagenes = new Sprite[52];

    public int Value;
    public string Suit;
    public int Rank;

    private SpriteRenderer target;


    private bool FaceUp = false;

    // Start is called before the first frame update
    void Start()
    {


    }
   
    void Awake()
    {
         target = GetComponent<SpriteRenderer>();
        
    }

  
     public void Toggle()
 

    {
        FaceUp = true;
        target.sprite = front;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
