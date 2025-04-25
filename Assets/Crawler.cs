using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : Maze
{
    public override void Generate(){
        crawlX();
        crawlX();
        crawlX();
        crawlZ();
        crawlZ();
    }

    void crawlX(){
        bool done = false;
        int x = 0;
        int z = Random.Range(0, depth);

    // for (int i=0; i <=3; i++)
        while(!done){
            map[x,z] = 0;

            if (Random.Range(0, 100) < 50)
                x += Random.Range(0,2);
            else 
                z += Random.Range(-1,2);
            done |= (x < 0 || x >= width | z < 0 || z >= depth);
        }
    }

    void crawlZ(){
        bool done = false;
        int x = Random.Range(0,width);
        int z = 0;

        while(!done){
            map[x,z] = 0;

            if (Random.Range(0, 100) < 50)
                x += Random.Range(-1,2);
            else 
                z += Random.Range(0,2);
            
            done |= (x < 0 || x >= width | z < 0 || z >= depth);
        }
    }
}
