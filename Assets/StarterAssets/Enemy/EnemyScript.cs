using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Healthbar Healthbar;
    public bullet Bullet;

    void Update()
    {
        if (Healthbar.CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Healthbar.TakeDamage(Bullet.Damage);
        }
    }
}
