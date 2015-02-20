using UnityEngine;

/// <summary>
///   Title screen script
/// </summary>
public class MenuScript : MonoBehaviour {

    private GUISkin skin;

    void Start() {
        // Load a skin for the buttons
        skin = Resources.Load("GUISkin") as GUISkin;
    }

    void OnGUI() {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        GUI.skin = skin;

        // Determine the button's place on screen
        // Center in X, 2/3 of he height in Y

        Rect buttonRect = new Rect ( Screen.width / 2 - (buttonWidth / 2),
                                     (2 * Screen.height / 3) - (buttonHeight / 2),
                                     buttonWidth,
                                     buttonHeight);

        // Draw a button to start the game
        if (GUI.Button(buttonRect, "Start!")) {
            Application.LoadLevel("Stage1");
        }
    }
}