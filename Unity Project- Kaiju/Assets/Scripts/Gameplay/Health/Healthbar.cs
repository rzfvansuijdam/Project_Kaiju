using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float EnemyHealth;


    private void OnCollisionEnter(Collision collision)
    {
        slider.enabled = true;

    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }
}
