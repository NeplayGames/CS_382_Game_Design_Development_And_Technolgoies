using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject buttonsPanel;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        startButton.onClick.AddListener(OnGameStart);
        exitButton.onClick.AddListener(OnGameExit);
    }

    void Destroy(){
        Debug.Log("The button is removed");
        startButton.onClick.RemoveListener(OnGameStart);
        exitButton.onClick.RemoveListener(OnGameExit);
    }

    private void OnGameStart(){
        buttonsPanel.SetActive(false);
        SceneManager.LoadScene("Game");
    }

    private void OnGameExit(){
        Application.Quit();
    }
    void OnValidate(){
        Assert.IsNotNull(startButton, $"{nameof(startButton)} cannot be null in {name}");
        Assert.IsNotNull(exitButton, $"{nameof(exitButton)} cannot be null in {name}");
        Assert.IsNotNull(buttonsPanel, $"{nameof(buttonsPanel)} cannot be null in {name}");
    }
}
