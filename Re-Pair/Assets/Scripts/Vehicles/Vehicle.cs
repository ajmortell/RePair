using System.Collections.Generic;
using UnityEngine;

public enum VehicleType {King, Mortar, Artillery, TankDestroyer, Tank, Drone};

public abstract class Vehicle : MonoBehaviour {
    public VehicleType type;
	
	protected Vector2Int[] RookDirections = {new Vector2Int(0,1), new Vector2Int(1, 0),
        new Vector2Int(0, -1), new Vector2Int(-1, 0)};
    protected Vector2Int[] BishopDirections = {new Vector2Int(1,1), new Vector2Int(1, -1),
        new Vector2Int(-1, -1), new Vector2Int(-1, 1)};
	
	// movement
    public abstract List<Vector2Int> MoveLocations(Vector2Int gridPoint);
	
	// projectiles
	public abstract List<Vector2Int> ShootLocations(Vector2Int gridPoint);
}
