using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;


public class gameOver : MonoBehaviour
{
    public GameObject pnl;
    public Text txtScoreGame;
    public Text txtScoreGameOver;

    string ScoreGame;
    string scoreGameOver;

    public Text bestScore ;

    int gameover;
    int best;
    
    // Start is called before the first frame update
    void Start()
    {
            string path = "bestScore.txt";
            StreamReader reader = new StreamReader(path);
            bestScore.text = reader.ReadToEnd().ToString();
            reader.Close();
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        pnl.SetActive(true);
        txtScoreGameOver.text= txtScoreGame.text;
        gameover = int.Parse(txtScoreGameOver.text);
        best = int.Parse(bestScore.text);
        print("game over :" );
        print("best : "+best);
        if( 0 < 1 )
        {
            print("ok");
            string path ="bestScore.txt";
            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(txtScoreGameOver.text);
            writer.Close();
            bestScore.text = txtScoreGameOver.text;
        }else
        {
            print("ok2");
            string path = "bestScore.txt";
            StreamReader reader = new StreamReader(path);
            //Print the text from the file
            bestScore.text = reader.ReadToEnd().ToString();
            reader.Close();
        }
    }
    public void loadScenee(){
        pnl.SetActive(false);
        SceneManager.LoadScene("Arkanoid");
    }
}
