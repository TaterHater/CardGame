using UnityEngine;
using System.Collections;


public class Library : MonoBehaviour {
    private ArrayList cardList;
    public Sprite[] spriteList= new Sprite[3];
	// Use this for initialization
	void Start () {
        //all cards are defined here. 
        //library index, name, sprite index, hp, ap, FO%, movement
      cardList.Add(new PlayerCard(1001,"pitcher",0,4,4,20,4));
      cardList.Add(new PlayerCard(1002,"batter", 1, 3, 6, 30f,3));
      cardList.Add(new PlayerCard(1003, "Quarterback", 2, 3,2, 20f, 2));
      cardList.Add(new PlayerCard(1004, "Lacrosse Middie", 3, 4, 4, 60, 4));
      cardList.Add(new PlayerCard(1005, "Lacrosse Goalie", 4, 10, 3, 10f, 3));
      cardList.Add(new PlayerCard(1006, "Lacrosse Attack", 5, 3, 2, 20f, 2));
    }

    Card getCard(int i)
    {
      return (Card)cardList[i];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}


