using UnityEngine;
using System.Collections;

public class DestructableObject : MonoBehaviour
{
    public ObjectType type;
    public GameObject deathParticle;

    WeaponController controller;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DestroyObject()
    {
        if(type == ObjectType.Grass)
        {
            GameObject obj = Instantiate(deathParticle, transform) as GameObject;
            Destroy(obj, 0.5f);
            Destroy(this.gameObject,0.5f);
            
        }
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag != "PlayerWeapons")
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
