using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    int level;
    enum Screen {MainMenu, Password, Win}
    Screen currentScreen;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu("Welcome back hAcKeRz.");
    }

    void ShowMainMenu(string greeting) {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Loading up... \nServers online!");
        Terminal.WriteLine("Here are your previous hacking programs.");
        Terminal.WriteLine("Type a number to continue to hack to the desired system.");
        Terminal.WriteLine("1. Billy's Computer");
        Terminal.WriteLine("2. Vending Machine");
        Terminal.WriteLine("3. School's Firewall");
    }

    void OnUserInput(string input) {
        if (input == "menu") {
            ShowMainMenu("Welcome back hAcKeRz."); // we can always go directly to main menu
        } else if (currentScreen == Screen.MainMenu) {
            RunMainMenu(input);
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected to hack system " + level + ".");
        Terminal.WriteLine("Please enter your password: ");
    }

    void RunMainMenu(string input) {
        if (input == "1") {
            level = 1;
            StartGame();
        }
        else if (input == "2") {
            level = 2;
            StartGame();
        }
        else if (input == "3") {
            level = 3;
            StartGame();
        }
        else {
            Terminal.WriteLine("Please select a valid option.");
        }
    }
}

// why is input looping