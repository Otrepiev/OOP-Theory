using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] public InputField inputField;
    [SerializeField] public Text highScoreText;

    // Update is called once per frame
    private void Start()
    {
        highScoreText.text = GameManager.Instance.bestPlayer + ": " + GameManager.Instance.bestScore;
    }

    public void StartGame()
    {
        GameManager.Instance.namePlayer = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}