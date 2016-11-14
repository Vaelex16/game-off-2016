using UnityEngine;
using System.Collections;

public class PickupManager : MonoBehaviour
{

    public GameObject[] pickupPrefabs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SpawnPickup(PickupType[] possibleSpawnTypes, Transform spawnLocation)
    {
        Vector3 spawn = new Vector3(spawnLocation.position.x, spawnLocation.position.y + 1, spawnLocation.position.z);
       // spawnLocation.position.y += 1;
        int index = Random.Range(0, possibleSpawnTypes.Length);
        PickupType type = possibleSpawnTypes[index];
        Debug.Log("Dropepd " +  type.ToString());
        Instantiate(pickupPrefabs[(int)type], spawn, spawnLocation.rotation);
    }

    public enum PickupType
    {
        GreenRupee = 0,
        BlueRupee = 1,
        RedRupee = 2,
        PurpleRupee = 3,
        Heart = 4,
        Fairy = 5,
        SmallMagicPot = 6,
        LargeMagicPot = 7
    }
}
