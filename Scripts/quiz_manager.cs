using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class quiz_manager : MonoBehaviour
{
    public TMP_Text ques;
    public GameObject[] opt;
    // public TMP_Text[] opt;
    public QnA question;
    //private AudioSource correct_ans;

    // Start is called before the first frame update
    void Start()
    {
        SetQuestion();
        //correct_ans = GetComponent<AudioSource>();
    }


    void SetQuestion()
    {
        ques.text = question.Question;
        for (int a = 0; a < 4; a++)
        {
            opt[a].GetComponent<options_button>().isCorrect = false;
            opt[a].transform.GetChild(0).GetComponent<TMP_Text>().text = question.Options[a];
        }

        for (int a = 0; a < 4; a++)
        {
            if (question.Answer == a + 1)
            {
                opt[a].GetComponent<options_button>().isCorrect = true;
                //ans_sound();
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void ans_sound()
    //{
    //    correct_ans.Play();
    //}
}