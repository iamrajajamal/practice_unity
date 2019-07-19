using UnityEngine;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{

    public Text changeText;

    private void OnEnable()
    {
        Buttons.buttonPressed_event += ONButtonPressed;
    }

    private void OnDisable()
    {
        Buttons.buttonPressed_event -= ONButtonPressed;
    }

    private void ONButtonPressed(MyButtons myButtons)
    {
        switch (myButtons)
        {
            case MyButtons.Leaderboard:
                changeText.text = "Leaderboard Pressed";
                break;

            case MyButtons.Market:
                changeText.text = "Market Pressed";
                break;

            case MyButtons.Achievement:
                changeText.text = "Achievement Pressed";
                break;

            case MyButtons.Play:
                changeText.text = "Play Pressed";
                break;

            default:
                break;
        }
    }

    public enum MyButtons
    {
        Leaderboard,
        Market,
        Achievement,
        Play
    }
}
