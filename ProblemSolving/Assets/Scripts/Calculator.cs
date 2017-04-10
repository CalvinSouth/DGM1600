using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField val1, val2, outputVal; // Allows access to inputboxes
    public float output; 
    public InputField[] fields = new InputField[2]; // Holds the above inputboxes
    private int focus; // Controls which index to read from

    // Takes in a descriptive string which is used to control a switch statement
    public void Calculate(string operate)
    {
        switch (operate) {
            case "plus": // Add values
                output = float.Parse(val1.text) + float.Parse(val2.text);
                break;
            case "minus": // Subtract values
                output = float.Parse(val1.text) - float.Parse(val2.text);
                break;
            case "multiply": // Multiply values
                output = float.Parse(val1.text) * float.Parse(val2.text);
                break;
            case "divide": // Divide values
                output = float.Parse(val1.text) / float.Parse(val2.text);
                break;
        }

        outputVal.text = output.ToString(); // Place result in output field
    }

    // Sets the Input Field focus for the numpad
    public void SetFocus(int num)
    {
        focus = num;
    }

    // Adds the number of a pressed button to the focused Input Field
    public void AddNum(string num)
    {
        fields[focus].text = fields[focus].text + num; 
    }
}