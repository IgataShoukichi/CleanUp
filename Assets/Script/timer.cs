using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timelimit;
    float timeEqual;
    [SerializeField] GameObject text;
    [SerializeField] GameObject[] timerObject;

    private void Start()
    {
        timeEqual = timelimit;
        text.SetActive(false);
        for (int i = 0; i < timerObject.Length; i++)
        {
            timerObject[i].SetActive(true);
        }
    }
    void Update()
    {
        if (timelimit > 0)
        {
            timelimit -= Time.deltaTime;
            gameObject.GetComponent<Image>().fillAmount = timelimit / timeEqual;
            if (timelimit <= 0)
            {
                for (int i = 0; i < timerObject.Length; i++)
                {
                    timerObject[i].SetActive(false);
                }
                text.SetActive(true);
            }
        }
    }
}
