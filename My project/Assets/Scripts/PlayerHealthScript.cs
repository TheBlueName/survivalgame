 using UnityEngine.UI;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class PlayerHealthScript : MonoBehaviour
 {
     public int CurrentHP = 100;
     public int MaxHP = 100;
     public Text ValueText;
 
     void Start()
     {
         CurrentHP = MaxHP;
         UpdateHealthText();
     }
 
     void Update()
     {
         if (CurrentHP <= 0)
         {
             Die();
         }
     }
 
     public void Die()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
 
     public void DealDamage(int EnemyDamage)
     {
         CurrentHP -= EnemyDamage;
         UpdateHealthText();
     }
 
     private void UpdateHealthText()
     {
         ValueText.text = CurrentHP.ToString();
     }
 }