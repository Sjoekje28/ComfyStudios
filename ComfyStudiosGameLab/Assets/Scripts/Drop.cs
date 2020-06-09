using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{

    public GameObject player;


    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }

        if(eventData.pointerDrag.GetComponent<DragDrop>().correct == true)
        {
            player.GetComponent<MEAcurracy>().AddAccuracy(1);
        }
    }
}
