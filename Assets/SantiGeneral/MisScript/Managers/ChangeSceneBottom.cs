using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneBottom : MonoBehaviour
{
    public Button _button;
    public string _sceneName = "MainMenu";

    private void Awake()
    {
        if (_button == null)
        {
            _button = GetComponent<Button>();
        }

        if (_button == null)
        {
            _button = GetComponentInChildren<Button>();
        }

        if (_button != null)
        {
            //_button.onClick.AddListener(    ChangeScene     );
        }

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}