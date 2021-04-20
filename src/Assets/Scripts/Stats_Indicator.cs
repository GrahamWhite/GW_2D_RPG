using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats_Indicator : MonoBehaviour
{
    Player player;
    Dictionary<string, int> stats;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        stats = new Dictionary<string, int>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
