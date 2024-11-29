using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject infoPanel;
    public GameObject aboutPanel;
    public GameObject markerPanel;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(true);
        infoPanel.SetActive(false);
        aboutPanel.SetActive(false);
        markerPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }  

    public void playButton(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void infoButton(){
        menuPanel.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void homeButton(){
        menuPanel.SetActive(true);
        aboutPanel.SetActive(false);
    }

    public void backButton(){
        aboutPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void aboutButton(){
        menuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void quitButton(){
        Application.Quit();
    }
}
