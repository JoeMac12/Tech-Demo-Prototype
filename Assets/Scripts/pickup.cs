using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pickup : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;

    void Start()
    {
        count = 0;
        SetCountText();
    }

   public void OnTriggerEnter (Collider other) // For pickups
   {
       if (other.gameObject.CompareTag("Pickup"))
       {
           other.gameObject.SetActive(false);
           count = count + 1;
           SetCountText();
       }
   }

   public void SetCountText()
   {
       countText.text =  "Count: " + count.ToString();
   }
}
