using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WordSlot : MonoBehaviour, IDropHandler
{
    //public MEAcurracy mEAcurracy;
    public GameObject player;
    public Button button;

    
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }     
    }
}





/* public void addAccuracy()
    {
        player.GetComponent<MEAcurracy>().AddAccuracy(1);
    }

if (eventData.pointerDrag.name == "Correct1" && gameObject.name == "Slot1")
       {
           addAccuracy();
       }
       else
       {
           Debug.Log(eventData.pointerDrag);
           player.GetComponent<MEAcurracy>().AddAccuracy(-1);
       }
       if (eventData.pointerDrag.name == "Correct2" && gameObject.name == "Slot2")
       {
           addAccuracy();
       }
       else
       {
           player.GetComponent<MEAcurracy>().AddAccuracy(-1);
       }
       if (eventData.pointerDrag.name == "Correct3" && gameObject.name == "Slot3")
       {
           addAccuracy();
           else
       {
               player.GetComponent<MEAcurracy>().AddAccuracy(-1);
           }
       }
       //if (this.name == "Slot4" && eventData.pointerDrag.name == "Correct4")
       //{
       //   addAccuracy();
       //}


       Button check = button.GetComponent<Button>();
       check.onClick.AddListener(checkAccuracy);
       void checkAccuracy()
       {

           Debug.Log("button is clicked");
           player.GetComponent<MEAcurracy>().firstPuzzle.SetActive(false);           

       }*/
