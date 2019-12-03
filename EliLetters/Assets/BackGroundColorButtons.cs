using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundColorButtons : MonoBehaviour
{
    private List<Color> colors = new List<Color>();

    public GameObject background;

    private void Awake()
    {
        colors = GetComponent<SmallLettersButtons>().colors;
    }

    public void ChangeBackgroundColor(int index)
    {
        background.GetComponent<Image>().color = colors[index];
    }
}
