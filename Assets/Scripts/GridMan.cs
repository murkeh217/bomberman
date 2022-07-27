using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMan : MonoBehaviour
{
    public Transform gridPrefab;
    public int row = 15;
    public int col = 10;
    // Start is called before the first frame update
    void Start()
    {
         // class members
 
 
 // some function that builds the grid
 for (int r = 0; r<row; r++)
 {
     for (int c = 0; c<col; c++)
     {
                var spawnedTile = Instantiate(gridPrefab, new Vector3(row, 0, col), Quaternion.identity) as Transform;

                spawnedTile.name = $"Tile {r} {c}";
            }
 }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
