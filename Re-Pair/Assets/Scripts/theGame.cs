using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGame : Singleton<theGame>
{
	public int whiteScrap;
	public int blackScrap;
	
	
    // Start is called before the first frame update
    void Start()
    {
        whiteScrap = 0;
		blackScrap = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public int getWhiteScrap(){
		return whiteScrap;
	}
	
	public int getBlackScrap(){
		return blackScrap;
	}
	
	public void addWhiteScrap(int scrap){
		whiteScrap = whiteScrap + scrap;
	}
	
	public void addBlackScrap(int scrap){
		blackScrap = blackScrap + scrap;
	}
	
}
