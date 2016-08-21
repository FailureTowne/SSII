using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    private int NextSpawnTime;
    public Transform Enemy;
    public int WaveOneSize;
    public int MinRangeBetweenEnemiesOne;
    public int MaxRangeBetweenEnemiesOne;
    public int EnemiesAlreadySpawned;
    private bool SpawnFlag;
	// Use this for initialization
	void Start () {
        NextSpawnTime = 0;
        EnemiesAlreadySpawned = 0;
        SpawnFlag = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (SpawnFlag)
        {
            //calculate next time for a wave one enemy
            if (EnemiesAlreadySpawned <= WaveOneSize)
            {
                NextSpawnTime += Random.Range(MinRangeBetweenEnemiesOne, MaxRangeBetweenEnemiesOne);
            }
            //dont enter this until an enemy has spawned
            SpawnFlag = false;
        }
        if (NextSpawnTime < Time.realtimeSinceStartup)  //need to include check here for wave sizes. lots of ways to handle this, we should probably talk about it.
        {
            Instantiate(Enemy, this.gameObject.transform.position, Quaternion.Euler(transform.parent.rotation.x, transform.parent.rotation.y,transform.parent.rotation.z));
            SpawnFlag = true;
            
        }
    }
}
