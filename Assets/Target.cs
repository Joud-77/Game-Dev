
using UnityEngine;

public class Target : MonoBehaviour
{
    public float helath = 50f;
    public void TakeDamage(float amount)
    {
        helath -= amount;
        if (helath <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
