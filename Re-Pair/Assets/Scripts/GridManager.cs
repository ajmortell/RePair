using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GridManager : Singleton<GridManager>
{
	private Board board;
	public GameObject theGame;
	
	public GameObject whiteKing;
    public GameObject whiteMortar;
    public GameObject whiteArtillery;
    public GameObject whiteTank;
    public GameObject whiteTankDestroyer;
    public GameObject whiteDrone;

    public GameObject blackKing;
    public GameObject blackMortar;
    public GameObject blackArtillery;
    public GameObject blackTank;
    public GameObject blackTankDestroyer;
    public GameObject blackDrone;
	 
	 
	private Player white;
    private Player black;
    public Player currentPlayer;
    public Player otherPlayer;
	 
	public override void Awake(){
		base.Awake();
		board = GetComponent<Board>();
	}
    // Start is called before the first frame update
    void Start()
    {
		white = new Player("White", true);
		black = new Player("Black", false);
		
		currentPlayer = white;
		otherPlayer = black;
        
    }
	
	public void InitialSetup(){
		
		Instantiate(theGame, new Vector3(0,0,0), Quaternion.identity, gameObject.transform);
		
		AddPiece(whiteKing, white, GridLoc.Instance.D1);
		AddPiece(whiteMortar, white, GridLoc.Instance.E1);
		AddPiece(whiteArtillery, white, GridLoc.Instance.C1);
		AddPiece(whiteArtillery, white, GridLoc.Instance.F1);
		AddPiece(whiteTank, white, GridLoc.Instance.B1);
		AddPiece(whiteTank, white, GridLoc.Instance.G1);
		AddPiece(whiteTankDestroyer, white, GridLoc.Instance.A1);
		AddPiece(whiteTankDestroyer, white, GridLoc.Instance.H1);
		
		AddPiece(whiteDrone, white, GridLoc.Instance.A2);
		AddPiece(whiteDrone, white, GridLoc.Instance.B2);
		AddPiece(whiteDrone, white, GridLoc.Instance.C2);
		AddPiece(whiteDrone, white, GridLoc.Instance.D2);
		AddPiece(whiteDrone, white, GridLoc.Instance.E2);
		AddPiece(whiteDrone, white, GridLoc.Instance.F2);
		AddPiece(whiteDrone, white, GridLoc.Instance.G2);
		AddPiece(whiteDrone, white, GridLoc.Instance.H2);
		
		AddPiece(blackKing, black, GridLoc.Instance.E8);
		AddPiece(blackMortar, black, GridLoc.Instance.D8);
		AddPiece(blackArtillery, black, GridLoc.Instance.C8);
		AddPiece(blackArtillery, black, GridLoc.Instance.F8);
		AddPiece(blackTank, black, GridLoc.Instance.B8);
		AddPiece(blackTank, black, GridLoc.Instance.G8);
		AddPiece(blackTankDestroyer, black, GridLoc.Instance.A8);
		AddPiece(blackTankDestroyer, black, GridLoc.Instance.H8);
		
		AddPiece(blackDrone, black, GridLoc.Instance.A7);
		AddPiece(blackDrone, black, GridLoc.Instance.B7);
		AddPiece(blackDrone, black, GridLoc.Instance.C7);
		AddPiece(blackDrone, black, GridLoc.Instance.D7);
		AddPiece(blackDrone, black, GridLoc.Instance.E7);
		AddPiece(blackDrone, black, GridLoc.Instance.F7);
		AddPiece(blackDrone, black, GridLoc.Instance.G7);
		AddPiece(blackDrone, black, GridLoc.Instance.H7);
		
	}

	public void AddPiece(GameObject prefab, Player player, Vector2 loc)
    {
        GameObject pieceObject = board.AddPiece(prefab, loc);
        player.pieces.Add(pieceObject);
        //pieces[col, row] = pieceObject;
    }

}
