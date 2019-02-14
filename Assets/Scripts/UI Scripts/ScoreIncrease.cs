using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrease : MonoBehaviour
{
  public Text txt_score;
  public static int scoreP1 = 0;

    // Start is called before the first frame update
    public void Start()
    {

    }

    public void OnClick(){
      txt_score.text = ("Player 1 : " + ++scoreP1);
      Debug.Log("ButtonClicked");
    }

    public void resetScore(){
      txt_score.text = ("Player 1 : 0");
      scoreP1 = 0;
    }

}
