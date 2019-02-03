using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrease2 : MonoBehaviour
{
  public Text txt_score;
  private int score = 0;

    // Start is called before the first frame update
    public void Start()
    {

    }

    public void OnClick(){
      txt_score.text = ("Player 2 : " + ++score);
      Debug.Log("ButtonClicked");
    }
}
