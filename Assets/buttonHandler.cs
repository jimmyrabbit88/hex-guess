using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandler : MonoBehaviour
{
    gameLoop gl;
    public void selectThis(int value)
    {
        print(value);
        GameObject.FindObjectOfType<gameLoop>().onSelect(value);
    }

    public void startClick()
    {
        GameObject.FindObjectOfType<gameLoop>().StartGame();
    }

    public void clickLifeline()
    {
        GameObject.FindObjectOfType<gameLoop>().LifeLine();
    }

    public void clickVideoAd()
    {
        GameObject.FindObjectOfType<gameLoop>().watchVideoAd();
    }
    public void clickSettings()
    {
        SceneManager.LoadScene(0);
    }

    public void clickHome()
    {
        Debug.Log("got");
        SceneManager.LoadScene(1);
    }

    public void showLeaderboard()
    {
        authentication.ShowLeaderboard();
    }

    public void showAchievements()
    {
        authentication.ShowAchievementsUI();
    }

    public void clickRemoveAds()
    {
        if (!PlayerPrefs.HasKey("ads"))
        {
            //PlayerPrefs.SetInt("ads", 0);
            Purchaser.instance.BuyRemoveAds();
        }
    }
}
