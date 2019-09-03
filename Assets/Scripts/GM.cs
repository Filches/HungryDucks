using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public float gameTime;
    public List<int> scores;
    public int WhiteLives = 3, BrownLives = 3, GreenLives = 3, YellowLives = 3, WhiteScore = 0, BrownScore = 0, GreenScore = 0, YellowScore = 0;
    public float resetDelay = 1f;
    public Text livesTextWhite, livesTextBrown, livesTextGreen, livesTextYellow, scoreTextWhite, scoreTextBrown, scoreTextGreen, scoreTextYellow;
    public GameObject youWonWhite, youWonBrown, youWonGreen, youWonYellow;
    public GameObject deathParticles;
    public static GM instance = null;
    public bool gameOver = false;

    private Text winnerBox;

    private string winner = "Nobody won!";
    private int winnerScore = 0;

    private void Start()
    {
        winnerBox = GameObject.Find("GM/WIN/White").GetComponent<Text>();

        Invoke("Winning", gameTime);
    }

    public void GainPointWhite()
    {
        WhiteScore++;
        scoreTextWhite.text = "White Points:" + WhiteScore;
    }

    public void GainPointBrown()
    {
        BrownScore++;
        scoreTextBrown.text = "Brown Points:" + BrownScore;
    }

    public void GainPointGreen()
    {
        GreenScore++;
        scoreTextGreen.text = "Green Points:" + GreenScore;
    }

    public void GainPointYellow()
    {
        YellowScore++;
        scoreTextYellow.text = "Yellow Points:" + YellowScore;
    }

    public void LoseLifeWhite()
    {
        WhiteLives--;
        livesTextWhite.text = "WHITE LIVES: " + WhiteLives;
    }

    public void LoseLifeBrown()
    {
        BrownLives--;
        livesTextBrown.text = "BROWN LIVES: " + BrownLives;
    }

    public void LoseLifeGreen()
    {
        GreenLives--;
        livesTextGreen.text = "GREEN LIVES: " + GreenLives;
    }

    public void LoseLifeYellow()
    {
        YellowLives--;
        livesTextYellow.text = "YELLOW LIVES: " + YellowLives;
    }

    public void Winning()
    {
        gameOver = true;

        if(WhiteScore > winnerScore)
        {
            winnerScore = WhiteScore;
            winner = "White";
        }

        if (BrownScore > winnerScore)
        {
            winnerScore = BrownScore;
            winner = "Brown";
        }

        if (YellowScore > winnerScore)
        {
            winnerScore = YellowScore;
            winner = "Yellow";
        }

        if (GreenScore > winnerScore)
        {
            winnerScore = GreenScore;
            winner = "Green";
        }

        winnerBox.text = winner + " who scored " + winnerScore + ".";
        Invoke("resetGame", 5);
    }

    void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
