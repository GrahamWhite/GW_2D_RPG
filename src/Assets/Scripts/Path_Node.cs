using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Node 
{
    private World_Grid<Path_Node> grid;
    private int x;
    private int y;

    public Path_Node cameFromNode;
    public int gCost;
    public int hCost;
    public int fCost;

    // Start is called before the first frame update
    public Path_Node(World_Grid<Path_Node> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }

  

    public override string ToString()
    {
        return $"{x},{y}";
    }
}
