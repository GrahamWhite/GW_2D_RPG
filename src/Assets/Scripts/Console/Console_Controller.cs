using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console_Controller : MonoBehaviour
{

    public TMP_InputField consoleInput;
    public TMP_Text consoleOutput;
    public Button consoleButton;
  
    
    private string previousText;
    private string command;

    public Player sprite;


    // Start is called before the first frame update
    void Start()
    {
        consoleInput.text = "";
        previousText = consoleInput.text;

        consoleButton.GetComponent<Button>().onClick.AddListener(SubmitCommand);

    }

    void TextChanged()
    {
        command = consoleInput.text;
    }

    void SubmitCommand()
    {
       
        if (consoleInput.text != previousText)
        {
            TextChanged();
        }

        string command = consoleInput.text;

        switch (command)
        {
            case "/start":
                    consoleOutput.text = "Start Command Entered ...";                    
                break;
            
        }
    }


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            if (Cursor.visible == false)
            {
                Cursor.visible = true;

                consoleInput.enabled = true;
            }
            else
            {
                Cursor.visible = false;
                consoleInput.enabled = false;
            }

           
        }

        
    }
}
