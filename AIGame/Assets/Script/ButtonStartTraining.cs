using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartTraining : MonoBehaviour
{
public void OnClickStartButton()
{
    SceneManager.LoadScene("Training");
}
}