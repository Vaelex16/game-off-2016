using UnityEngine;
using System.Collections;

public class Currency
{ 
    private int rupees;
    
	public int Rupees
    {
        get { return rupees; }
        set { rupees = value; }
    }

    public void IncreaseRupees(int amount)
    {
        rupees += amount;
    }

    public void DecreaseRupees(int amount)
    {
        rupees -= amount;
    }
}
