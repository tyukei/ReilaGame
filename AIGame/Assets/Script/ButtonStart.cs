//https://dianxnao.com/%E3%83%9C%E3%82%BF%E3%83%B3%E3%82%AF%E3%83%AA%E3%83%83%E3%82%AF%E3%81%A7%E3%82%B7%E3%83%BC%E3%83%B3%E9%96%93%E3%82%92%E9%81%B7%E7%A7%BB%EF%BC%88%E7%A7%BB%E5%8B%95%EF%BC%89%E3%81%99%E3%82%8B/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
public void OnClickStartButton()
{
    SceneManager.LoadScene("FetchTrainingScene");
}
}
