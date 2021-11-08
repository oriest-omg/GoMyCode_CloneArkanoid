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

    public Text title;

    string ScoreGame;
    string scoreGameOver;

    public Text bestScore ;
    int gameover;
    int best;
    int win;

    
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
        win = int.Parse(txtScoreGame.text);
        if(win == 40)
        {
            pnl.SetActive(true);
            title.text = "win";
            Score();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        pnl.SetActive(true);
        Score();
    }
    public void loadScenee(){
        pnl.SetActive(false);
        SceneManager.LoadScene("Arkanoid");
    }
    public void reset()
    {
            string path ="bestScore.txt";        
            string strFile = File.ReadAllText(path);
            strFile = strFile.Replace(bestScore.text,"0");
            File.WriteAllText(path, strFile);
            bestScore.text = "0";
    }

    private void Score()
    {
        txtScoreGameOver.text= txtScoreGame.text;
        gameover = int.Parse(txtScoreGameOver.text);
        best = int.Parse(bestScore.text);
        if( gameover > best )
        {
            print("ok");
            string path ="bestScore.txt";        
            string strFile = File.ReadAllText(path);
            strFile = strFile.Replace(bestScore.text,txtScoreGameOver.text);
            File.WriteAllText(path, strFile);
            bestScore.text = txtScoreGameOver.text;
        }
        else
        {
            print("ok2");
            string path = "bestScore.txt";
            StreamReader reader = new StreamReader(path);
            //Print the text from the file
            bestScore.text = reader.ReadLine().ToString();
            reader.Close();
        }
    }
}
