using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wilsons : Maze
{
    List<MapLocation> directions = new List<MapLocation>(){
        new MapLocation(1,0),
        new MapLocation(0,1),
        new MapLocation(-1,0),
        new MapLocation(0,-1)
    };

    public override void Generate()
    {
        int x = Random.Range(2, width-1);
        int z = Random.Range(2, depth-1);

        map[x,z] = 2;

        RandomWalk();
    }

    int CountSquareMazeNeighbours(int x, int z)
    {
        int count = 0;
        for(int d = 0; d < directions.Count; d++)
        {
            int nx = x + directions[d].x;
            int nz = z + directions[d].z;

            if (map[nx, nz] == 2)
            {
                count++;
            }
        }

        return count;
    }
    void RandomWalk()
    {
        int cx = Random.Range(2, width-1);
        int cz = Random.Range(2, depth-1);

        int loop = 0;
        bool validPath = false;

        while(cx > 0 && cx < width-1 && cz > 0 && cz < depth-1 && loop < 5000 && !validPath)
        {
            map[cx,cz] = 0;

            int rd = Random.Range(0, directions.Count);
            int nx = cx + directions[rd].x;
            int nz = cz + directions[rd].z;
            
            if(CountSquareNeighbours(nx, nz) < 2)
            {
                cx = nx;
                cz = nz;
            }


            validPath = CountSquareMazeNeighbours(cx, cz) == 1;

            loop++;

        }

        
    }
}
