using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPlayerPoints : MonoBehaviour
{
    public PlayerController target;
    public TMP_Text pointsText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Trash: " + target.points;

    }
}