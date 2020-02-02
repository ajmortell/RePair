using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridLoc : Singleton<GridLoc> {
	
	public Tilemap tilemap;
	public List<Vector2> tileWorldLocations;
		public Vector2 A1;
		public Vector2 A2;
		public Vector2 A3;
		public Vector2 A4;
		public Vector2 A5;
		public Vector2 A6;
		public Vector2 A7;
		public Vector2 A8;
    
		public Vector2 B1;
		public Vector2 B2;
		public Vector2 B3;
		public Vector2 B4;
		public Vector2 B5;
		public Vector2 B6;
		public Vector2 B7;
		public Vector2 B8;
	
		public Vector2 C1;
		public Vector2 C2;
		public Vector2 C3;
		public Vector2 C4;
		public Vector2 C5;
		public Vector2 C6;
		public Vector2 C7;
		public Vector2 C8;
	
		public Vector2 D1;
		public Vector2 D2;
		public Vector2 D3;
		public Vector2 D4;
		public Vector2 D5;
		public Vector2 D6;
		public Vector2 D7;
		public Vector2 D8;
	
		public Vector2 E1;
		public Vector2 E2;
		public Vector2 E3;
		public Vector2 E4;
		public Vector2 E5;
		public Vector2 E6;
		public Vector2 E7;
		public Vector2 E8;
	
		public Vector2 F1;
		public Vector2 F2;
		public Vector2 F3;
		public Vector2 F4;
		public Vector2 F5;
		public Vector2 F6;
		public Vector2 F7;
		public Vector2 F8;
	
		public Vector2 G1;
		public Vector2 G2;
		public Vector2 G3;
		public Vector2 G4;
		public Vector2 G5;
		public Vector2 G6;
		public Vector2 G7;
		public Vector2 G8;
	
		public Vector2 H1;
		public Vector2 H2;
		public Vector2 H3;
		public Vector2 H4;
		public Vector2 H5;
		public Vector2 H6;
		public Vector2 H7;
		public Vector2 H8;

	// Use this for initialization
	void Start () {
		tileWorldLocations = new List<Vector2>();

		foreach (var pos in tilemap.cellBounds.allPositionsWithin) {   
			Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
			//Vector2 place = (Vector2)tilemap.CellToWorld(localPlace);
			if (tilemap.HasTile(localPlace)) {
				tileWorldLocations.Add(tilemap.CellToWorld(localPlace));
			}
		}
		
		A1 = tileWorldLocations[0];
		A2 = tileWorldLocations[1];
		A3 = tileWorldLocations[2];
		A4 = tileWorldLocations[3];
		A5 = tileWorldLocations[4];
		A6 = tileWorldLocations[5];
		A7 = tileWorldLocations[6];
		A8 = tileWorldLocations[7];
    
		B1 = tileWorldLocations[8];
		B2 = tileWorldLocations[9];
		B3 = tileWorldLocations[10];
		B4 = tileWorldLocations[11];
		B5 = tileWorldLocations[12];
		B6 = tileWorldLocations[13];
		B7 = tileWorldLocations[14];
		B8 = tileWorldLocations[15];
	
		C1 = tileWorldLocations[16];
		C2 = tileWorldLocations[17];
		C3 = tileWorldLocations[18];
		C4 = tileWorldLocations[19];
		C5 = tileWorldLocations[20];
		C6 = tileWorldLocations[21];
		C7 = tileWorldLocations[22];
		C8 = tileWorldLocations[23];
	
		D1 = tileWorldLocations[24];
		D2 = tileWorldLocations[25];
		D3 = tileWorldLocations[26];
		D4 = tileWorldLocations[27];
		D5 = tileWorldLocations[28];
		D6 = tileWorldLocations[29];
		D7 = tileWorldLocations[30];
		D8 = tileWorldLocations[31];
	
		E1 = tileWorldLocations[32];
		E2 = tileWorldLocations[33];
		E3 = tileWorldLocations[34];
		E4 = tileWorldLocations[35];
		E5 = tileWorldLocations[36];
		E6 = tileWorldLocations[37];
		E7 = tileWorldLocations[38];
		E8 = tileWorldLocations[39];
	
		F1 = tileWorldLocations[40];
		F2 = tileWorldLocations[41];
		F3 = tileWorldLocations[42];
		F4 = tileWorldLocations[43];
		F5 = tileWorldLocations[44];
		F6 = tileWorldLocations[45];
		F7 = tileWorldLocations[46];
		F8 = tileWorldLocations[47];
	
		G1 = tileWorldLocations[48];
		G2 = tileWorldLocations[49];
		G3 = tileWorldLocations[50];
		G4 = tileWorldLocations[51];
		G5 = tileWorldLocations[52];
		G6 = tileWorldLocations[53];
		G7 = tileWorldLocations[54];
		G8 = tileWorldLocations[55];
	
		H1 = tileWorldLocations[56];
		H2 = tileWorldLocations[57];
		H3 = tileWorldLocations[58];
		H4 = tileWorldLocations[59];
		H5 = tileWorldLocations[60];
		H6 = tileWorldLocations[61];
		H7 = tileWorldLocations[62];
		H8 = tileWorldLocations[63];
	}
	
	/*
		public Vector2 A1 = new Vector2(-112,112);
		public Vector2 A2 = new Vector2(-112,80);
		public Vector2 A3 = new Vector2(-112,48);
		public Vector2 A4 = new Vector2(-112,16);
		public Vector2 A5 = new Vector2(-112,-16);
		public Vector2 A6 = new Vector2(-112,-48);
		public Vector2 A7 = new Vector2(-112,-80);
		public Vector2 A8 = new Vector2(-112,-112);
    
		public Vector2 B1 = new Vector2(-80,112);
		public Vector2 B2 = new Vector2(-80,80);
		public Vector2 B3 = new Vector2(-80,48);
		public Vector2 B4 = new Vector2(-80,16);
		public Vector2 B5 = new Vector2(-80,-16);
		public Vector2 B6 = new Vector2(-80,-48);
		public Vector2 B7 = new Vector2(-80,-80);
		public Vector2 B8 = new Vector2(-80,-112);
	
		public Vector2 C1 = new Vector2(-48,112);
		public Vector2 C2 = new Vector2(-48,80);
		public Vector2 C3 = new Vector2(-48,48);
		public Vector2 C4 = new Vector2(-48,16);
		public Vector2 C5 = new Vector2(-48,-16);
		public Vector2 C6 = new Vector2(-48,-48);
		public Vector2 C7 = new Vector2(-48,-80);
		public Vector2 C8 = new Vector2(-48,-112);
	
		public Vector2 D1 = new Vector2(-16,112);
		public Vector2 D2 = new Vector2(-16,80);
		public Vector2 D3 = new Vector2(-16,48);
		public Vector2 D4 = new Vector2(-16,16);
		public Vector2 D5 = new Vector2(-16,-16);
		public Vector2 D6 = new Vector2(-16,-48);
		public Vector2 D7 = new Vector2(-16,-80);
		public Vector2 D8 = new Vector2(-16,-112);
	
		public Vector2 E1 = new Vector2(16,112);
		public Vector2 E2 = new Vector2(16,80);
		public Vector2 E3 = new Vector2(16,48);
		public Vector2 E4 = new Vector2(16,16);
		public Vector2 E5 = new Vector2(16,-16);
		public Vector2 E6 = new Vector2(16,-48);
		public Vector2 E7 = new Vector2(16,-80);
		public Vector2 E8 = new Vector2(16,-112);
	
		public Vector2 F1 = new Vector2(48,112);
		public Vector2 F2 = new Vector2(48,80);
		public Vector2 F3 = new Vector2(48,48);
		public Vector2 F4 = new Vector2(48,16);
		public Vector2 F5 = new Vector2(48,-16);
		public Vector2 F6 = new Vector2(48,-48);
		public Vector2 F7 = new Vector2(48,-80);
		public Vector2 F8 = new Vector2(48,-112);
	
		public Vector2 G1 = new Vector2(80,112);
		public Vector2 G2 = new Vector2(80,80);
		public Vector2 G3 = new Vector2(80,48);
		public Vector2 G4 = new Vector2(80,16);
		public Vector2 G5 = new Vector2(80,-16);
		public Vector2 G6 = new Vector2(80,-48);
		public Vector2 G7 = new Vector2(80,-80);
		public Vector2 G8 = new Vector2(80,-112);
	
		public Vector2 H1 = new Vector2(112,112);
		public Vector2 H2 = new Vector2(112,80);
		public Vector2 H3 = new Vector2(112,48);
		public Vector2 H4 = new Vector2(112,16);
		public Vector2 H5 = new Vector2(112,-16);
		public Vector2 H6 = new Vector2(112,-48);
		public Vector2 H7 = new Vector2(112,-80);
		public Vector2 H8 = new Vector2(112,-112);

	*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
