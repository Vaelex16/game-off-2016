using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;

    public int currentRupees;
    public int maxRupees = 99;
    public string currentScene;

    public int currentMagicPower = 0;
    public int currentHealth = 0;

    private int maxMagicPower = 10;
    private int maxHealth = 5;


    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
            currentHealth = 0;
        Debug.Log(currentHealth);
    }

    public void IncreaseMagicPower (int amount)
    {
        currentMagicPower += amount;
        if (currentMagicPower > maxMagicPower)
            currentMagicPower = maxMagicPower;
        Debug.Log(currentMagicPower);
    }

    public void DecreaseMagicPower(int amount)
    {
        currentMagicPower -= amount;
        if (currentMagicPower < 0)
            currentMagicPower = 0;
        Debug.Log(currentMagicPower);
    }
}
