using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour
{
    public PickupManager.PickupType type;

    void OnTriggerEnter(Collider other)
    {
        if (!other.tag.Equals("Player"))
            return;
        ProcessPickup();
    }

    void ProcessPickup()
    {
        switch (type)
        {
            case PickupManager.PickupType.GreenRupee:
                {
                    PlayerInfo.instance.currentRupees += 1;
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.BlueRupee:
                {
                    PlayerInfo.instance.currentRupees += 5;
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.RedRupee:
                {
                    PlayerInfo.instance.currentRupees += 20;
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.PurpleRupee:
                {
                    PlayerInfo.instance.currentRupees += 50;
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.Heart:
                {
                    PlayerInfo.instance.IncreaseHealth(1);
                    Destroy(gameObject);
                }
                break;
            // TODO: Possibly add new function to help if max life ever changes
            case PickupManager.PickupType.Fairy:
                {
                    PlayerInfo.instance.IncreaseHealth(5);
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.SmallMagicPot:
                {
                    PlayerInfo.instance.IncreaseMagicPower(2);
                    Destroy(gameObject);
                }
                break;
            case PickupManager.PickupType.LargeMagicPot:
                {
                    PlayerInfo.instance.IncreaseMagicPower(5);
                    Destroy(gameObject);
                }
                break;

        }
    }


}
