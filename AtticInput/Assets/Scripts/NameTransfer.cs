using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class NameTransfer : MonoBehaviour {
  
  public string theName;
  public GameObject inputField;
  public GameObject textDisplay;
  public TextMeshProUGUI welcomeText;
  

  public void StoreName()
  {
    theName = inputField.GetComponent<TextMeshProUGUI>().text;
    textDisplay.GetComponent<TextMeshProUGUI>().text = "Welcome " + theName + " to the game"; 
  } 
 
 
      
  
}
