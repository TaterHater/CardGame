using UnityEngine;
using System.Collections;

public class Card
{
    //card class only
    private int index;
    private string name;
    private int sprite;

 
    public Card(int i, string n,int  s)
    {
        index = i;
        name = n;
        sprite = s;
      
    }


   


}
public class PlayerCard : Card
{
    private int index;
    private string name;
    private int sprite;

    //player card
    private int hitpoints;
    private int attackpoints;
    private int move;
    private float faceoff;

    public PlayerCard(int i, string n, int s,int hp, int ap, float fo, int mov) : base(i,  n,  s)
    {
        hitpoints = hp;
        attackpoints = ap;
        faceoff = fo;
        move = mov;
    }
    int getHp()
    {
        return hitpoints;
    }
    int getAp()
    {
        return attackpoints;
    }
    string getName()
    {
        return name;
    }
    float getFaceoff()
    {
        return faceoff;
    }
}

    public class cardClasses : MonoBehaviour {
    public Card[] Cards = new Card[3];
   
	
	void Start () {
      //  Cards[0] = new PlayerCard(1, "hi", "2", 1, 2, 2.0f);
        
    }
	
	
	void Update () {
	
	}
}
