using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponController : MonoBehaviour {

    public List<GameObject> interactables;
    public GameObject sword;
    public GameObject shield;
    private float swingDelayMax = 0.75f;
    private float swingDelayCurrent;
    private bool canSwing = true;
    

    // Use this for initialization
    void Start () 
    {
        swingDelayCurrent = swingDelayMax;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (canSwing)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                SwingSword();
            }
        }
        else
        {
            swingDelayCurrent -= Time.deltaTime;
            if (swingDelayCurrent < 0)
                canSwing = true;
        }
    }

    void SwingSword()
    {
        canSwing = false;
        swingDelayCurrent = swingDelayMax;
        sword.GetComponent<Animator>().SetBool("Swing", true);
        Invoke("StopSwing", 0.03f);
        if(interactables.Count > 0)
            Invoke("HitInteractables", .015f);
    }

    void HitInteractables()
    {
        foreach (GameObject obj in interactables)
            obj.GetComponent<DestructableObject>().DestroyObject();
        interactables.Clear();
    }

    void StopSwing()
    {
        sword.GetComponent<Animator>().SetBool("Swing", false);
    }
}
