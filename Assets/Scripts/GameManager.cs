using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sokkies sokkies;
    public ScoreManager sManager;
    public PipeSpawner pSpawner;
    public Vector3 respawnPosition;

    public GameObject gameoverimg;
    public GameObject PlayBTN;
    public GameObject CustomizeBTN;

    public void Awake()
    {
        Application.targetFrameRate = 60;

        introStart();

        //Visuals
        gameoverimg.SetActive(false);
        DefaultBtn.SetActive(false);
        PinkValleyBtn.SetActive(false);
        MoltenMountainsBtn.SetActive(false);

    }

    public void introStart()
    {
        sokkies.gravity = 0.0f;
        pSpawner.enabled = false;
        sManager.HideScore();
        sokkies.enabled = false;
    }

    public void GameOver()
    {
        Pause();
        gameoverimg.SetActive(true);
        PlayBTN.SetActive(true);
        CustomizeBTN.SetActive(true);
        sManager.HideScore();
        ResetSokkies();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        sokkies.enabled = false;
    }

    public void Play()
    {
        
        pSpawner.enabled = true;
        sManager.ShowScore();

        PlayBTN.SetActive(false);
        gameoverimg.SetActive(false);
        CustomizeBTN.SetActive(false);

        Time.timeScale = 1f;
        sokkies.enabled = true;
        sokkies.gravity = -9.8f;
        
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    public void ResetSokkies()
    {
        sokkies.transform.position = respawnPosition;
        sManager.Score = 0;
        sManager.scoretext.text = sManager.Score.ToString();
    }

    //btns
    public GameObject DefaultBtn;
    public GameObject PinkValleyBtn;
    public GameObject MoltenMountainsBtn;

    private bool open = false;

    //ChangeBG
    public void OpenBGPanel()
    {
        if (!open)
        {
            DefaultBtn.SetActive(true);
            PinkValleyBtn.SetActive(true);
            MoltenMountainsBtn.SetActive(true);

            open = true;
            
        }else if (open)
        {
            DefaultBtn.SetActive(false);
            PinkValleyBtn.SetActive(false);
            MoltenMountainsBtn.SetActive(false);

            open = false;
        }
    }

    public void CloseBGPanel()
    {
        if (open)
        {
            DefaultBtn.SetActive(false);
            PinkValleyBtn.SetActive(false);
            MoltenMountainsBtn.SetActive(false);
        }
    }


}
