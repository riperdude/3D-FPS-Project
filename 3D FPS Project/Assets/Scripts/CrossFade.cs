using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossFade : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    
    private bool _fadeIn;
    private bool _fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        if(_fadeIn)
        {
            if(canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime;
                if(canvasGroup.alpha >= 1)
                {
                    _fadeOut = false;
                }
            }
        }

        if(_fadeOut)
        {
            if(canvasGroup.alpha >= 0)
            {
                canvasGroup.alpha -= Time.deltaTime;
                if(canvasGroup.alpha == 0)
                {
                    _fadeIn = false;
                    GameObject.Find("Game Manager").GetComponent<Timer>().StartGameTimer();
                }
            }
        }
    }

    public void FadeIn()
    {
        _fadeIn = true;
    }

    public void FadeOut()
    {
        _fadeOut = true;
    }
}
