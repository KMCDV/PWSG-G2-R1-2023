using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionController : MonoBehaviour
{
    public Health howMuchHealthToHeal;

    private void Start()
    {
        Debug.Log(howMuchHealthToHeal.health);
    }
}
