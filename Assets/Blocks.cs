using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blocks : MonoBehaviour
{
    
    public Text txtScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetScore(){
        int score = int.Parse(txtScore.text);
       score++;
       return score;
    }
    
    private void OnCollisionEnter2D(Collision2D coll) {
        // GameObject.FindWithTag("Respawn")

       int score = int.Parse(txtScore.text);
       score++;
       GetScore();
       txtScore.text = score.ToString();
       Destroy(gameObject);     
    }
}
