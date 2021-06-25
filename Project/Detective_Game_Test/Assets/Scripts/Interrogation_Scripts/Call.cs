using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call : MonoBehaviour
{
    public GameObject callScreen;
    public GameObject interviewScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartCall()
    {
        StartCoroutine(callConnect());
    }

    IEnumerator callConnect()
    {
        callScreen.SetActive(true);
        yield return new WaitForSeconds(Random.Range(1.5f, 2.5f));
        callScreen.SetActive(false);
        interviewScreen.SetActive(true);


    }
}
