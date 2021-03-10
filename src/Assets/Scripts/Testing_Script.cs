using CodeMonkey.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing_Script : MonoBehaviour
{
    World_Grid<ClickTile> grid;
    //World_Grid<ClickTile> grid;

  
    // Start is called before the first frame update
    void Start()
    {
      
        grid = new World_Grid<ClickTile>(5,5, 50f, Vector3.zero, (World_Grid<ClickTile> g, int x, int y) => new ClickTile(g, x, y));
        //grid = new World_Grid<ClickTile>(width, height, 50f, Vector3.zero, (World_Grid<ClickTile> g, int x, int y) => new ClickTile(grid, width, height));
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {

            Vector3 position = UtilsClass.GetMouseWorldPosition();
            ClickTile tile = grid.GetGridObject(position);
            if (tile != null) {
                tile.AddValue(1);
                Debug.Log(tile.value);
            }

            

            //Debug.Log(grid.GetGridObject(position).value);

        }

        
    }
}

public class ClickTile
{
    public int value = 1;
    public World_Grid<ClickTile> grid;
    public int x;
    public int y;
    
    public ClickTile(World_Grid<ClickTile> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }

    public void AddValue(int value)
    {
        this.value += value;
        grid.TriggerGridObjectChanged(x, y);
    }


    public override string ToString()
    {
        return value.ToString();
    }
}

