using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class authentication : MonoBehaviour
{
    public static PlayGamesPlatform platform;

    private void Start()
    {
        if(platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
        
            platform = PlayGamesPlatform.Activate();
        }

        Social.Active.localUser.Authenticate((bool success) => {
            if (success)
            {
                Debug.Log("logged in successfully");
            }
            else
            {
                Debug.Log("not loffed in");
            }
        });

    }

    public static void UnlockAchievement(string id)
    {
        Social.ReportProgress(id, 100, success => { });
    }

    public static void IncrementAchievement(string id, int increment)
    {
        PlayGamesPlatform.Instance.IncrementAchievement(id, increment, success => { });
    }
    public static void ShowAchievementsUI()
    {
        Social.ShowAchievementsUI();
    }

    public static void AddScoreToLeader(string id, long score)
    {
        Social.ReportScore(score, id, success => { });
    }

    public static void ShowLeaderboard()
    {
        Social.ShowLeaderboardUI();
    }

}
