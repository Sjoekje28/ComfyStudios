using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDropCorrect : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public GameObject player;
    public Button button;
    public GameObject correctSlot;
    //public bool correct;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        Button check = button.GetComponent<Button>();
        check.onClick.AddListener(checkAccuracy);
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void checkAccuracy()
    {
        if (Mathf.Abs(this.transform.localPosition.x - correctSlot.transform.localPosition.x) <= 0.005f &&
            Mathf.Abs(this.transform.localPosition.y - correctSlot.transform.localPosition.y) <= 0.005f)
        {
            player.GetComponent<MEAcurracy>().AddAccuracy(1);
            Debug.Log("I + 1 ed");
        }
        if (Mathf.Abs(this.transform.localPosition.x - correctSlot.transform.localPosition.x) >= 0.005f &&
            Mathf.Abs(this.transform.localPosition.y - correctSlot.transform.localPosition.y) >= 0.005f)
        {
            player.GetComponent<MEAcurracy>().AddAccuracy(-1);
            Debug.Log("I - 1 ed");
        }

        turnOffWordPuzzle();

        var turnOff = player.GetComponent<MEAcurracy>();

        turnOff.tavernPuzzle.SetActive(false);
        turnOff.pathPuzzle.SetActive(false);
        turnOff.bridgePuzzle.SetActive(false);
        turnOff.murderPuzzle.SetActive(false);
        turnOff.carriagePuzzle.SetActive(false);

        
    }

    public void turnOffWordPuzzle()
    {
        Time.timeScale = 1;
        player.GetComponent<SpriteRenderer>().enabled = true;       
    }


}