using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public int start = 100;
    public int current;
    bool damage;
    bool isDead;
    public GameObject GameOver;
    public GameObject rayos;
    // Start is called before the first frame update
    void Start()
    {
        current = start;
        GameOver.SetActive(false);
      
    }

    public void takeDamage(int amount)
    {
        damage = true;
        current -= amount;
        if(current <= 0 && !isDead)
        {
            death();
        }
    }

    void death()
    {
        GameOver.SetActive(true);
       
    }

 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Application.LoadLevel(0);
        }

       

    }
}
