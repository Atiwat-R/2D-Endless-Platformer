using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MenuSceneUIController : MonoBehaviour
{

    // public GameObject ui_canvas;
    // GraphicRaycaster ui_raycaster;

    // PointerEventData click_data;
    // List<RaycastResult> click_results;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     ui_raycaster = ui_canvas.GetComponent<GraphicRaycaster>();
    //     click_data = new PointerEventData(EventSystem.current);
    //     click_results = new List<RaycastResult>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (Mouse.current.leftButton.wasReleasedThisFrame) 
    //     {
    //         GetUIElementClicked();
    //     }
    // }

    // void GetUIElementClicked() {

    //     click_data.position = Mouse.current.position.ReadValue();
    //     click_results.Clear();
 
    //     ui_raycaster.Raycast(click_data, click_results);
 
    //     foreach(RaycastResult result in click_results)
    //     {
    //         GameObject ui_element = result.gameObject;
 
    //         Debug.Log(ui_element.name);
    //     }

    //     Debug.Log("JUUA");
    
    // }


	// public Button yourButton;

	// void Start () {
	// 	Button btn = yourButton.GetComponent<Button>();
	// 	btn.onClick.AddListener(TaskOnClick);
	// }

	public void LoadMainScene(){
		SceneManager.LoadScene("Main");
	}



}

