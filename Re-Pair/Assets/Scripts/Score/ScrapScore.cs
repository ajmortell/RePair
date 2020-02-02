using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrapScore : MonoBehaviour
{
	public int scrapValue;
	public bool white;
	private theGame TheGame;
	Text textstuff;
	
    // Start is called before the first frame update
    void Start()
    {
       textstuff = GetComponent<Text>();
	   TheGame = GameObject.FindWithTag("theGame").GetComponent<theGame>();
    }

    // Update is called once per frame
    void Update()
    {
		if (white == true){
			scrapValue = TheGame.getWhiteScrap();
			textstuff.text = "White Scrap " + scrapValue;
		}
		else{
			scrapValue = TheGame.getBlackScrap();
			textstuff.text = "Black Scrap " + scrapValue;
		}
        //textstuff.Text = "White Scrap " + scrapValue;
    }
}
