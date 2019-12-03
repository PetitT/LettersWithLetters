using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SmallLettersButtons : MonoBehaviour
{
    public GameObject smallLetters;
    private TMP_Text[] tmp;
    public List<Color> colors = new List<Color>();

    private void Start()
    {
       tmp = smallLetters.GetComponentsInChildren<TMP_Text>();
    }

    public void ChangeLetter(string newLetter)
    {
        foreach (var letter in tmp)
        {
            letter.text = newLetter;
        }
    }

    public void ChangeColor(int index)
    {
        foreach (var letter in tmp)
        {
            letter.color = colors[index];
        }
    }
}
