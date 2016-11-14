using UnityEngine;
using System.Collections;

public class DestructableObject : MonoBehaviour
{
    public ObjectType type;
    public GameObject deathParticle;

    public PickupManager pickupManager;
    public int dropChance;

    public float lifespan = 2.0f;
    public float flashInterval = 0.33f;
    public bool flash;

    WeaponController controller;


	// Use this for initialization
	void Start () {
        pickupManager = GameObject.FindGameObjectWithTag("PickupManager").GetComponent<PickupManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        
	}

    public void DestroyObject()
    {
        if(type == ObjectType.Grass)
        {
            //controller.interactables.Remove(gameObject);
            if (Random.Range(0, 100) < dropChance)
            {
                PickupManager.PickupType[] possibleDrops = { PickupManager.PickupType.GreenRupee, PickupManager.PickupType.BlueRupee, PickupManager.PickupType.Heart };
                pickupManager.SpawnPickup(possibleDrops, GetComponentInChildren<Transform>());
            }
            GameObject obj = Instantiate(deathParticle, transform.position, transform.rotation) as GameObject;
            Destroy(obj, 0.5f);
            Destroy(this.gameObject);
            
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag != "Player")
            return;
        controller = Other.gameObject.GetComponent<WeaponController>();
        if(controller.interactables.IndexOf(gameObject) == -1)
            controller.interactables.Add(gameObject);
    }

    void OnTriggerExit(Collider Other)
    {
        controller.interactables.Remove(gameObject);
    }

    [System.Serializable]
    public enum ObjectType
    {
        Grass = 0,
        Pot = 1
    };
}
