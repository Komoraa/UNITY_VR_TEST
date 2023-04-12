using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] pniaki;
    public Transform[] points;
    public float beat=60/105*2;
    private float timer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat){
            GameObject pniak=Instantiate(pniaki[Random.Range(0,2)], points[Random.Range(0,4)]);
            pniak.transform.localPosition=Vector3.zero;
            pniak.transform.Rotate(transform.forward, 90*Random.Range(0,4));
            timer-=beat;
        }

        timer+=Time.deltaTime;
    }
}
