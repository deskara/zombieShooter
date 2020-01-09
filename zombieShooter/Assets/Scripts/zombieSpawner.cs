using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script inherits from the standard Spawner script
public class zombieSpawner : Spawner
{
    public GameObject standardZombie;
    public GameObject speedyZombie;
    public GameObject bulkyZombie;
    public int bulkyZombieChance;
    public int speedyZombieChance;
    public void spawnZombie()
    {
        int randomNumber;
        //A random integer is generated from 0 to 99
        randomNumber = Random.Range(0, 100);
        if(randomNumber < bulkyZombieChance)
        {
            Spawn(bulkyZombie);
        }
        else if(randomNumber < (speedyZombieChance+bulkyZombieChance))
        {
            Spawn(speedyZombie);
        }
        else
        {
            Spawn(standardZombie);
        }
    }

}
