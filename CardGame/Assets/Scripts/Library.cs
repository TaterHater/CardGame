using UnityEngine;
using System.Collections;


public class Library : MonoBehaviour {
    private ArrayList cardList;
	// Use this for initialization
	void Start () {
        cardList.Add(12);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class Card 
{
    private int index;
    private string name;
    private string sprite;
    private int hitpoints;
    private int attackpoints;
   private float faceoff;
    public Card(int i, string n, string s, int hp, int ap, float fo)
    {
        index = i;
        name = n;
        sprite = s;
        hitpoints = hp;
        attackpoints = ap;
        faceoff = fo;
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