using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardPlay : MonoBehaviour
{

    public provocari alegere;
    public GameObject nooads;
    public Text provocare;
    public GameObject background;


    public Vector2 startTouchPosition;
    public Vector2 curentPosition;
    public Vector2 endTouchPosition;
    public Vector2 Distance;
    public bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    private Color32 cc1;
    private Color32 cc2;
    private Color32 cc3;
    private Color32 cc4;
    private Color32 cc5;

    public Color LerpedColor;

    public int ads;
    public Monte strt;
    public int rando;
    

    void Start()
    {
       rando=Random.Range(5,15);
       cc1 = new Color32(20,232,30,100);
       cc2 = new Color32(0,234,141,100);
       cc3 = new Color32(1,126,213,100);
       cc4 = new Color32(181,61,255,100);
       cc5 = new Color32(141,0,196,100);
       if(ads >0){
           
       }
       else{
           ads = 0;
       }
    }

    // Update is called once per frame
    void Update()
    {    if(ads > 500)
        {
            nooads.SetActive(false);
        }
        else{
            nooads.SetActive(true);
        }
        if(ads == rando){
            strt.PlayAds();
            ads = 0;
            rando=Random.Range(5,15);
        }  
        LerpedColor = Color.Lerp(cc1, cc2, Mathf.PingPong(Time.time, 1));
        background.GetComponent<Image>().color = LerpedColor;
        LerpedColor = Color.Lerp(cc2, cc3, Mathf.PingPong(Time.time, 1));
        background.GetComponent<Image>().color = LerpedColor;
        LerpedColor = Color.Lerp(cc3, cc4, Mathf.PingPong(Time.time, 1));
        background.GetComponent<Image>().color = LerpedColor;
        LerpedColor = Color.Lerp(cc4, cc5, Mathf.PingPong(Time.time, 1));
        background.GetComponent<Image>().color = LerpedColor;
        LerpedColor = Color.Lerp(cc5, cc1, Mathf.PingPong(Time.time, 1));
        background.GetComponent<Image>().color = LerpedColor;
        Swipe();   
    }

    public void Swipe()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
           curentPosition = Input.GetTouch(0).position;
           Distance = curentPosition - startTouchPosition;
            if (!stopTouch)
            {
                
                if (Distance.x < -swipeRange)
                {
                    stopTouch = true;  
                    ads++;                 
                    animatie();
                    
                }
                else if (Distance.x > swipeRange)
                {
                    stopTouch = true;
                    ads++; 
                    animatie();
                    
                }
                else if (Distance.y > swipeRange)
                {
                    stopTouch = true;
                    ads++; 
                    animatie();
                    
                }
                else if (Distance.y < -swipeRange)
                {
                    stopTouch = true;
                    ads++; 
                    animatie();
                    
                }
            }
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
               // outputText.text = "Tap";
            }

        }
    }

    public void animatie(){
        provocare.text = alegere.alegeProvocarea();
    }

    public void noAds(){
        ads = 1000;
    }
    
 
}
