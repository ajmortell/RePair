using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whtTank : MonoBehaviour
{
	public int scrapWorth;
	private GameObject piece;
	private theGame THEGAME;
	
    // Start is called before the first frame update
    void Start()
    {
		piece=this.gameObject;
        scrapWorth = 3;
		THEGAME = GameObject.FindWithTag("theGame").GetComponent<theGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void destroy(){
		THEGAME.addBlackScrap(scrapWorth);
		Destroy(piece,0);
	}
}
