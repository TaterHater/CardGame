using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int score;
    public bool isTurn;
     
    public ArrayList deck = new ArrayList();
    public ArrayList hand = new ArrayList();
    public ArrayList discard = new ArrayList();

   
	void Start () {
	//shuffle library and add 30 cards to deck
	}
	
	
	void Update () {
	
	}
    public void setTurn(bool t)
    {
        isTurn = t;
    }
    public int getScore()
    {
        return score;
    }
}

