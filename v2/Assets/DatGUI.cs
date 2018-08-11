using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DatGUI : MonoBehaviour {
	

	public static Texture2D MakeTex(int width, int height, Color col)
	{
		Color[] pix = new Color[width*height];

		for(int i = 0; i < pix.Length; i++)
			pix[i] = col;

		Texture2D result = new Texture2D(width, height);
		result.SetPixels(pix);
		result.Apply();

		return result;
	}
	public void OnGUI() {
		
		MaGUI ();


	}
	public void Update() {
		Updatex ();



	
	}
	public void Start() {
		Declaration.xStart ();
		Declaration.xxStart ();
	}

	public static void MaGUI() { 
		if (HS.stylelength == 1) {

			HS.boxx = 9.5f * HS.menusize;
		} else if (HS.stylelength == 2) {
			HS.boxx = 19f * HS.menusize;
		}
		GUIStyle menuoc = new GUIStyle ();
		GUIStyle menubc = new GUIStyle (); 
		GUIStyle boxoc = new GUIStyle ();
		GUIStyle boxbc = new GUIStyle ();
		GUIStyle toggoc = new GUIStyle ();
		GUIStyle toggbc = new GUIStyle ();
		GUIStyle selectme = new GUIStyle ();
		GUIStyle configs = new GUIStyle ();
		Vector2 screenMousePosition2 = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
		if (HS.currentDrag2.sqrMagnitude != 0 || MMInfo.MenuRect.Contains (screenMousePosition2)) {
			if (HS.currentDrag1.x <= 0) {
				if (HS.ShowHide) {

					if (Input.GetMouseButtonDown (0)) {
						HS.currentDrag2 = screenMousePosition2;


					} else if (Input.GetMouseButton (0)) {

						MMInfo.MenuRect.x = Mathf.Clamp (MMInfo.MenuRect.x + (screenMousePosition2.x - HS.currentDrag2.x), .25f * HS.menusize, Screen.width - HS.boxx - .25f * HS.menusize);
						MMInfo.MenuRect.y = Mathf.Clamp (MMInfo.MenuRect.y + (screenMousePosition2.y - HS.currentDrag2.y), .25f * HS.menusize, Screen.height - HS.yy - .25f * HS.menusize);

						HS.currentDrag2 = screenMousePosition2;





					} else {
						HS.currentDrag2.x = 0;
						HS.currentDrag2.y = 0;

					}
				}
			}
		}


		MMInfo.OpenRect.height = 1.5f * HS.menusize;
		MMInfo.OpenRect.width = 6.5f * HS.menusize;

		HS.t = 0;
		HS.bx = MMInfo.MenuRect.x + (0.35f* HS.menusize);
		HS.tx = MMInfo.MenuRect.x + (0.5f * HS.menusize);
		menuoc.fontStyle = HS.menufs;
		toggoc.fontStyle = HS.toggfs;
		boxoc.fontStyle = HS.boxfs; 
		menuoc.wordWrap = true;
		menuoc.alignment = TextAnchor.MiddleCenter;

		boxoc.normal.textColor = HS.boxtc;
		boxoc.normal.background = MakeTex(1,1,HS.boxc);
		boxoc.wordWrap = true;
		boxoc.alignment = TextAnchor.UpperCenter;
		boxoc.fontSize = (int)(0.7f*HS.menusize); 
		toggoc.normal.textColor = Color.white;
		selectme.normal.background = MakeTex (1, 1, Color.gray);
		toggoc.wordWrap = true;
		toggoc.alignment = TextAnchor.MiddleCenter;
		toggoc.fontSize = (int)(0.7*HS.menusize); 
		menuoc.fontSize = (int)(0.7*HS.menusize); 
		configs.alignment = TextAnchor.UpperCenter;
		configs.normal.background = MakeTex (1, 1, Color.clear);
		configs.normal.textColor = Color.white;
		configs.wordWrap = true;
		configs.fontSize = 14;
		configs.fontStyle = FontStyle.BoldAndItalic;



		 

		Vector2 screenMousePosition1 = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
		if (HS.currentDrag1.sqrMagnitude != 0 || MMInfo.OpenRect.Contains(screenMousePosition1))
		{
			if (HS.currentDrag2.x <= 0) {
				if (Input.GetMouseButtonDown (0)) {
					HS.currentDrag1 = screenMousePosition1;
					HS.timeheld = 0;

				} else if (Input.GetMouseButton (0)) {
					MMInfo.OpenRect.x = Mathf.Clamp (MMInfo.OpenRect.x + (screenMousePosition1.x - HS.currentDrag1.x), .25f*HS.menusize, Screen.width - (6.75f*HS.menusize));
					MMInfo.OpenRect.y = Mathf.Clamp (MMInfo.OpenRect.y + (screenMousePosition1.y - HS.currentDrag1.y), .25f*HS.menusize, Screen.height - (1.75f*HS.menusize));

					HS.currentDrag1 = screenMousePosition1;

					HS.timeheld = HS.timeheld + 1;

					HS.held = HS.timeheld;

				} else {
					HS.currentDrag1.x = 0;
					HS.currentDrag1.y = 0;
					HS.timeheld = 0;
				}
			}
		}

		if (HS.showkeys && !HS.config && !HS.nottouched) {
			GUIStyle kk = new GUIStyle ();
			HS.showkeytimer = HS.showkeytimer + 1;
			float yomaklo = Screen.height / 32;
			float estron = Screen.width / 32;
			kk.normal.textColor = Color.white;
			kk.fontStyle = FontStyle.BoldAndItalic;
			kk.fontSize = (int)(0.75f * yomaklo);
			GUI.Box (new Rect ((Screen.width / 2) - (250 / 32) * estron, (Screen.height / 2) - (250 / 24) * yomaklo, (450 / 32) * estron, 450 / 24 * yomaklo), "Keybinds");
			GUI.Label (new Rect ((Screen.width / 2) - (180 / 32) * estron, (Screen.height / 2) - (200 / 24) * yomaklo, 100 / 32 * estron, 80 / 24 * yomaklo), "Open/Close key : \nA", kk);
			GUI.Label (new Rect ((Screen.width / 2) + (20 / 32) * estron, (Screen.height / 2) - (200 / 24) * yomaklo, 100 / 32 * estron, 80 / 24 * yomaklo), "Hack Selector Key : \nright arrow", kk);
			GUI.Label (new Rect ((Screen.width / 2) - (180 / 32) * estron, (Screen.height / 2) - (100 / 24) * yomaklo, 100 / 32 * estron, 80 / 24 * yomaklo), "MoveUp Key : \nlwft arrow", kk);
			GUI.Label (new Rect ((Screen.width / 2) + (20 / 32) * estron, (Screen.height / 2) - (100 / 24) * yomaklo, 100 / 32 * estron, 80 / 24 * yomaklo), "MoveDown Key : \nbacklash", kk);
			GUI.Label (new Rect ((Screen.width / 2) - (180 / 32) * estron, (Screen.height / 2), 100 / 32 * estron, 80 / 24 * yomaklo), "MoveRight key : \nbackquite", kk);
			GUI.Label (new Rect ((Screen.width / 2) + (20 / 32) * estron, (Screen.height / 2), 100 / 32 * estron, 80 / 24 * yomaklo), "MoveLeft key : \nA", kk);
			GUI.Label (new Rect ((Screen.width / 2) - (80 / 32) * estron, (Screen.height / 2) + (100 / 24) * yomaklo, 100 / 32 * estron, 80 / 24 * yomaklo), "Config Menu key : \nalpha8", kk);
		} else if(!HS.config){
			HS.showkeys = false;
		}
		if (HS.showkeytimer > 200) {
			HS.showkeys = false;
			HS.showkeytimer = 0;
		}
		if (HS.Textx) {
			menubc.normal.background = MakeTex (1, 1, HS.menuopenb);
			menuoc.normal.background = MakeTex (1, 1, HS.menunormalc);
			menuoc.normal.textColor = HS.menunormaltc;
			HS.openc = MMInfo.opentext;
			HS.closec ="";
			HS.Textx = false;
		} else
		{
			menubc.normal.background = MakeTex (1, 1, HS.menucloseb);
			menuoc.normal.background = MakeTex (1, 1, HS.menuoffc);
			menuoc.normal.textColor = HS.menuofftc;
			HS.closec = MMInfo.closetext;
			HS.openc = "";
			HS.Textx = true;
				
		}
		if (!HS.showkeys || HS.config) {
			GUI.Box (new Rect (MMInfo.OpenRect.x - (.25f * HS.menusize), MMInfo.OpenRect.y - (.25f * HS.menusize), 7f * HS.menusize, 2f * HS.menusize), "", menubc);



			if (GUI.Button (MMInfo.OpenRect, HS.openc + HS.closec, menuoc) && HS.held < 20 && HS.inputtype == 1) {
			
				HS.showmenu ();
			}

		}
		if (HS.ShowHide)
		{
			

			boxbc.normal.background = MakeTex (1, 1, HS.boxb);

			GUI.Box (new Rect (MMInfo.MenuRect.x- (.25f * HS.menusize),MMInfo.MenuRect.y - (.25f* HS.menusize), HS.boxx + (0.5f * HS.menusize) ,HS.yy + (0.5f * HS.menusize)), "", boxbc);

			GUI.Box (new Rect (MMInfo.MenuRect.x ,MMInfo.MenuRect.y ,HS.boxx,HS.yy), "Menu By TheArmKing©\nModded by Me", boxoc);
				
				toggoc.alignment = TextAnchor.MiddleCenter;
			if (MMInfo.btnc > 0 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);
				if (HS.inputtype == 2) {
					GUI.Box (new Rect (MMInfo.MenuRect.x + .25f*HS.menusize * HS.xval,MMInfo.MenuRect.y + ((HS.v + HS.w + HS.x -2)/20 * HS.menusize)  ,9f* HS.menusize,2f* HS.menusize),"",selectme);
				}

				if (HS.blue) {
					HS.blue = false;
					toggoc.normal.textColor = HS.togglesontc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);

					GUI.Box (HS.border, "", toggbc);

				} else {
					HS.blue = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);

				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs1, toggoc)) {
					HS.hack1 ();

				}
			}
			if (MMInfo.btnc > 1 && MMInfo.btnc < 21) {
				EvenCal();

				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);
			
				if (HS.blue2) {
					HS.blue2 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);

				} else {
					HS.blue2 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);

				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs2, toggoc)) {
					HS.hack2 ();
				}
			}
			if (MMInfo.btnc > 2 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);
			
				if (HS.blue3) {
					HS.blue3 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue3 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs3, toggoc)) {
					HS.hack3 ();

				}
			}
			if (MMInfo.btnc > 3 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);


				if (HS.blue4) {
					HS.blue4 = false;
					toggoc.normal.textColor = HS.togglesontc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);

					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue4 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}
				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs4, toggoc)) {
					MMInfo.hack4 = !MMInfo.hack4;
					HS.blue4 = !HS.blue4;
				}
			}
			if (MMInfo.btnc > 4 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue5) {
					HS.blue5 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue5 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs5, toggoc)) {
					MMInfo.hack5 = !MMInfo.hack5;
					HS.blue5 = !HS.blue5;
				}
			}
			if (MMInfo.btnc > 5 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue6) {
					HS.blue6 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue6 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs6, toggoc)) {
					MMInfo.hack6 = !MMInfo.hack6;
					HS.blue6 = !HS.blue6;
				}
			}
			if (MMInfo.btnc > 6 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue7) {
					HS.blue7 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue7 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs7, toggoc)) {
					MMInfo.hack7 = !MMInfo.hack7;
					HS.blue7 = !HS.blue7;
				}
			}
			if (MMInfo.btnc > 7 && MMInfo.btnc < 21) {
				EvenCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue8) {
					HS.blue8 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue8 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs8, toggoc)) {
					MMInfo.hack8 = !MMInfo.hack8;
					HS.blue8 = !HS.blue8;
				}
			}
			if (MMInfo.btnc > 8 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue9) {
					HS.blue9 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue9 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs9, toggoc)) {
					MMInfo.hack9 = !MMInfo.hack9;
					HS.blue9 = !HS.blue9;
				}
			}
			if (MMInfo.btnc > 9 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue10) {
					HS.blue10 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue10 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs10, toggoc)) {
					MMInfo.hack10 = !MMInfo.hack10;
					HS.blue10 = !HS.blue10;
				}
			}
			if (MMInfo.btnc > 10 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue11) {
					HS.blue11 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue11 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs11, toggoc)) {
					MMInfo.hack11 = !MMInfo.hack11;
					HS.blue11 = !HS.blue11;
				}
			}
			if (MMInfo.btnc > 11 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue12) {
					HS.blue12 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue12 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs12, toggoc)) {
					MMInfo.hack12 = !MMInfo.hack12;
					HS.blue12 = !HS.blue12;
				}
			}
			if (MMInfo.btnc > 12 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue13) {
					HS.blue13 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue13 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs13, toggoc)) {
					MMInfo.hack13 = !MMInfo.hack13;
					HS.blue13 = !HS.blue13;
				}
			}
			if (MMInfo.btnc > 13 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue14) {
					HS.blue14 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue14 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs14, toggoc)) {
					MMInfo.hack14 = !MMInfo.hack14;
					HS.blue14 = !HS.blue14;
				}
			}
			if (MMInfo.btnc > 14 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue15) {
					HS.blue15 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue15 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs15, toggoc)) {
					MMInfo.hack15 = !MMInfo.hack15;
					HS.blue15 = !HS.blue15;
				}
			}
			if (MMInfo.btnc > 15 && MMInfo.btnc < 21) {
				EvenCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue16) {
					HS.blue16 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue16 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs16, toggoc)) {
					MMInfo.hack16 = !MMInfo.hack16;
					HS.blue16 = !HS.blue16;
				}
			}
			if (MMInfo.btnc > 16 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue17) {
					HS.blue17 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue17 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs17, toggoc)) {
					MMInfo.hack17 = !MMInfo.hack17;
					HS.blue17 = !HS.blue17;
				}
			}
			if (MMInfo.btnc > 17 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue18) {
					HS.blue18 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue18 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs18, toggoc)) {
					MMInfo.hack18 = !MMInfo.hack18;
					HS.blue18 = !HS.blue18;
				}
			}
			if (MMInfo.btnc > 18 && MMInfo.btnc < 21) {
				OddCal ();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue19) {
					HS.blue19 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue19 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs19, toggoc)) {
					MMInfo.hack19 = !MMInfo.hack19;
					HS.blue19 = !HS.blue19;
				}
			}
			if (MMInfo.btnc > 19 && MMInfo.btnc < 21) {
				EvenCal();
				HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

				if (HS.blue20) {
					HS.blue20 = false;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
					toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
					toggoc.normal.textColor = HS.togglesontc;
					GUI.Box (HS.border, "", toggbc);
				} else {
					HS.blue20 = true;
					toggoc.normal.textColor = HS.togglesclosetc;
					toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
					toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
					GUI.Box (HS.border, "", toggbc);
				}

				if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.hs20, toggoc)) {
					MMInfo.hack20 = !MMInfo.hack20;
					HS.blue20 = !HS.blue20;

				}
			}


			if (MMInfo.btnc % 2 == 0) {
				OddCal ();

			} else {
				EvenCal ();

			}
			HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);
			if (HS.iglink) {
				HS.igtimer = HS.igtimer + 1;
				toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
				toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
				toggoc.normal.textColor = HS.togglesontc;
				GUI.Box (HS.border, "", toggbc);




			} if (HS.igtimer > 200) {
				HS.iglink = false;
				HS.igtimer = 0;
			}else if(!HS.iglink){
				
				toggoc.normal.textColor = HS.togglesclosetc;
				toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
				toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
				GUI.Box (HS.border, "", toggbc);


			}

			if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.io + HS.Thanks, toggoc)) {
				HS.openurl1 ();
				HS.iglink = true;
			}


			if (MMInfo.btnc % 2 == 0) {
				EvenCal ();

			} else {
				OddCal ();

			}
			HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);

			if (!HS.ytlink) {
				
				toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
				toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
				toggoc.normal.textColor = HS.togglesontc;
				GUI.Box (HS.border, "", toggbc);

			} if (HS.yttimer > 200) {
				HS.yttimer = 0;
				HS.ytlink = false;
			}
			if(HS.ytlink){
				HS.yttimer = HS.yttimer + 1;
				toggoc.normal.textColor = HS.togglesclosetc;
				toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc); 
				toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
				GUI.Box (HS.border, "", toggbc);

			}

			if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), HS.yt + HS.Thanks2, toggoc)) {
				HS.openurl2 ();
				HS.ytlink = true;


			}
			if (MMInfo.btnc % 2 == 0) {
				OddCal ();

			} else {
				EvenCal ();

			}
			HS.border =  new Rect (HS.bx, MMInfo.MenuRect.y + HS.v + HS.w, 8.8f* HS.menusize, 1.8f* HS.menusize);


			if (HS.inputtype == 1) {
				toggoc.normal.background = MakeTex (1, 1, HS.togglesonc);
				toggbc.normal.background = MakeTex (1, 1, HS.togglesonb);
				toggoc.normal.textColor = HS.togglesontc;
				GUI.Box (HS.border, "", toggbc);
			}

			if (HS.inputtype == 2) {
				toggoc.normal.background = MakeTex (1, 1, HS.togglesoffc);
				toggbc.normal.background = MakeTex (1, 1, HS.togglescloseb);
				toggoc.normal.textColor = HS.togglesclosetc;
				GUI.Box (HS.border, "", toggbc);
			}
				
				

			

			if (GUI.Button (new Rect (HS.tx, MMInfo.MenuRect.y + HS.v + HS.b,8.5f* HS.menusize, 1.5f* HS.menusize), "Config Menu", toggoc)) {
				HS.ShowConfigMenu ();



			}
			HS.yy = HS.v + HS.b + (2f * HS.menusize);


		}


		if (HS.config) {
			HS.nottouched = true;
			HS.ShowHide = false;


			GUI.Box (new Rect ((Screen.width / 2) - 195, (Screen.height / 2) - 120, 390, 250), "");
			GUI.Box (new Rect ((Screen.width / 2) - 200, (Screen.height / 2) - 125, 400, 260),"");
			if (HS.inputtype == 1) {
				GUI.Box (new Rect ((Screen.width / 2) - 190, (Screen.height / 2) - 110, 380, 25), "Config Menu");
			}
			if (HS.inputtype == 2) {
				if (GUI.Button (new Rect ((Screen.width / 2) - 185, (Screen.height / 2) - 110, 180, 25), "Key Config")) {
					HS.keycon = true;
					HS.normalcon = false;
				}
				if (GUI.Button (new Rect ((Screen.width / 2) + 5, (Screen.height / 2) - 110, 180, 25), "Other Config")) {
					HS.keycon = false;
					HS.normalcon = true;
				}
			}
			if (HS.keycon || HS.normalcon) {


				if (GUI.Button (new Rect ((Screen.width / 2) - 75, (Screen.height / 2) + 135, 150, 25), "Close Config Menu ⊗")) {
					HS.config = false;
					HS.Textx = false;

				}
				if (HS.savetimer > 200) {
					HS.mmk = false;
					HS.savetimer = 0;
				}
				if (HS.mmk) {
					HS.save = "Config Saved ✔";
					HS.savetimer = HS.savetimer + 1;


				}
				if (!HS.mmk) {

					HS.save = "Save Config";
				}

				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 80, 170, 30),HS.save)) {
					HS.mmk = true;
					if (HS.inputtype == 2) {
						PlayerPrefs.SetString ("OpenKey", HS.openk);
						PlayerPrefs.SetString ("SelectKey", HS.selectk);
						PlayerPrefs.SetString ("UpKey", HS.upk);
						PlayerPrefs.SetString ("DownKey", HS.downk);
						PlayerPrefs.SetString ("RightKey", HS.rightk);
						PlayerPrefs.SetString ("LeftKey", HS.leftk);
						PlayerPrefs.SetString ("ConfigKey", HS.configk);
						PlayerPrefs.SetInt ("Length", HS.stylelength);
						PlayerPrefs.SetInt ("Style", HS.Stylenum);
						PlayerPrefs.SetFloat ("OpenPosx", HS.OpenX);
						PlayerPrefs.SetFloat ("OpenPosy", HS.OpenY);
						PlayerPrefs.SetFloat ("MenuPosx",HS.MenuX);
						PlayerPrefs.SetFloat ("MenuPosy",HS.MenuY);
						PlayerPrefs.SetFloat ("Alpha", HS.alpha);
						PlayerPrefs.SetFloat ("MenuSize",HS.menusize);
						if (HS.noconkey) {
							PlayerPrefs.SetInt ("NoConKey", 1);
						} else {
							PlayerPrefs.SetInt ("NoConKey", 0);
						} 
						if (HS.showkeys) {
							PlayerPrefs.SetInt ("Showkeys", 1);
						} else {
							PlayerPrefs.SetInt ("Showkeys", 0);
						}
						if (HS.invisble) {
							PlayerPrefs.SetInt ("Invisible", 1);

						} else {
							PlayerPrefs.SetInt ("Invisble", 0);
						}
						if (HS.clipdrag) {
							PlayerPrefs.SetInt ("ClipDrag", 1);
						} else {
							PlayerPrefs.SetInt ("ClipDrag", 0);
						}
						if (HS.tripletap) {
							PlayerPrefs.SetInt ("TripleTap", 1);

						} else {
							PlayerPrefs.SetInt ("TripleTap", 0);
						}
						if (HS.keyinput) {
							PlayerPrefs.SetInt ("KeyInput", 1);

						} else {
							PlayerPrefs.SetInt ("KeyInput", 0);
						}
						PlayerPrefs.Save ();
					}
				}
				if (HS.resettimer > 200) {
					HS.mk2 = false;
					HS.resettimer = 0;
				}
				if (HS.mk2) {
					HS.reset = "Settings Resetted ✔";
					HS.resettimer = HS.resettimer + 1;


				}
				if (!HS.mk2) {

					HS.reset = "Reset to Default";
				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2) + 80, 170, 30), HS.reset)) {
					PlayerPrefs.DeleteAll ();
					HS.mk2 = true;
				}
			}

			if (HS.keycon) {
				
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) - 80, 170, 30), "MenuOpen Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "MenuOpen Key";
					HS.keytip = "Key used to Open/Close to Menu";
					HS.currentkey = HS.openk;
				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2) - 80, 170, 30), "HackSelect Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "HackSelect Key";
					HS.keytip = "Key used to Select a Hack";
					HS.currentkey = HS.selectk;
				}
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) - 40, 170, 30), "MoveUp Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "MoveUp Key";
					HS.keytip = "Key used to move to Hack Selector Up";
					HS.currentkey = HS.upk;
				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2) - 40, 170, 30), "MoveDown Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "MoveDown Key";
					HS.keytip = "Key used to move to Hack Selector Down";
					HS.currentkey = HS.downk;
				}
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2), 170, 30), "MoveRight Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "MoveRight Key";
					HS.keytip = "Key used to move to Hack Selector Right";
					HS.currentkey = HS.rightk;
				}

				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2), 170, 30), "MoveLeft Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "MoveLeft Key";
					HS.keytip = "Key used to move to Hack Selector Left";
					HS.currentkey = HS.leftk;
				}

				if (GUI.Button(new Rect((Screen.width / 2)- 87.5f, (Screen.height / 2) + 40, 170, 30), "ConfigMenu Key")) {
					HS.keycon = false;
					HS.keycontap = true;
					HS.keytype = "ConfigMenu Key";
					HS.keytip = "Key used to Open the ConfigMenu";
					HS.currentkey = HS.configk;
				}

			} 

			if (HS.normalcon) {
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) - 80, 170, 30), "GUI Style")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "GUI Styles";
					HS.keytip = "Choose the type of Menu Style(Colours) you want";

				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2) - 80, 170, 30), "Length Style")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Length Style";
					HS.keytip = "Choose Long for 1 Button per row\n Wide for 2 Buttons per row";
				}
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) - 40, 170, 30), "Open/Close Position")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Open/Close Pos";
					HS.keytip = "Set the Default X and Y Position the Open/Close Button(from top left corner)";
				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2) - 40, 170, 30), "Menu Position")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Menu Pos";
					HS.keytip = "Set the Deafult X and Y Position of the Menu(from top left corner)";
				}
				if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2), 170, 30), "Alpha")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Alpha/Opacity";
					HS.keytip = "Set the Opacity of the menu by using the slider below";
				}
				if (GUI.Button(new Rect((Screen.width / 2), (Screen.height / 2), 170, 30), "Menu Size")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Menu Size";
					HS.keytip = "Set the Size of the menu(if buttons are out of range or too small)";
				}
				if (GUI.Button(new Rect((Screen.width / 2)- 87.5f, (Screen.height / 2) + 40, 170, 30), "Other Options")) {
					HS.normalcon = false;
					HS.normalcontap = true;
					HS.keytype = "Other Options";

				}



			}
			if (HS.keycontap) {
				
				GUI.Box(new Rect ((Screen.width / 2)  -87.5f, (Screen.height / 2) - 80, 170, 30), HS.keytype);
				GUI.Label(new Rect((Screen.width / 2)  -195, (Screen.height / 2) - 45, 390, 80), HS.keytip + "\n Click the button below to choose a new one" + "\n\n Current Key:",configs);
				if (GUI.Button (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 35, 170, 30), HS.currentkey)) {
					HS.newkey = true;
					HS.presskey = true;


				}
				if (HS.presskey) {
					HS.currentkey = "Press a Key";
				}
				if (GUI.Button (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 85, 170, 30), "Back ↩")) {
					HS.keycon = true;
					HS.keycontap = false;
				}
			}
			if (HS.normalcontap) {
				if(HS.keytype == "Menu Size") {
					HS.menusize = GUI.HorizontalSlider (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 20, 170, 30),(int)HS.menusize, 10f,50f); 
					GUI.Label (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 45, 170, 30), HS.menusize.ToString(),configs);
				}
				if (HS.keytype == "GUI Styles") {
					if(GUI.Button (new Rect ((Screen.width / 2) - 155, (Screen.height / 2) - 27, 150, 30)," iOSGods Theme")) { HS.Stylenum = 1; }
					if(GUI.Button (new Rect ((Screen.width / 2), (Screen.height / 2) - 27, 150, 30), " Google Theme")) { HS.Stylenum = 2; }
					if(GUI.Button (new Rect ((Screen.width / 2) - 155, (Screen.height / 2) + 8, 150, 30), " Random Theme")) { HS.Stylenum = 3; }
					if(GUI.Button (new Rect ((Screen.width / 2), (Screen.height / 2) + 8, 150, 30), " xxx Theme")) { HS.Stylenum = 4; }
					if(GUI.Button (new Rect ((Screen.width / 2) - 155, (Screen.height / 2) + 48, 150, 30), "Pink Theme")) { HS.Stylenum = 5; }
					if(GUI.Button (new Rect ((Screen.width / 2), (Screen.height / 2) + 48 , 150, 30), " Gay Theme")) { HS.Stylenum = 6; }
				}
				if (HS.keytype == "Other Options") {
					HS.invisble = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2) - 45, 390, 18), HS.invisble, " Make Open/Close Button Invisible");
					HS.clipdrag = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2) - 27, 390, 18), HS.clipdrag, " Dragging Open/Close Button to drag menu also");
					HS.showkeys = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2)  - 9, 390, 18), HS.showkeys, " Show all your keybinds before menu apppears");
					HS.keyinput = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2) + 9, 390, 18), HS.keyinput, " Enable Key Input for wireless keyboards/controllers");
					HS.tripletap = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2) + 27, 390, 33), HS.tripletap, " Make ConfigMenu Appear by touching the screen \nwith 3 fingers");
					HS.noconkey = GUI.Toggle (new Rect ((Screen.width / 2) - 150, (Screen.height / 2) + 60 , 390, 18), HS.noconkey, " Use a Seperate KeyBind for opening the Config Menu");


				}
				if (HS.keytype == "Length Style") {
					GUI.Label(new Rect((Screen.width / 2) - 87.5f, (Screen.height / 2) + 10, 170, 30),"Current Selection : "+HS.stylelength,configs);
					if (GUI.Button (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 40, 170, 30), "Long")) {
						HS.stylelength = 1;
					}
					if (GUI.Button (new Rect ((Screen.width / 2), (Screen.height / 2) + 40, 170, 30), "Wide")) {
						HS.stylelength = 2;
					}

				} 
				if (HS.keytype == "Open/Close Pos") {
					MMInfo.OpenRect.x = GUI.HorizontalSlider (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 40, 170, 30), MMInfo.OpenRect.x, 2.5f*HS.menusize, Screen.width - (135/2) *  HS.menusize); 
					GUI.Label (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 50, 170, 30), MMInfo.OpenRect.x.ToString(),configs);
					MMInfo.OpenRect.y = GUI.HorizontalSlider (new Rect ((Screen.width / 2), (Screen.height / 2) + 40, 170, 30), MMInfo.OpenRect.y, 2.5f*HS.menusize,Screen.height - (35/2) *  HS.menusize );
					GUI.Label (new Rect ((Screen.width / 2) , (Screen.height / 2) + 50, 170, 30), MMInfo.OpenRect.y.ToString(),configs);
				}
				if (HS.keytype == "Menu Pos") {
					MMInfo.MenuRect.x = GUI.HorizontalSlider (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 40, 170, 30), MMInfo.MenuRect.x, 0, Screen.width - HS.boxx - 5); 
					GUI.Label (new Rect ((Screen.width / 2) - 175, (Screen.height / 2) + 50, 170, 30),MMInfo.MenuRect.x.ToString(),configs);
					MMInfo.MenuRect.y = GUI.HorizontalSlider (new Rect ((Screen.width / 2), (Screen.height / 2) + 40, 170, 30), MMInfo.MenuRect.y, 0, Screen.height - HS.yy - 5 );
					GUI.Label (new Rect ((Screen.width / 2) , (Screen.height / 2) + 50, 170, 30), MMInfo.MenuRect.y.ToString(),configs);
				}
				if (HS.keytype == "Alpha/Opacity") {
					HS.alpha = GUI.HorizontalSlider (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 20, 170, 30),HS.alpha, 0f,1f); 
					GUI.Label (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 45, 170, 30), HS.alpha.ToString(),configs);
				}
				GUI.Box (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) - 80, 170, 30), HS.keytype);
				if (HS.keytype != "Other Options") {
					GUI.Label (new Rect ((Screen.width / 2) - 195, (Screen.height / 2) - 45, 390, 60), HS.keytip, configs);
				}
					if (GUI.Button (new Rect ((Screen.width / 2) - 87.5f, (Screen.height / 2) + 85, 170, 30), "Back ↩")) {
						HS.normalcon = true;
						HS.normalcontap = false;
					}
				
			}
		
		} 
	

		if (MMInfo.hack1)
		{

			HS.hs1 = MMInfo.string1 + " : ON";
			MMInfo.hack1 = false;

		}
		else
		{
			HS.hs1 = MMInfo.string1 + " : OFF";
			MMInfo.hack1 = true;

		}

		if (MMInfo.hack2)
		{
			HS.hs2 = MMInfo.string2 + " : ON";
			MMInfo.hack2 = false;

		}
		else
		{
			HS.hs2 = MMInfo.string2 + " : OFF";
			MMInfo.hack2 = true;

		}

		if (MMInfo.hack3)
		{
			HS.hs3 = MMInfo.string3 + " : ON";
			MMInfo.hack3 = false;
		}
		else
		{
			HS.hs3 = MMInfo.string3 + " : OFF";
			MMInfo.hack3 = true;
		}
		if (MMInfo.hack4)
		{

			HS.hs4 = MMInfo.string4 + " : ON";
			MMInfo.hack4 = false;
		}
		else
		{
			HS.hs4 = MMInfo.string4 + " : OFF";
			MMInfo.hack4 = true;
		}

		if (MMInfo.hack6)
		{
			HS.hs6 = MMInfo.string6 + " : ON";
			MMInfo.hack6 = false;
		}
		else
		{
			HS.hs6 = MMInfo.string6 + " : OFF";
			MMInfo.hack6 = true;
		}

		if (MMInfo.hack5)
		{
			HS.hs5 = MMInfo.string5 + " : ON";
			MMInfo.hack5 = false;
		}
		else
		{
			HS.hs5 = MMInfo.string5 + " : OFF";
			MMInfo.hack5 = true;
		}
		if (MMInfo.hack7)
		{

			HS.hs7 = MMInfo.string7 + " : ON";
			MMInfo.hack7 = false;
		}
		else
		{
			HS.hs7 = MMInfo.string7 + " : OFF";
			MMInfo.hack7 = true;
		}

		if (MMInfo.hack8)
		{
			HS.hs8 = MMInfo.string8 + " : ON";
			MMInfo.hack8 = false;
		}
		else
		{
			HS.hs8 = MMInfo.string8 + " : OFF";
			MMInfo.hack8 = true;
		}

		if (MMInfo.hack9)
		{
			HS.hs9 = MMInfo.string9 + " : ON";
			MMInfo.hack9 = false;
		}
		else
		{
			HS.hs9 = MMInfo.string9 + " : OFF";
			MMInfo.hack9 = true;
		}
		if (MMInfo.hack10)
		{

			HS.hs10 = MMInfo.string10 + " : ON";
			MMInfo.hack10 = false;
		}
		else
		{
			HS.hs10 = MMInfo.string10 + " : OFF";
			MMInfo.hack10 = true;
		}

		if (MMInfo.hack11)
		{
			HS.hs11 = MMInfo.string11 + " : ON";
			MMInfo.hack11 = false;
		}
		else
		{
			HS.hs11 = MMInfo.string11 + " : OFF";
			MMInfo.hack11 = true;
		}

		if (MMInfo.hack12)
		{
			HS.hs12 = MMInfo.string12 + " : ON";
			MMInfo.hack12 = false;
		}
		else
		{
			HS.hs12 = MMInfo.string12 + " : OFF";
			MMInfo.hack12 = true;
		}
		if (MMInfo.hack13)
		{

			HS.hs13 = MMInfo.string13 + " : ON";
			MMInfo.hack13 = false;
		}
		else
		{
			HS.hs13 = MMInfo.string13 + " : OFF";
			MMInfo.hack13 = true;
		}

		if (MMInfo.hack14)
		{
			HS.hs14 = MMInfo.string14 + " : ON";
			MMInfo.hack14 = false;
		}
		else
		{
			HS.hs14 = MMInfo.string14 + " : OFF";
			MMInfo.hack14 = true;
		}

		if (MMInfo.hack15)
		{
			HS.hs15 = MMInfo.string15 + " : ON";
			MMInfo.hack15 = false;
		}
		else
		{
			HS.hs15 = MMInfo.string15 + " : OFF";
			MMInfo.hack15 = true;
		}
		if (MMInfo.hack16)
		{
			HS.hs16 = MMInfo.string16 + " : ON";
			MMInfo.hack16 = false;
		}
		else
		{
			HS.hs16 = MMInfo.string16 + " : OFF";
			MMInfo.hack16 = true;
		}

		if (MMInfo.hack17)
		{
			HS.hs17 = MMInfo.string17 + " : ON";
			MMInfo.hack17 = false;
		}
		else
		{
			HS.hs17 = MMInfo.string17 + " : OFF";
			MMInfo.hack17 = true;
		}
		if (MMInfo.hack18)
		{

			HS.hs18 = MMInfo.string18 + " : ON ";
			MMInfo.hack18 = false;
		}
		else
		{
			HS.hs18 = MMInfo.string18 + " : OFF";
			MMInfo.hack18 = true;
		}

		if (MMInfo.hack19)
		{
			HS.hs19 = MMInfo.string19 + " : ON";
			MMInfo.hack19 = false;
		}
		else
		{
			HS.hs19 = MMInfo.string19 + " : OFF";
			MMInfo.hack19 = true;
		}

		if (MMInfo.hack20)
		{
			HS.hs20 = MMInfo.string20 + " : ON";
			MMInfo.hack20 = false;
		}
		else
		{
			HS.hs20 = MMInfo.string20 + " : OFF";
			MMInfo.hack20 = true;
		}
		if (HS.iglink) {
			HS.io = "";
			HS.Thanks = "Thanks For Visiting ☺";
			HS.ig = false;

		} else { HS.io = "Visit iOSGods";
			HS.Thanks = "";
			HS.ig = true;
		}
		if (HS.ytlink) {
			HS.yt = "";
			HS.Thanks2 = "Thanks For Visiting ☺";


		} else { HS.yt = "TheArmKing's YT Channel";
			HS.Thanks2 = "";

		}
	

	}
	public void ClassSpawner(int x,string s) {
		GUI.Button (new Rect (0, (x * 50), 200, 50), s);
	}
	public static void EvenCal() {
		if (HS.stylelength == 1) {
			HS.t = HS.t + 1;
			HS.v = HS.t * (1.75f*HS.menusize);
			HS.b = HS.t * (.25f*HS.menusize);
			HS.w = HS.b - (.15f * HS.menusize);
		} else if (HS.stylelength == 2) {
			HS.v = HS.t * (1.75f*HS.menusize);
			HS.b = HS.t * (.25f*HS.menusize);
			HS.w = HS.b - (.15f * HS.menusize);
			HS.bx = HS.bx + (9.5f* HS.menusize);
			HS.tx = HS.tx +(9.5f* HS.menusize);;
		}
	}
	public static void OddCal() {
		if (HS.stylelength == 2) {

			HS.bx = HS.bx - (9.5f* HS.menusize);
			HS.tx = HS.tx - (9.5f* HS.menusize);;
		}
		HS.t = HS.t + 1;
		HS.v = HS.t * (1.75f*HS.menusize);
		HS.b = HS.t * (.25f*HS.menusize);
		HS.w = HS.b - (.15f * HS.menusize);
	}
	public static void Updatex() {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;

		}
		if (fingerCount > 0)
			print("User has " + fingerCount + " finger(s) touching the screen");
		if (MMInfo.hack1) {
			print ("Hack 1 Active");
		}
		if (MMInfo.hack2) {
			print ("Hack 2 Active");
		}
		if (MMInfo.hack3) {
			print ("Hack 3 Active");
		}
		if (HS.Stylenum == 1) {


			HS.togglesonb = new Color (0.91f,0.33f,0.44f,HS.alpha);
			HS.togglescloseb = Color.red;
			HS.togglesonc = Color.magenta;
			HS.togglesoffc = Color.black;
			HS.togglesontc = Color.white;
			HS.togglesclosetc = Color.white;
			HS.toggfs = FontStyle.Italic;
			HS.boxc = Color.black;
			HS.boxb = new Color (0.44f, 0.75f, 0.61f,HS.alpha);
			HS.boxtc = Color.white;
			HS.boxfs = FontStyle.Italic;
			HS.menunormalc = Color.black;
			HS.menuofftc = Color.white;
			HS.menunormaltc = Color.white;
			HS.menufs = FontStyle.BoldAndItalic;
			HS.menuoffc = Color.black;
			HS.menucloseb = new Color (0.44f, 0.75f, 0.61f,HS.alpha);
			HS.menuopenb = new Color (0.44f, 0.75f, 0.61f,HS.alpha);

		} 
		if (HS.Stylenum == 1 && HS.inputtype == 2) {
			HS.togglesonb = Color.red;
			HS.togglescloseb = new Color (0.44f, 0.75f, 0.61f,HS.alpha);
			HS.togglesonc = Color.black;
			HS.togglesoffc = Color.magenta;
			HS.togglesontc = Color.white;
			HS.togglesclosetc = Color.white;
		}


		if (HS.inputtype == 2) {
			if (Input.GetKeyDown (HS.openkey) && !HS.config && !HS.showkeys) {
			
				HS.showmenu ();
				HS.nice = !HS.nice;
			

			}
			if (Input.GetKeyDown (HS.configkey) && HS.noconkey) {
				HS.ShowConfigMenu ();
			}

			if (HS.newkey) {
				
				foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (kcode) && kcode != KeyCode.Mouse0) {
						HS.presskey = false;
						HS.currentkey =  kcode.ToString ();
						if (HS.keytype == "MenuOpen Key") {
							HS.openk = kcode.ToString ();

							HS.openkey = kcode;
						}
						if (HS.keytype == "HackSelect Key") {
							HS.selectk = kcode.ToString ();
							HS.selectkey = kcode;
						}
						if (HS.keytype == "MoveUp Key") {
							HS.upk = kcode.ToString ();
							HS.upkey = kcode;
						}
						if (HS.keytype == "MoveDown Key") {
							HS.downk = kcode.ToString ();
							HS.downkey = kcode;
						}
						if (HS.keytype == "MoveRight Key") {
							HS.rightk = kcode.ToString ();
							HS.rightkey = kcode;
						}
						if (HS.keytype == "MoveLeft Key") {
							HS.leftk = kcode.ToString ();
							HS.leftkey = kcode;
						}
						if (HS.keytype == "ConfigMenu Key") {
							HS.configk = kcode.ToString ();
							HS.configkey = kcode;
						}
				
					}
				}
			}

			if (HS.nice) {
				if (HS.stylelength == 2 && Input.GetKeyDown (HS.rightkey)) {
					if (HS.index % 2 != 0) {
						if (HS.index + 1 != MMInfo.btnc + 4) {
							HS.xval = HS.xval + 9.5f*HS.menusize;
							HS.index = HS.index + 1;

						}
					} else {
					}
				}
				if (HS.stylelength == 2 && Input.GetKeyDown (HS.leftkey)) {
					if (HS.index % 2 == 0) {
						HS.xval = HS.xval - 9.5f*HS.menusize;
						HS.index = HS.index - 1;

					} else {
					}
				}
				if (Input.GetKey (HS.downkey)) {  
					HS.timenow = HS.timenow + Time.deltaTime;
				}
				if (Input.GetKeyDown (HS.downkey)) {
					HS.timenow = 1f;
				}
				if (HS.index != MMInfo.btnc + 3 && HS.timenow >= HS.maxtime) {
					if (HS.stylelength == 2 && HS.index != MMInfo.btnc + 2
					    || HS.stylelength == 1) {

						HS.x = HS.x + 2f * HS.menusize;
						if (HS.stylelength == 1) {
							HS.index = HS.index + 1;
						}
						if (HS.stylelength == 2) {
							HS.index = HS.index + 2;
						}

						HS.timenow = 0;


					}
				} else {
				}
			



				if (Input.GetKey (HS.upkey)) {  
					HS.uptime = HS.uptime + Time.deltaTime;
				}
				if (Input.GetKeyDown (HS.upkey)) {
					HS.uptime = 1f;
				}
				if (HS.index != 1 && HS.uptime >= HS.maxtime) {
					if (HS.stylelength == 2 && HS.index != 2
					     || HS.stylelength == 1) {
						HS.x = HS.x - 2f * HS.menusize;
						if (HS.stylelength == 1) {
							HS.index = HS.index - 1;
						}
						if (HS.stylelength == 2) {
							HS.index = HS.index - 2;
						}

					}
					HS.uptime = 0;

				} else {
				}


				if (HS.index == 1 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 1) {
					HS.hack1 ();

				}
				if (HS.index == 2 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 2) {
					HS.hack2 ();

				}
				if (HS.index == 3 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 3) {
					HS.hack3 ();

				}
				if (HS.index == 4 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 4) {
					HS.hack4 ();

				}
				if (HS.index == 5 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 5) {
					HS.hack5 ();


				}
				if (HS.index == 6 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 6) {
					HS.hack6 ();
				}
				if (HS.index == 7 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 7) {
					HS.hack7 ();
				}
				if (HS.index == 8 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 8) {
					HS.hack8 ();
				}
				if (HS.index == 9 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 9) {
					HS.hack9 ();

				}
				if (HS.index == 10 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 10) {
					HS.hack10 ();
				}
				if (HS.index == 11 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 11) {
					HS.hack11 ();


				}
				if (HS.index == 12 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 12) {
					HS.hack12 ();
				}
				if (HS.index == 13 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 13) {
					HS.hack13 ();
				}
				if (HS.index == 14 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 14) {
					HS.hack14 ();
				}
				if (HS.index == 15 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 15) {
					HS.hack15 ();

				}
				if (HS.index == 16 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 16) {
					HS.hack16 ();
				}
				if (HS.index == 17 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 17) {
					HS.hack17 ();
				}
				if (HS.index == 18 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 18) {
					HS.hack18 ();
				}
				if (HS.index == 19 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 19) {
					HS.hack19 ();
				}
				if (HS.index == 20 && Input.GetKeyDown (HS.selectkey) && MMInfo.btnc >= 20) {
					HS.hack20 ();
				}
				if (HS.index == MMInfo.btnc + 1 && Input.GetKeyDown (HS.selectkey)) {
					HS.openurl1 ();
				}
				if (HS.index == MMInfo.btnc + 2 && Input.GetKeyDown (HS.selectkey)) {
					HS.openurl2 ();
				}
				if (HS.index == MMInfo.btnc + 3 && Input.GetKeyDown (HS.selectkey)) {
					HS.ShowConfigMenu ();
				}

			}

		}
	}

}