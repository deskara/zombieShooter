using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawner : Spawner
{
    public GameObject standardZombie;
    public GameObject speedyZombie;
    public GameObject bulkyZombie;
    public void spawnZombie()
    {
        int randomNumber;
        randomNumber = Random.Range(0, 100);
        if(randomNumber < 5)
        {
            Spawn(bulkyZombie);
        }
        else if(randomNumber < 10)
        {
            Spawn(speedyZombie);
        }
        else
        {
            Spawn(standardZombie);
        }
    }

}
