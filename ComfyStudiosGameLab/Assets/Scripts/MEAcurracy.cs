using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MEAcurracy : MonoBehaviour
{
    //public int MaxAccuracy = 5;
    public int currentAccuracy;
    public int MinAccuracy = 0;
    public AccuracyBar accuracyBar;
    public Sprite deadVictim;

    public AudioSource slapSound;

    public GameObject dialogue;
    public GameObject slap;
    public GameObject smack;
    public GameObject murder;
    public GameObject victim;
    public GameObject slap2;
    public GameObject pieceClothing;

    public Button drag;
    public Button kick;
    public Button choice1;
    public Button choice2;
    public Button yes;
    public Button no;
    public Button yess;
    public Button throat;
    public Button heart;
    public Button choke;
    public Button slapAgain;
        
    private bool correctDragging = false;
    private bool isSlapClothes = false;
    private bool isFighting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        currentAccuracy = MinAccuracy;
        accuracyBar.SetMinAccuracy(MinAccuracy);
        choice1.GetComponent<Button>();
        choice2.GetComponent<Button>();
        dialogue.SetActive(false);

        AudioSource slapSoundEffect = GetComponent<AudioSource>();
        slapSound = slapSoundEffect;

        //victim = GameObject.FindGameObjectWithTag("NPC");
        //pieceClothing = GameObject.Find("Piece_of_Clothing");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(correctDragging);
        Debug.Log(currentAccuracy);

    }

    void AddAccuracy(int accuracy)
    {
        currentAccuracy += accuracy;
        accuracyBar.SetAccuracy(currentAccuracy);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bush") && currentAccuracy <1)
        {
            AddAccuracy(1);
                
        }
        if (other.CompareTag("something") && currentAccuracy == 1)
        {
            AddAccuracy(1);                    
        }
        if (other.CompareTag("something") && currentAccuracy == 2)
        {
            StartCoroutine(WaitaBit());
            if (isFighting == true)
            {
                AddAccuracy(1);
                isFighting = false;
            }
        }
        if (other.CompareTag("NPC")&& currentAccuracy == 3)
        {
            slapVictim();
            if (correctDragging )
            {
                //Debug.Log("Drag drag");
                other.transform.parent = gameObject.transform;
                //Time.timeScale = 1;
                slap.SetActive(false);
                AddAccuracy(1);
            }

        }

        if (other.CompareTag("Clothing Spot") && currentAccuracy == 4)
        {
            correctDragging = false;
            this.transform.DetachChildren();
            clothes();
            if (isSlapClothes == true)
            {
                AddAccuracy (1);
                isSlapClothes = false;
            }
        }
        
        if (other.CompareTag("Incorrect") && currentAccuracy == 5)
        {
            putDown();            
        }
        if (other.CompareTag("NPC") && currentAccuracy == 5)
        {           
           other.transform.parent = gameObject.transform;                
        }
        if (other.CompareTag("Correct") && currentAccuracy == 5)
        {
            putDownReal();
            if (isFighting == true)
            {
                AddAccuracy(1);
                isFighting = false;
            }
        }
        if (other.CompareTag("Gun") && currentAccuracy == 6)
        {
            Murder();
        }
        
    }

    void StartArgument()
    {
        dialogue.SetActive(true);
        //Time.timeScale = 0;
        choice1.onClick.AddListener(Fight);
        choice2.onClick.AddListener(Nothing);
    }

    public void Fight()
    {
        //Time.timeScale = 1;
        dialogue.SetActive(false);
        isFighting = true;
    }

    public void Nothing()
    {
        //Time.timeScale = 1;
        dialogue.SetActive(false);
    }

    IEnumerator WaitaBit()
    {
        yield return new WaitForSeconds(1f);
        StartArgument();
    }

    void slapVictim()
    {
        slap.SetActive(true);
        //Time.timeScale = 0;
        kick.onClick.AddListener(Kick);
        drag.onClick.AddListener(Drag);
    }

    void Drag()
    {
        //Time.timeScale = 1;
        correctDragging = true;
    }

    void Kick()
    {
        correctDragging = false;
        //Time.timeScale = 1;
        slap.SetActive(false);
    }

    void putDown()
    {
        //Time.timeScale = 0;
        smack.SetActive(true);
        yes.onClick.AddListener(Yes);
        no.onClick.AddListener(No);
    }

    void Yes()
    {
        //Time.timeScale = 1;
        smack.SetActive(false);
        this.transform.DetachChildren();
    }

    void putDownReal()
    {
        //Time.timeScale = 0;
        smack.SetActive(true);
        yess.onClick.AddListener(Yess);
        no.onClick.AddListener(No);
    }

    void No()
    {
        //Time.timeScale = 1;
        smack.SetActive(false);
    }

    void Yess()
    {
        //Time.timeScale = 1;
        smack.SetActive(false);
        isFighting = true;

        this.transform.DetachChildren();
    }

    void Murder()
    {
        //Time.timeScale = 0;
        murder.SetActive(true);
        heart.onClick.AddListener(Heart);
        throat.onClick.AddListener(Throat);
    }

    void Heart()
    {
        //Time.timeScale = 1;
        murder.SetActive(false);
    }
   
    void Throat()
    {
        //Time.timeScale = 1;
        murder.SetActive(false);
        AddAccuracy(1);
        victim.gameObject.GetComponent<SpriteRenderer>().sprite = deadVictim;
    }

    void clothes()
    {
        slap2.SetActive(true);
        slapAgain.onClick.AddListener(slapClothes);
        choke.onClick.AddListener(choking);

    }

    void slapClothes()
    {
        //Time.timeScale = 1;
        slap2.SetActive(false);
        pieceClothing.SetActive(true);
        isSlapClothes = true;
        //AddAccuracy(1);
        slapSound.Play();
        //Add the slap sound here.
    }

    void choking() {
        //Time.timeScale = 1;
        slap2.SetActive(false);
}
}
