using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenGUI : MonoBehaviour {
    private bool InventoryOn = false;
    private float GridWidth = Screen.width / 12f;
    private float GridHeight = Screen.height / 12f;
    public Vector2 WindowPosition;
    public Vector2 WindowSize;
    private Rect windowRect;


    public Texture InventoryWindow;
    public GameObject Speaker;

    public Inventory inventory;
    public GameObject speakergroup;

    private void Start()
    {
        WindowPosition = new Vector2(GridWidth * 3, GridHeight * 2);
        WindowSize = new Vector2(GridWidth * 6, GridHeight * 6);
        windowRect = new Rect(WindowPosition.x, WindowPosition.y, WindowSize.x, WindowSize.y);
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            InventoryOn = !InventoryOn;
            if (InventoryOn) { Time.timeScale = 0;}
            else { Time.timeScale = 1; }

        }
	}

    private void OnGUI()
    {
        if (InventoryOn)
        {
            windowRect = GUI.Window(0, windowRect, DoMyWindow, "");
            
            
        }
    }

   public void DoMyWindow(int windowID)
    {
        GameObject[] speakers = inventory.speakers;
        for (int i = 0; i < speakers.Length; i++)
        {
            if (GUI.Button(new Rect(5 + GridWidth * i, 20, GridWidth, GridHeight), UnityEditor.AssetPreview.GetAssetPreview(speakers[i])))
            {
                InventoryOn = false;
                Time.timeScale = 1;
                
                speakergroup.GetComponent<ActiveSpeaker>().SetSpeaker(speakers[i]);
            }
        }

        
    }
}
