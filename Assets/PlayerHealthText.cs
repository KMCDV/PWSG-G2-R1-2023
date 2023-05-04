using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthText : MonoBehaviour, IGameEventListener
{
    public GameEvent GameEventToSubscribe;
    private TextMeshProUGUI textMeshProUGUI;

    public IntValue playerHealthValue;

    private void OnEnable()
    {
        GameEventToSubscribe.RegisterListener(this);
    }

    private void OnDisable()
    {
        GameEventToSubscribe.UnregisterListener(this);
    }

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        textMeshProUGUI.text = playerHealthValue.value.ToString();
    }

    public void Notify()
    {
        StartCoroutine(MakeRedForOneSecond());
    }

    private IEnumerator MakeRedForOneSecond()
    {
        textMeshProUGUI.color = Color.red;
        textMeshProUGUI.text = playerHealthValue.value.ToString();
        yield return new WaitForSecondsRealtime(1f);
        textMeshProUGUI.color = Color.white;
    }
}
