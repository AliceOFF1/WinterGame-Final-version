using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class DiedMenu : MonoBehaviour
{
   public void PlayGame() 
   {
   	SceneManager.LoadScene(0);
   } 

   public void Menu() 
   {
   	SceneManager.LoadScene(2);
   } 

}
