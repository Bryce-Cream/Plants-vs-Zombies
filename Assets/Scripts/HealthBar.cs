using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] int lives = 5;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife(int amount)
    {
            lives -= amount;
            UpdateDisplay();

        if (lives <= 0)
        {
            //Set display to 0
            lives = 0;
            UpdateDisplay();

            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
