using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wilsons : Maze
{
    public override void Generate()
    {
        int x = Random.Range(2, width-1);
        int z = Random.Range(2, depth-1);

        map[x,z] = 0;
    }
}
