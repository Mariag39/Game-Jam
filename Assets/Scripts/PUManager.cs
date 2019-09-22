using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUManager : MonoBehaviour
{
    public GameObject raio;
    float timer = 0.0f;
    float taim = 0.0f;
    int seconds;
    public GameObject pelota;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void ball()
    {
        Vector3 position = new Vector3(Random.Range(-12f, 12f), 1, Random.Range(-6f, 6f));
        GameObject raioInstance = Instantiate(pelota, position, Quaternion.Euler(90, 0, 0)) as GameObject;
    }


    void rayos()
    {
        Vector3 position = new Vector3(Random.Range(-12f, 12f), 1, Random.Range(-6f, 6f));
        GameObject raioInstance = Instantiate(raio, position, Quaternion.Euler(90,0,0)) as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
        taim += Time.deltaTime;
        int seconds = (int)(timer % 60);
        int secs = (int)(taim % 60);
       
        if (seconds == 15)
        {
            rayos();
            ball();
            timer = 0f;
          
        }
      
    }
}
