using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionController : MonoBehaviour
{
    public Health howMuchHealthToHeal;

    private void Start()
    {
        Debug.Log(howMuchHealthToHeal.health);
        howMuchHealthToHeal.health = 100;
        Coroutine debugCoroutine = StartCoroutine(DebugCoroutine());
        StartCoroutine(SetHealthToZero());
        StopCoroutine(debugCoroutine);
    }

    private IEnumerator SetHealthToZero()
    {
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSecondsRealtime(4f);
            howMuchHealthToHeal.health = 0;
        }

        while (true)
        {
            continue;
        }
    }

    private IEnumerator DebugCoroutine()
    {
        yield return new WaitUntil(IsHealthZero);
        Debug.Log("Po jednej sekundzie");
    }

    private bool IsHealthZero() => howMuchHealthToHeal.health == 0;
}
