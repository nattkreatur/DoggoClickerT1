using UnityEngine;
using TMPro;

public class HungerUI : MonoBehaviour
{
[SerializeField] private HungerSystem hungerSystemRef;
[SerializeField] private TMP_Text hungerText; //variabel för tmp-text

    // Update is called once per frame
    void Update()
    {
        hungerText.text = $"Hunger: {hungerSystemRef.Hunger:0}/100";
    }
}
