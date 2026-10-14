using Unity.VisualScripting;
using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    [SerializeField] //gör att hunger visas inspector trots att den är private
    private float hunger = 20f;
    
    public float Hunger{
        //För att HungerUI.cs ska kunna läsa hunger trots att den är private.
        //Andra script kan inte ändra värdet direkt.
        get
        {
            return hunger;
        }
    }

    public void Feed(float amount)
    {
        if (amount <= 0f)
        {
            return; //avslutar metoden om mängden är 0 eller negativ
        }
        hunger = Mathf.Clamp(hunger - amount, 0f, 100f);
        //match clamp hindrar hungern från att gå ner under 0.
    }

    void Update()
    {
        //Egenskaper för hunger och tidsräkning
        hunger += 1f * Time.deltaTime; //hunger ökar med 1 varje sekund
        hunger = Mathf.Clamp(hunger, 0f, 100f); //hunger alltid mellan 0-100
    }
}
