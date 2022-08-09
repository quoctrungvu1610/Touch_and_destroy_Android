using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;
    // Button button;
    int score = 0;
    // Start is called before the first frame update

    private void Start()
    {
         //button = GameObject.Find("Button").GetComponent<Button>();
    }
    private void Update()
    {
        //button.onClick.AddListener(() => RestartGame());
    }
    // Update is called once per frame

    public void ScoreUp()
    {
        score++;
         if(score >= 4)
        {
            Win();
        }
    }
    void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void PrintText(){
        print("Button Clicked");
    }
}
