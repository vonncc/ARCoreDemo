using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerSpawner : MonoBehaviour
{

    public bool spawnBall = true;

    public void ChangeSpawn()
    {
        spawnBall = !spawnBall;
    }

}
