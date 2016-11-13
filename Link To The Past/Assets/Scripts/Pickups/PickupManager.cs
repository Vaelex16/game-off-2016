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
        PickupType type = (PickupType)Random.Range(0, possibleSpawnTypes.Length);
        Instantiate(pickupPrefabs[(int)type], spawnLocation.position, spawnLocation.rotation);
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
