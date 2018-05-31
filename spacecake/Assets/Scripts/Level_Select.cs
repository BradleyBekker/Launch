using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Select : MonoBehaviour {
    [SerializeField]
    Image controlimage;
    [SerializeField]
    Image introimage;
    float timer = 0;

    void Start () {
        GameObject.Find("start_button").GetComponentInChildren<Text>().text = "";
    }
	
  public void Onclick()
    {

        introimage.enabled = true;

        
    }
    private void Update()
    {
        print(timer);
        if (introimage.enabled || controlimage.enabled) {
            timer += 1;
            if(timer >= 225)
            {
                timer = 0;
                introimage.enabled = false;
                controlimage.enabled = true;

            }

        }

        if (timer >= 215 && controlimage.enabled)
        {
            SceneManager.LoadScene("ExpandingSpace");
        }
    }
}
