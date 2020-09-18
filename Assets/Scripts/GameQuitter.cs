using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameQuitter : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(QuitGame);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
