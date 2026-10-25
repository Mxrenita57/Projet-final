using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   public void OnboutonDebuter()
   {
       SceneManager.LoadScene(1); // Load Level 1
   }
   public void OnboutonQuitter()
   {
       Application.Quit(); // Quit Application
   }
}