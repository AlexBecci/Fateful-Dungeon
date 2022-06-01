using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOff : MonoBehaviour
{
 public GameObject Panel;

 private void OnTriggerEnter2D(Collider2D other) {

    if(other.CompareTag("Player"))
    {
        Panel.SetActive(false);
    }
 }
}
