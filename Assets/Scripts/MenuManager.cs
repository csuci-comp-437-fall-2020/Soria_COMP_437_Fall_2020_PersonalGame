using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource startSound;
    public AudioSource menuSound;
    
    public void StartGame()
    {
        StartCoroutine(PlayClickAndStart());
    }

    IEnumerator PlayClickAndStart()
    {
        startSound.Play();
        menuSound.Stop();
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("BeepBlockSkyway");
    }
}
