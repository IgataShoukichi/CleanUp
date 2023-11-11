using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cardboardBox : MonoBehaviour
{
    int OBcount;
    public float limit;
    [SerializeField] GameObject openBox;
    [SerializeField] GameObject closeBox;
    [SerializeField] GameObject arrow;
    [SerializeField] GameObject ending;
    void Start()
    {
        OBcount = 0;
        openBox.SetActive(true);
        arrow.SetActive(true);
        closeBox.SetActive(false);
        ending.SetActive(false);
        GetComponent<GrabObject1>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Outline>().enabled = false;
        gameObject.tag = "Box";
    }

    void Update()
    {
        if (OBcount == limit)
        {
            openBox.SetActive(false);
            arrow.SetActive(false);
            closeBox.SetActive(true);
            GetComponent<GrabObject1>().enabled = true;
            GetComponent<Outline>().enabled = true;
            gameObject.tag = "OB";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OB") && OBcount < limit)
        {
            other.gameObject.SetActive(false);
            OBcount++;
        }

        if (other.gameObject.CompareTag("room"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if (other.gameObject.CompareTag("Finish") && OBcount == limit)
        {
            this.gameObject.SetActive(false);
            Invoke("end", 1);
        }
    }
    private void end()
    {
        ending.SetActive(true);
    }

}
