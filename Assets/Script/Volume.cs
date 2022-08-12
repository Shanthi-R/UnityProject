using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volume : MonoBehaviour
{
    public Button VolumeButton;
    // Start is called before the first frame update
    void Start()
    {
        AddListeners();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnSelectVolumeButton()
    {
        SceneManager.LoadScene(2);
    }
    void AddListeners()
    {

        VolumeButton.onClick.AddListener(OnSelectVolumeButton);
    }
}



    
