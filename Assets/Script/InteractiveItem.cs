using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.UI;

namespace VRStandardAssets.Utils
{
	// This script is a simple example of how an interactive item can
	// be used to change things on gameobjects by handling events.
	public class InteractiveItem : MonoBehaviour
	{
		[SerializeField] private Material m_NormalMaterial;                
		[SerializeField] private Material m_OverMaterial;                  
		[SerializeField] private Material m_ClickedMaterial;               
		[SerializeField] private Material m_DoubleClickedMaterial;         
		[SerializeField] private VRInteractiveItem m_InteractiveItem;
		[SerializeField] private Renderer m_Renderer;
		[SerializeField] private Text text;


		private void Awake ()
		{
			m_Renderer.material = m_NormalMaterial;
			text.enabled = false;
		}


		private void OnEnable()
		{
			m_InteractiveItem.OnOver += HandleOver;
			m_InteractiveItem.OnOut += HandleOut;
			m_InteractiveItem.OnClick += HandleClick;
			m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
		}


		private void OnDisable()
		{
			m_InteractiveItem.OnOver -= HandleOver;
			m_InteractiveItem.OnOut -= HandleOut;
			m_InteractiveItem.OnClick -= HandleClick;
			m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
		}


		//Handle the Over event
		private void HandleOver()
		{
			//Debug.Log("Show over state");
			text.enabled = true;
			text.text = "Over";
			m_Renderer.material = m_OverMaterial;
		}


		//Handle the Out event
		private void HandleOut()
		{
			//Debug.Log("Show out state");
			text.enabled = true;
			text.text = "Out";
			m_Renderer.material = m_NormalMaterial;
		}


		//Handle the Click event
		private void HandleClick()
		{
			//Debug.Log("Show click state");
			text.enabled = true;
			text.text = "Click";
			m_Renderer.material = m_ClickedMaterial;
		}


		//Handle the DoubleClick event
		private void HandleDoubleClick()
		{
			//Debug.Log("Show double click");
			text.enabled = true;
			text.text = "Double Click";
			m_Renderer.material = m_DoubleClickedMaterial;
		}
	}
}