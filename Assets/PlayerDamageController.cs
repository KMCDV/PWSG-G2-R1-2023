using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour
{
    public GameEvent OnPlayerDamageEvent;
    public GameEvent OnPlayerDeathEvent;
    public IntValue playerHealth;

    public Material materialtoChangeOnDeath;
    public MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        playerHealth.value = 100;
    }

    private void OnMouseDown()
    {
        Debug.Log("Player Taken Damage");
        playerHealth.value -= 10;
        if(OnPlayerDamageEvent != null)
            OnPlayerDamageEvent.Fire();
        if(playerHealth.value <= 0 && OnPlayerDeathEvent != null)
            OnPlayerDeathEvent.Fire();
        
    }

    public void ChangeMaterialOnDeath()
    {
        meshRenderer.material = materialtoChangeOnDeath;
    }

}
