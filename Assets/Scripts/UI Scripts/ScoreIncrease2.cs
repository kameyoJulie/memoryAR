using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrease2 : MonoBehaviour
{
  public Text txt_score;
  public static int scoreP2 = 0;

    // Start is called before the first frame update
    public void Start()
    {

    }

    public void OnClick(){
      txt_score.text = ("Player 2 : " + ++scoreP2);
      Debug.Log("ButtonClicked");
    }

    public void resetScore(){
      txt_score.text = ("Player 2 : 0");
      scoreP2 = 0;
    }
}
