using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing_Script : MonoBehaviour
{

    private World_Grid grid;


    // Start is called before the first frame update
    private void Start()
    {
        grid = new World_Grid(4, 4, 10f, new Vector3(20, 0));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
    }

}
