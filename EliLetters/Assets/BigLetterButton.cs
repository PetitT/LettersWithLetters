using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigLetterButton : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    private List<Color> colors = new List<Color>();
    public GameObject bigLetter;

    private void Start()
    {
        colors = GetComponent<SmallLettersButtons>().colors;
    }

    public void ChangeBigLetter(int index)
    {
        bigLetter.GetComponent<Image>().sprite = sprites[index]; 
    }

    public void ChangeBigLetterColor(int index)
    {
        bigLetter.GetComponent<Image>().color = colors[index];
    }
}
