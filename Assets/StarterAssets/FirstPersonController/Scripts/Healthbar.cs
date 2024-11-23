using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider HealthSlider;
    public Slider EaseHelthSlider;
    public float MaxHealth = 100f;
    public float CurrentHealth;
    private float lerpSpeed = 0.02f;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    void Update()
    {
        if (HealthSlider.value != CurrentHealth)
        {
            HealthSlider.value = CurrentHealth;
        }

        if (HealthSlider.value != EaseHelthSlider.value)
        {
            EaseHelthSlider.value = Mathf.Lerp(EaseHelthSlider.value, CurrentHealth, lerpSpeed);
        }
    }

    public void TakeDamage(float Damage)
    {
        CurrentHealth -= Damage;
    }
}