using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Declaration : MonoBehaviour {

	public static void xStart ()
	{
		
		MMInfo.string1 = "t1";
		MMInfo.string2 = "t2";
		MMInfo.string3 = "t3";
		MMInfo.string4 = "t4";
		MMInfo.string5 = "t5";
		MMInfo.string6 = "t6";
		MMInfo.string7 = "t7";
		MMInfo.string8 = "t8";
		MMInfo.string9 = "t9";
		MMInfo.string10 = "t10";
		MMInfo.string11 = "t11";
		MMInfo.string12 = "t12";
		MMInfo.string13 = "t13";
		MMInfo.string14 = "t14";
		MMInfo.string15 = "t15";
		MMInfo.string16 = "t16";
		MMInfo.string17 = "t17";
		MMInfo.string18 = "t18";
		MMInfo.string19 = "t19";
		MMInfo.string20 = "t20";
		MMInfo.opentext = "Mod Menu";
		MMInfo.closetext = "Close";
		MMInfo.Length = 1;
		MMInfo.btnc = 6;
		MMInfo.OpenX = 5;
		MMInfo.OpenY = 5;
		MMInfo.MenuX = 6000;
		MMInfo.MenuY = 60;
	}
	public static void xxStart() {
		if (SystemInfo.deviceType == DeviceType.Desktop) {
			HS.inputtype = 2;
		}
		if (SystemInfo.deviceType == DeviceType.Handheld || SystemInfo.deviceType == DeviceType.Unknown) {
			HS.inputtype = 1;
		}
		if (HS.inputtype == 1) {
			HS.normalcon = true;
			HS.keycon = false;
		}
		else if (HS.inputtype != 1) {
			HS.normalcon = false;
			HS.keycon = true;
		}
		if (PlayerPrefs.HasKey ("OpenKey")) { 
			HS.openk = PlayerPrefs.GetString ("OpenKey");
		} else {
			HS.openk = "A";
		}
		if (PlayerPrefs.HasKey ("SelectKey")) {
			HS.selectk = PlayerPrefs.GetString ("SelectKey");
		} else {
			HS.selectk = "Return";
		}
		if (PlayerPrefs.HasKey ("UpKey")) {
			HS.upk = PlayerPrefs.GetString ("UpKey");
		} else {
			HS.upk = "UpArrow";
		}
		if (PlayerPrefs.HasKey ("DownKey")) {
			HS.downk = PlayerPrefs.GetString ("DownKey");
		} else {
			HS.downk = "DownArrow";
		}
		if (PlayerPrefs.HasKey ("RightKey")) {
			HS.rightk = PlayerPrefs.GetString ("RightKey");
		} else {
			HS.rightk = "RightArrow";
		}
		if (PlayerPrefs.HasKey ("LeftKey")) {
			HS.leftk = PlayerPrefs.GetString ("LeftKey");
		} else {
			HS.leftk = "LeftArrow";
		}
		if (PlayerPrefs.HasKey ("ConfigKey")) {
			HS.configk = PlayerPrefs.GetString ("ConfigKey");
		} else {
			HS.configk = "BackQuote"; 
		}
		if (PlayerPrefs.HasKey ("NoConKey")) {
			HS.noconkey = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("NoConKey"),0,1));
		} else {
			HS.noconkey = false;
		}
		if (PlayerPrefs.HasKey ("Showkeys")) {
			HS.showkeys = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("Showkeys"),0,1));
		} else {
			HS.showkeys = false;
		}
		if (PlayerPrefs.HasKey ("Invisible")) {
			HS.invisble = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("Invisible"),0,1));
		} else {
			HS.invisble = false;
		}
		if (PlayerPrefs.HasKey ("ClipDrag")) {
			HS.clipdrag = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("ClipDrag"),0,1));
		} else {
			HS.clipdrag = false;
		}
		if (PlayerPrefs.HasKey ("TripleTap")) {
			HS.tripletap = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("TripleTap"),0,1));
		} else {
			HS.tripletap = false;
		}

		if (PlayerPrefs.HasKey ("KeyInput")) {
			HS.keyinput = HS.IntToBool (Mathf.Clamp(PlayerPrefs.GetInt ("KeyInput"),0,1));
		} else {
			HS.keyinput = false;
		}
		if (PlayerPrefs.HasKey ("Length")) {
			HS.stylelength = Mathf.Clamp (PlayerPrefs.GetInt ("Length"), 1, 2);
		} else {
			HS.stylelength = Mathf.Clamp (MMInfo.Length, 1, 2);
		}
		if (PlayerPrefs.HasKey ("Style")) {
			HS.Stylenum = Mathf.Clamp (PlayerPrefs.GetInt ("Style"), 1, 6);
		} else {
			HS.Stylenum = 1;
		}
		if (PlayerPrefs.HasKey ("MenuSize")) {
			HS.menusize = Mathf.Clamp (PlayerPrefs.GetFloat ("MenuSize"), 10f, 50f);
		} else {
			HS.menusize = 20f;
		}
		if (PlayerPrefs.HasKey ("OpenPosx")) {
			HS.OpenX = Mathf.Clamp (PlayerPrefs.GetFloat ("OpenPosx"), .25f * HS.menusize, Screen.height - (6.75f * HS.menusize));
		} else {
			HS.OpenX = Mathf.Clamp(MMInfo.OpenX,(0.25f * HS.menusize), Screen.height - (6.75f * HS.menusize)); 
		}
		if (PlayerPrefs.HasKey ("OpenPosy")) {
			HS.OpenY = Mathf.Clamp(PlayerPrefs.GetFloat ("OpenPosy"),.25f*HS.menusize, Screen.width - (6.75f*HS.menusize));
		} else {
			HS.OpenY = Mathf.Clamp(MMInfo.OpenY,(0.25f*HS.menusize), Screen.width - (6.75f*HS.menusize));
		}
		if (PlayerPrefs.HasKey ("MenuPosx")) {
			HS.MenuX = Mathf.Clamp (PlayerPrefs.GetFloat ("MenuPosx"), (0.25f * HS.menusize), Screen.width - (9.5f * HS.stylelength * HS.menusize) - (.25f * HS.menusize));
		} else {
			HS.MenuX = Mathf.Clamp(MMInfo.MenuX, (0.25f * HS.menusize), (Screen.width - (9.5f * HS.stylelength * HS.menusize)) - (.25f * HS.menusize));
		}
		if (PlayerPrefs.HasKey ("MenuPosy")) {
			HS.MenuY = Mathf.Clamp(PlayerPrefs.GetFloat ("MenuPosy"),(0.25f * HS.menusize), (Screen.height - (MMInfo.btnc * (.25f*HS.menusize) +  (2f * HS.menusize) + MMInfo.btnc * (1.75f*HS.menusize))) -  (.25f * HS.menusize));
				
		} else {
			HS.MenuY = Mathf.Clamp(MMInfo.MenuY,(0.25f * HS.menusize), (Screen.height - (MMInfo.btnc * (.25f*HS.menusize) +  (2f * HS.menusize) + MMInfo.btnc * (1.75f*HS.menusize))) -  (.25f * HS.menusize));
		}
		if (PlayerPrefs.HasKey ("Alpha")) {
			HS.alpha = Mathf.Clamp (PlayerPrefs.GetFloat ("Alpha"), 0f, 1f);
		} else {
			HS.alpha = 1f;
		}

		HS.openkey = (KeyCode)System.Enum.Parse(typeof(KeyCode), HS.openk);
		HS.selectkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.selectk);
		HS.upkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.upk);
		HS.downkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.downk);
		HS.rightkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.rightk); 
		HS.leftkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.leftk);
		HS.configkey = (KeyCode)System.Enum.Parse (typeof(KeyCode), HS.configk);
		HS.x = 0;
		HS.xval = 0;
		HS.index = 1;
		MMInfo.Oi ();
		MMInfo.Oi2 ();
		HS.timenow = 0;
		HS.maxtime = 0.5f;
		HS.uptime = 0;
		HS.savetimer = 0;
		HS.showkeytimer = 0;
		HS.resettimer = 0;
		HS.mmk = false;
	}
}
