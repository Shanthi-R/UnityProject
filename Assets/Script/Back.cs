using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public Button button;
    void Start()
    {
        AddListeners();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnSelectBack()
    {
        SceneManager.LoadScene(3);
    }
    void AddListeners()
    {

        button.onClick.AddListener(OnSelectBack);
    }
}
