using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;






public class GameOverWindow : MonoBehaviour
{
    private Text sc;

    private void Awake(){
        sc=transform.Find("sc").GetComponent<Text>();

        transform.Find("retryBtn").GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene"); };
        
        }
    private void Start(){
        Bird.GetInstance().OnDeath += Bird_OnDeath;
        hide();
        }
    private void Bird_OnDeath(object sender, System.EventArgs e){
        sc.text=Level.Getinstance().GetPipesPassed().ToString();
        Show();
        
        }
    public void Show(){
        gameObject.SetActive(true);

    }

    public void hide(){
        gameObject.SetActive(false);
    } 
   
    
}
