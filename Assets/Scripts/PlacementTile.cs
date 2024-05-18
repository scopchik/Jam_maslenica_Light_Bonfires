using System.Collections.Generic;
using UnityEngine;

public enum PlacementTileState
{
	Filled,
	Empty,
	Infected
}

public class PlacementTile : MonoBehaviour
{
	public Material emptyMaterial;
	public Material filledMaterial;
	public Material infectedMaterial;
	public Renderer tileRenderer;

	[HideInInspector]
	public Vector2Int TileIndex;
	private void Start()
	{
		tileRenderer = GetComponent<MeshRenderer>();
	}
	public void SetState(PlacementTileState newState)
	{
		if(tileRenderer != null)
		{
			switch (newState)
			{
				case PlacementTileState.Filled:
					if (filledMaterial != null)
						tileRenderer.sharedMaterial = filledMaterial;

					break;

				case PlacementTileState.Empty:
					if (emptyMaterial != null)
						tileRenderer.sharedMaterial = emptyMaterial;

					break;

				case PlacementTileState.Infected:
					if (infectedMaterial != null)
						tileRenderer.sharedMaterial = infectedMaterial;
					break;
			}
		}
		
	}

	public Node TakeNode()
	{
		return GetComponent<Node>();
	}
}