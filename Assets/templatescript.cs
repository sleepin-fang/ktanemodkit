using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using rnd = UnityEngine.Random;

public class templatescript : MonoBehaviour
{
    public new KMAudio audio;
    public KMBombInfo bomb;
	public KMBombModule module;

    private static int moduleIdCounter = 1;
    private int moduleId;
    private bool moduleActivated, inputMode, moduleSolved; // Some helpful booleans

    void Awake()
    {
    	moduleId = moduleIdCounter++;

        /*button.OnInteract += delegate {
            ButtonFunction();
            Button.AddInteractionPunch(0.25f);

        }; */

        //module.OnActivate += SomeFunctionAfterBombActivates; 
    }

    void Start()
    {

    }

    void SomeFunctionAfterBombActivates()
    {
        
    }

    void Update() //Runs every frame.
    {

    }

    void GiveStrikeOrSolve()
    {
        //module.HandlePass();
        //module.HandleStrike();
    }
    /*Twitch plays
    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand(string command)
    {
        command = command.ToLowerInvariant().Trim();
        Match m = Regex.Match(command, @"^()$");
        yield return null;
    }
    */

    /*Force Solve Handler
    IEnumerator TwitchHandleForcedSolve()
    {
        yield return null;
    }
    */
}
