using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Dialogue{
    [TextArea(3,10)]//first number is min number of lines the text area will use and second is max
    public string[] sentences;
    public string name;

}
