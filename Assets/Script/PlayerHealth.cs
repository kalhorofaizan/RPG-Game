using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public int currentHealth;
   public int maxHealth;
   public void ChangeHealth(int health)
   {
      currentHealth -= health;

      if (currentHealth <= 0)
      {
         gameObject.SetActive(false);
      }
   }
}
