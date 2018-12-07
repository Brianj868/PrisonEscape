using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom,
                        corridor_0, stairs_0, floor, closet_door_0, closet_door_1, corridor_1, stairs_1, in_closet,
                        corridor_2, stairs_2, corridor_3, courtyard};
    private States myState;
    
	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print (myState);
        if (myState == States.cell)                 {cell();}
        else if (myState == States.sheets_0)        {sheets_0();}
        else if (myState == States.lock_0)          {lock_0();}
        else if (myState == States.mirror)          {mirror(); }
        else if (myState == States.cell_mirror)     {cell_mirror();}
        else if (myState == States.sheets_1)        {sheets_1();}
        else if (myState == States.lock_1)          {lock_1();}
        else if (myState == States.corridor_0)      {corridor_0();}
        else if (myState == States.stairs_0)        {stairs_0();}
        else if (myState == States.floor)           {floor();}
        else if (myState == States.closet_door_0)   {closet_door_0();}
        else if (myState == States.closet_door_1)   {closet_door_1();}
        else if (myState == States.corridor_1)      {corridor_1();}
        else if (myState == States.stairs_1)        {stairs_1();}
        else if (myState == States.in_closet)       {in_closet();}
        else if (myState == States.corridor_2)      {corridor_2();}
        else if (myState == States.stairs_2)        {stairs_2();}
        else if (myState == States.corridor_3)      {corridor_3();}
        else if (myState == States.courtyard)       {courtyard();}
    }

    void cell () {
        text.text = "You are in a prison cell, and you want to escape. There are some " +
                    "dirty sheets on the bed, a broken mirror on the wall, and a door that " +
                    "is locked from the outside.\n\n" +
                    "Press S to inspect the Sheets, press M to inspect the Mirror, or press L " +
                    "to inspect the Lock.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.L))   {myState = States.lock_0;}
        else if (Input.GetKeyDown(KeyCode.M))   {myState = States.mirror;}
    }

    void sheets_0()
    {
        text.text = "These sheets are disgusting. You wonder how you slept in these.\n\n " +
                    "Press R to Return.";                    

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.cell;}
    }

    void lock_0()
    {
        text.text = "The lock is controlled by a keypad. If only there was a way you could see which " +
                    "buttons have been pressed.\n\n " +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.cell;}
    }

    void mirror()
    {
        text.text = "You walk up to the old, broken mirror and notice that it is lose.\n\n" +
                    "Press T to Take the mirror or press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.cell;}
        else if (Input.GetKeyDown(KeyCode.T))   {myState = States.cell_mirror;}
    }

    void cell_mirror()
    {
        text.text = "You are still stuck in your cell, the sheets are still dirty, " +
                    "and the door is still locked.\n\n" +
                    "Press S to inspect the Sheets or press L to inspect the Lock.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.sheets_1;}
        else if (Input.GetKeyDown(KeyCode.L))   {myState = States.lock_1;}
    }

    void sheets_1()
    {
        text.text = "Mirrors can't clean sheets silly.\n\n" +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.cell_mirror;}        
    }

    void lock_1()
    {
        text.text = "You walk up to door and stick the mirror out through the bars. You then angle " +
                    "the mirror so you can see the keypad.\n\n" +
                    "Press O to Open the door or press R to Return.";

        if (Input.GetKeyDown(KeyCode.O))        {myState = States.corridor_0;}
        else if (Input.GetKeyDown(KeyCode.R))   {myState = States.cell_mirror;}
    }

    void corridor_0()
    {
        text.text = "After attempting a few combinations, the door unlocks with a satisfying beep. " +
                    "Congratulations! You have escaped your cell, but now find yourself " +
                    "in a corridor.\n\n" +
                    "Press S to ascend the Stairs, Press F to inspect the Floor, or press C to inspect " +
                    "the closet.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.stairs_0;}
        else if (Input.GetKeyDown(KeyCode.F))   {myState = States.floor;}
        else if (Input.GetKeyDown(KeyCode.C))   {myState = States.closet_door_0; }
    }

    void stairs_0()
    {
        text.text = "You head towards the stairs, but hear guards upstairs. Better not go that way.\n\n" +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_0;}
    }

    void closet_door_0()
    {
        text.text = "You see a closet door and try the handel. Damn, its locked.\n\n" +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_0;}
    }

    void floor()
    {
        text.text = "You notice a hairclip on the ground.\n\n" +
                    "Press H to take the Hairclip or press R to Return";

        if (Input.GetKeyDown(KeyCode.H))        {myState = States.corridor_1;}
        else if (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_0;}
    }

    void corridor_1()
    {
        text.text = "Great. Now you have a hairclip, but you are still trapped in the corridor.\n\n" +
                    "Press S to ascend the Stairs or press C to inspect the Closet.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.stairs_1;}
        else if (Input.GetKeyDown(KeyCode.C))   {myState = States.closet_door_1;}
    }

    void stairs_1()
    {
        text.text = "The guards are still there.\n\n" +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_1;}
    }

    void closet_door_1()
    {
        text.text = "You approach the locked closet door. Maybe this hairclip will come in handy.\n\n" +
                    "Press P to Pick the lock or press R to Return.";

        if (Input.GetKeyDown(KeyCode.P))        {myState = States.in_closet;}
        else if (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_1;}
    }

    void in_closet()
    {
        text.text = "You see a bunch of janitorial supplies including a janitor's outfit.\n\n" +
                    "Press D to Dress in the outfit or R to Return.";

        if (Input.GetKeyDown(KeyCode.D))        {myState = States.corridor_3;}
        else if (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_2;}
    }

    void corridor_2()
    {
        text.text = "Well at least the closet is unlocked now.\n\n" +
                    "Press S to ascend the Stairs or press B to go Back to the closet.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.stairs_2;}
        else if (Input.GetKeyDown(KeyCode.B))   {myState = States.in_closet;}
    }

    void stairs_2()
    {
        text.text = "And the guards have not moved.\n\n" +
                    "Press R to Return.";

        if (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_2;}
    }

    void corridor_3()
    {
        text.text = "You are now disguised as a janitor. Time to walk out of this place.\n\n" +
                    "Press S to ascend the Stairs or press U to undress.";

        if (Input.GetKeyDown(KeyCode.S))        {myState = States.courtyard;}
        else if (Input.GetKeyDown(KeyCode.U))   {myState = States.in_closet;}
    }

    void courtyard()
    {
        text.text = "You stroll out of the building and then out of the compound a free man.\n\n" +
                    "Press P to play again.";

        if (Input.GetKeyDown(KeyCode.P))        {myState = States.cell;}
    }
}
