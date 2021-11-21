using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    public float health = 100f;
    private SpriteRenderer m_spriteRenderer;
    public GameObject self;
    //this script goes on the enemy along with a box collider
    public void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>(); //basically instantiating the color pallette in the scene
    }
    public void takeDamage(float amount)
    {
        StartCoroutine(DamageEffect()); //loops the color change sequence upon taking damage
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }
    IEnumerator DamageEffect()
    {
        m_spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.05f); //timer changing the color back to white/default

        m_spriteRenderer.color = Color.white;
    }

    void Die()
    {
        self.SetActive(false);
    }
}
