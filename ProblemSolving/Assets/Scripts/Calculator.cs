using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField val1, val2;
    public InputField outputVal;
    public float output;

    public void Calculate(string operate)
    {
        switch (operate) {
            case "plus":
                output = float.Parse(val1.text) + float.Parse(val2.text);
                break;
            case "minus":
                output = float.Parse(val1.text) - float.Parse(val2.text);
                break;
            case "multiply":
                output = float.Parse(val1.text) * float.Parse(val2.text);
                break;
            case "divide":
                output = float.Parse(val1.text) / float.Parse(val2.text);
                break;
        }

        outputVal.text = output.ToString();
    }
}