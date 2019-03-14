using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatSlider : MonoBehaviour {
    //inits
    public float PlayerSpeed = 15;
    public float EnemySpeed = 10;
    float TOTAL = 100;
    float current = 0;
    float currentEnemy = 0;

    float currentSeconds;
    public float secondsToAction=1;

    public Slider slider;
    public Slider slider2;


    // Use this for initialization
    void Start () {
        currentSeconds = 0;
        current = 0;
        slider.maxValue = TOTAL;
        slider2.maxValue = TOTAL;
    }
	
	// Update is called once per frame
	void Update () {
        currentSeconds += Time.deltaTime;
        if (currentSeconds >= secondsToAction)
        {
            current += PlayerSpeed;
            currentEnemy += EnemySpeed;
            if (current >= TOTAL)
            {
                current = 0;
                Debug.Log("Players turn to take action");
            }
            if (currentEnemy >= TOTAL)
            {
                currentEnemy = 0;
                Debug.Log("Enemy's turn to take action");
            }
      
            
            currentSeconds = 0;
        }//end outer loop
        slider.value = current;
        slider2.value = currentEnemy;
       
	}
}
