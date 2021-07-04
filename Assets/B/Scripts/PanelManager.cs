using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    
       [SerializeField] GameObject GOPanel;

public void Start()
    {
            Playgame();
    }

public void Stopgame(){
 
             GOPanel.SetActive(true);
}

public void Playgame() {
             
             GOPanel.SetActive(false);
    }
}
