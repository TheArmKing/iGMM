using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatGUI : MonoBehaviour {

	void OnGUI() {
		MainGUI ();
	}
	void Start() {
		MMInfo.btnc = 5;
			
		MMInfo.closetext = "Close";
		MMInfo.opentext = "Mod Menu";
		MMInfo.discord = "https://discord.gg/xZHa9rP";
		MMInfo.menuOpenx = 20f;
		MMInfo.menuOpeny = 20f;

		MMInfo.string1 = "Toggle 1 ";
		MMInfo.string2 = "Toggle 2 ";
		MMInfo.string3 = "Toggle 3 ";
		MMInfo.string4 = "Toggle 4 ";
		MMInfo.string5 = "Toggle 5 ";
		MMInfo.oncolor = Color.magenta;
		MMInfo.offcolor = Color.yellow;
		MMInfo.closecolor = Color.blue;
		MMInfo.opencolor = Color.black;
		MMInfo.playgame = "AGARZKI09 PLAY GAME";
	}
		// Token: 0x06000004 RID: 4
	public static void MainGUI()
		{

			HStrings.offcolor2 = MMInfo.offcolor;
			HStrings.offcolor1 = MMInfo.offcolor;
			HStrings.offcolor3 = MMInfo.offcolor;
			HStrings.offcolor4 = MMInfo.offcolor;
		HStrings.menumaker = "Menu by <color=#6fbf9c>TheArmKing</color>";
			HStrings.offcolor5 = MMInfo.offcolor;
		string text2 = "https://www.facebook.com/hannahcutedote";
			HStrings.offcolor6 = MMInfo.offcolor;
			HStrings.offcolor7 = MMInfo.offcolor;
			HStrings.offcolor8 = MMInfo.offcolor;
		HStrings.credit = "Hacked by <color=yellow>agarzki09</color>";
			HStrings.offcolor9 = MMInfo.offcolor;
			HStrings.offcolor10 = MMInfo.offcolor;
			HStrings.offcolor11 = MMInfo.offcolor;
			HStrings.offcolor12 = MMInfo.offcolor;
			HStrings.offcolor13 = MMInfo.offcolor;
			HStrings.offcolor14 = MMInfo.offcolor;
			HStrings.offcolor15 = MMInfo.offcolor;
			HStrings.oncolor2 = MMInfo.oncolor;
			HStrings.oncolor1 = MMInfo.oncolor;
			HStrings.oncolor3 = MMInfo.oncolor;
			HStrings.oncolor4 = MMInfo.oncolor;
			
			HStrings.oncolor5 = MMInfo.oncolor;
			HStrings.oncolor6 = MMInfo.oncolor;
			HStrings.oncolor7 = MMInfo.oncolor;
			HStrings.oncolor8 = MMInfo.oncolor;
			HStrings.oncolor9 = MMInfo.oncolor;
			
			HStrings.oncolor10 = MMInfo.oncolor;
			HStrings.oncolor11 = MMInfo.oncolor;
			HStrings.oncolor12 = MMInfo.oncolor;
			HStrings.oncolor13 = MMInfo.oncolor;
			HStrings.oncolor14 = MMInfo.oncolor;
			HStrings.oncolor15 = MMInfo.oncolor;
			
			if (HStrings.mainc)
			{
				GUI.backgroundColor = MMInfo.closecolor;
			}
			else
			{
				GUI.backgroundColor = MMInfo.opencolor;
			}
			if (GUI.Button(new Rect(MMInfo.menuOpenx, MMInfo.menuOpeny, 130f, 30f), HStrings.open + HStrings.close))
			{
				HStrings.ShowHide = !HStrings.ShowHide;
				HStrings.mainc = !HStrings.mainc;
				HStrings.onoff = !HStrings.onoff;
			}
			if (HStrings.onoff)
			{
				HStrings.close = MMInfo.closetext;
				HStrings.onoff = true;
				HStrings.open = "";
			}
			else
			{
				HStrings.open = MMInfo.opentext;
				HStrings.onoff = false;
				HStrings.close = "";
			}
			if (HStrings.ShowHide)
			{
				GUI.Box(new Rect(MMInfo.menuOpenx, MMInfo.menuOpeny + 30f, 180f, (float)(120 + MMInfo.btnc * 35)), string.Format("{0} \n {1}", HStrings.credit, HStrings.menumaker));
				if (HStrings.url1)
				{
					GUI.backgroundColor = Color.cyan;
					HStrings.url1 = false;
				}
				else
				{
					GUI.backgroundColor = Color.blue;
					HStrings.url1 = true;
				}
			if (GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 70f + (float)(MMInfo.btnc * 35), 170f, 30f), "Join My Discord"))
				{
				Application.OpenURL(MMInfo.discord);
					HStrings.url1 = !HStrings.url1;
				}
				if (HStrings.url2)
				{
					GUI.backgroundColor = Color.cyan;
					HStrings.url2 = false;
				}
				else
				{
					GUI.backgroundColor = Color.blue;
					HStrings.url2 = true;
				}
			if (GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 105f + (float)(MMInfo.btnc * 35), 170f, 30f), MMInfo.playgame))
				{
				HStrings.url2 = !HStrings.url2;
				}
				if (MMInfo.btnc >= 16)
				{
					GUI.backgroundColor = Color.red;
					GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 65f, 170f, 90f), "Button Count too high! \n Contact TheArmKing to \n add support for more");
				}
				if (MMInfo.btnc <= 0)
				{
					GUI.backgroundColor = Color.red;
					GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 65f, 170f, 90f), "Button Count too low! \n Did you declare it \n wrong? Try Again");
				}
				if (HStrings.blue)
				{
					GUI.backgroundColor = HStrings.offcolor1;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor1;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 0 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 65f, 170f, 30f), HStrings.hstring1))
				{
					MMInfo.hack1 = !MMInfo.hack1;
					HStrings.blue = !HStrings.blue;
				}
				if (HStrings.blue2)
				{
					GUI.backgroundColor = HStrings.offcolor2;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor2;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 1 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 100f, 170f, 30f), HStrings.hstring2))
				{
					MMInfo.hack2 = !MMInfo.hack2;
					HStrings.blue2 = !HStrings.blue2;
				}
				if (HStrings.blue3)
				{
					GUI.backgroundColor = HStrings.offcolor3;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor3;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 2 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 135f, 170f, 30f), HStrings.hstring3))
				{
					MMInfo.hack3 = !MMInfo.hack3;
					HStrings.blue3 = !HStrings.blue3;
				}
				if (HStrings.blue4)
				{
					GUI.backgroundColor = HStrings.offcolor4;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor4;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 3 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 170f, 170f, 30f), HStrings.hstring4))
				{
					MMInfo.hack4 = !MMInfo.hack4;
					HStrings.blue4 = !HStrings.blue4;
				}
				if (HStrings.blue5)
				{
					GUI.backgroundColor = HStrings.offcolor5;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor5;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 4 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 205f, 170f, 30f), HStrings.hstring5))
				{
					MMInfo.hack5 = !MMInfo.hack5;
					HStrings.blue5 = !HStrings.blue5;
				}
				if (HStrings.blue6)
				{
					GUI.backgroundColor = HStrings.offcolor6;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor6;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 5 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 240f, 170f, 30f), HStrings.hstring6))
				{
					MMInfo.hack6 = !MMInfo.hack6;
					HStrings.blue6 = !HStrings.blue6;
				}
				if (HStrings.blue7)
				{
					GUI.backgroundColor = HStrings.offcolor7;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor7;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 6 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 275f, 170f, 30f), HStrings.hstring7))
				{
					MMInfo.hack7 = !MMInfo.hack7;
					HStrings.blue7 = !HStrings.blue7;
				}
				if (HStrings.blue8)
				{
					GUI.backgroundColor = HStrings.offcolor8;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor8;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 7 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 310f, 170f, 30f), HStrings.hstring8))
				{
					MMInfo.hack8 = !MMInfo.hack8;
					HStrings.blue8 = !HStrings.blue8;
				}
				if (HStrings.blue9)
				{
					GUI.backgroundColor = HStrings.offcolor9;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor9;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 8 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 345f, 170f, 30f), HStrings.hstring9))
				{
					MMInfo.hack9 = !MMInfo.hack9;
					HStrings.blue9 = !HStrings.blue9;
				}
				if (HStrings.blue10)
				{
					GUI.backgroundColor = HStrings.offcolor10;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor10;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 9 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 380f, 170f, 30f), HStrings.hstring10))
				{
					MMInfo.hack10 = !MMInfo.hack10;
					HStrings.blue10 = !HStrings.blue10;
				}
				if (HStrings.blue11)
				{
					GUI.backgroundColor = HStrings.offcolor11;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor11;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 10 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 415f, 170f, 30f), HStrings.hstring11))
				{
					MMInfo.hack11 = !MMInfo.hack11;
					HStrings.blue11 = !HStrings.blue11;
				}
				if (HStrings.blue12)
				{
					GUI.backgroundColor = HStrings.offcolor12;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor12;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 11 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 450f, 170f, 30f), HStrings.hstring12))
				{
					MMInfo.hack12 = !MMInfo.hack12;
					HStrings.blue12 = !HStrings.blue12;
				}
				if (HStrings.blue13)
				{
					GUI.backgroundColor = HStrings.offcolor13;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor13;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 12 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 485f, 170f, 30f), HStrings.hstring13))
				{
					MMInfo.hack13 = !MMInfo.hack13;
					HStrings.blue13 = !HStrings.blue13;
				}
				if (HStrings.blue14)
				{
					GUI.backgroundColor = HStrings.offcolor14;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor14;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 12 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 520f, 170f, 30f), HStrings.hstring14))
				{
					MMInfo.hack14 = !MMInfo.hack14;
					HStrings.blue14 = !HStrings.blue14;
				}
				if (HStrings.blue15)
				{
					GUI.backgroundColor = HStrings.offcolor15;
				}
				else
				{
					GUI.backgroundColor = HStrings.oncolor15;
				}
				if (MMInfo.btnc < 16 && MMInfo.btnc > 12 && GUI.Button(new Rect(MMInfo.menuOpenx + 5f, MMInfo.menuOpeny + 555f, 170f, 30f), HStrings.hstring15))
				{
					MMInfo.hack15 = !MMInfo.hack15;
					HStrings.blue15 = !HStrings.blue15;
				}
			}
			if (MMInfo.hack1)
			{
				HStrings.hstring1 = string.Format("{0} <color=green>ON</color>", MMInfo.string1);
				MMInfo.hack1 = false;
				HStrings.blue = false;
			}
			else
			{
				HStrings.hstring1 = string.Format("{0} <color=red>OFF</color>", MMInfo.string1);
				MMInfo.hack1 = true;
				HStrings.blue = true;
			}
			if (MMInfo.hack2)
			{
				HStrings.hstring2 = string.Format("{0} <color=green>ON</color>", MMInfo.string2);
				MMInfo.hack2 = false;
				HStrings.blue2 = false;
			}
			else
			{
				HStrings.hstring2 = string.Format("{0} <color=red>OFF</color>", MMInfo.string2);
				MMInfo.hack2 = true;
				HStrings.blue2 = true;
			}
			if (MMInfo.hack3)
			{
				HStrings.hstring3 = string.Format("{0} <color=green>ON</color>", MMInfo.string3);
				MMInfo.hack3 = false;
				HStrings.blue3 = false;
			}
			else
			{
				HStrings.hstring3 = string.Format("{0} <color=red>OFF</color>", MMInfo.string3);
				MMInfo.hack3 = true;
				HStrings.blue3 = true;
			}
			if (MMInfo.hack4)
			{
				HStrings.hstring4 = string.Format("{0} <color=green>ON</color>", MMInfo.string4);
				MMInfo.hack4 = false;
				HStrings.blue4 = false;
			}
			else
			{
				HStrings.hstring4 = string.Format("{0} <color=red>OFF</color>", MMInfo.string4);
				MMInfo.hack4 = true;
				HStrings.blue4 = true;
			}
			if (MMInfo.hack5)
			{
				HStrings.hstring5 = string.Format("{0} <color=green>ON</color>", MMInfo.string5);
				MMInfo.hack5 = false;
				HStrings.blue5 = false;
			}
			else
			{
				HStrings.hstring5 = string.Format("{0} <color=red>OFF</color>", MMInfo.string5);
				MMInfo.hack5 = true;
				HStrings.blue5 = true;
			}
			if (MMInfo.hack6)
			{
				HStrings.hstring6 = string.Format("{0} <color=green>ON</color>", MMInfo.string6);
				MMInfo.hack6 = false;
				HStrings.blue6 = false;
			}
			else
			{
				HStrings.hstring6 = string.Format("{0} <color=red>OFF</color>", MMInfo.string6);
				MMInfo.hack6 = true;
				HStrings.blue6 = true;
			}
			if (MMInfo.hack7)
			{
				HStrings.hstring7 = string.Format("{0} <color=green>ON</color>", MMInfo.string7);
				MMInfo.hack7 = false;
				HStrings.blue7 = false;
			}
			else
			{
				HStrings.hstring7 = string.Format("{0} <color=red>OFF</color>", MMInfo.string7);
				MMInfo.hack7 = true;
				HStrings.blue7 = true;
			}
			if (MMInfo.hack8)
			{
				HStrings.hstring8 = string.Format("{0} <color=green>ON</color>", MMInfo.string8);
				MMInfo.hack8 = false;
				HStrings.blue8 = false;
			}
			else
			{
				HStrings.hstring8 = string.Format("{0} <color=red>OFF</color>", MMInfo.string8);
				MMInfo.hack8 = true;
				HStrings.blue8 = true;
			}
			if (MMInfo.hack9)
			{
				HStrings.hstring9 = string.Format("{0} <color=green>ON</color>", MMInfo.string9);
				MMInfo.hack9 = false;
				HStrings.blue9 = false;
			}
			else
			{
				HStrings.hstring9 = string.Format("{0} <color=red>OFF</color>", MMInfo.string9);
				MMInfo.hack9 = true;
				HStrings.blue9 = true;
			}
			if (MMInfo.hack10)
			{
				HStrings.hstring10 = string.Format("{0} <color=green>ON</color>", MMInfo.string10);
				MMInfo.hack10 = false;
				HStrings.blue10 = false;
			}
			else
			{
				HStrings.hstring10 = string.Format("{0} <color=red>OFF</color>", MMInfo.string10);
				MMInfo.hack10 = true;
				HStrings.blue10 = true;
			}
			if (MMInfo.hack11)
			{
				HStrings.hstring11 = string.Format("{0} <color=green>ON</color>", MMInfo.string11);
				MMInfo.hack11 = false;
				HStrings.blue11 = false;
			}
			else
			{
				HStrings.hstring11 = string.Format("{0} <color=red>OFF</color>", MMInfo.string11);
				MMInfo.hack11 = true;
				HStrings.blue11 = true;
			}
			if (MMInfo.hack12)
			{
				HStrings.hstring12 = string.Format("{0} <color=green>ON</color>", MMInfo.string12);
				MMInfo.hack12 = false;
				HStrings.blue12 = false;
			}
			else
			{
				HStrings.hstring12 = string.Format("{0} <color=red>OFF</color>", MMInfo.string12);
				MMInfo.hack12 = true;
				HStrings.blue12 = true;
			}
			if (MMInfo.hack13)
			{
				HStrings.hstring13 = string.Format("{0} <color=green>ON</color>", MMInfo.string13);
				MMInfo.hack13 = false;
				HStrings.blue13 = false;
			}
			else
			{
				HStrings.hstring13 = string.Format("{0} <color=red>OFF</color>", MMInfo.string13);
				MMInfo.hack13 = true;
				HStrings.blue13 = true;
			}
			if (MMInfo.hack14)
			{
				HStrings.hstring14 = string.Format("{0} <color=green>ON</color>", MMInfo.string14);
				MMInfo.hack14 = false;
				HStrings.blue14 = false;
			}
			else
			{
				HStrings.hstring14 = string.Format("{0} <color=red>OFF</color>", MMInfo.string14);
				MMInfo.hack14 = true;
				HStrings.blue14 = true;
			}
			if (MMInfo.hack15)
			{
				HStrings.hstring15 = string.Format("{0} <color=green>ON</color>", MMInfo.string15);
				MMInfo.hack15 = false;
				HStrings.blue15 = false;
				return;
			}
			HStrings.hstring15 = string.Format("{0} <color=red>OFF</color>", MMInfo.string15);
			MMInfo.hack15 = true;
			HStrings.blue15 = true;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002078 File Offset: 0x00000278
		public DatGUI()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		public static void ClassSpawner(int x, string s)
		{
			GUI.Button(new Rect(0f, (float)x * 50f, 200f, 45f), s);
		}
	}


