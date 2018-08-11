using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HS : MonoBehaviour {
	public static float timenow;
	public static float maxtime;
	public static float menusize;
	public static float uptime;
	public static bool config;
	public static int showkeytimer;
	public static int stylelength;
	public static bool mmk;
	public static bool nottouched;
	public static bool iglink;
	public static int igtimer;
	public static bool ytlink;
	public static float menualpha;
	public static int yttimer;
	public static bool  invisble;
	public static bool  clipdrag;
	public static bool  showkeys;
	public static bool  keyinput;
	public static bool  tripletap;
	public static bool  noconkey;
	public static bool newkey;
	public static string save;
	public static string keytype;
	public static string keytip;
	public static string currentkey;
	public static bool mk2;
	public static string reset;
	public static string configtitle;
	public static bool keycon;
	public static bool keycontap;
	public static bool normalcon;
	public static bool normalcontap;
	public static string openk;
	public static string selectk;
	public static string upk;
	public static string downk;
	public static string rightk;
	public static bool presskey;
	public static string leftk;
	public static string configk;
	public static KeyCode openkey;
	public static KeyCode selectkey;
	public static KeyCode upkey;
	public static KeyCode downkey;
	public static KeyCode rightkey;
	public static KeyCode leftkey;
	public static KeyCode configkey;

	public static void ShowConfigMenu() {

		config = true;

	}
	public static Color menuopenb;
	public static Color menucloseb;
	public static Color menunormalc;
	public static Color menuoffc;
	public static Color menunormaltc;
	public static Color menuofftc;
	public static Color togglesonb;
	public static Color togglescloseb;
	public static bool nice;
	public static int xx;
	public static bool you;
	public static Color togglesontc;
	public static Color togglesclosetc;
	public static Color togglesonc;
	public static Color togglesoffc;
	public static Color boxc;
	public static Color boxb;
	public static float boxx;
	public static FontStyle menufs;
	public static FontStyle boxfs;
	public static FontStyle toggfs;
	public static Color boxtc;
	public static string hs1;
	public static string hs2;
	public static string hs3;
	public static string hs4;
	public static string hs5;
	public static string hs6;
	public static string hs7;
	public static string hs8;
	public static string hs9;
	public static string hs10;
	public static string hs11;
	public static string hs12;
	public static string hs13;
	public static string hs14;
	public static string hs15;
	public static string hs16;
	public static string hs17;
	public static string hs18;
	public static string hs19;
	public static string hs20;
	public static float t;
	public static float v;
	public static int index;
	public static int savetimer;
	public static int resettimer;
	public static float b;
	public static float x;
	public static float alpha;
	public static float xval;
	public static float w;
	public static float yy;
	public static Rect border;
	public static bool blueu1;
	public static bool blueu2;
	public static bool lol;
	public  static float bx;
	public  static float tx;
	public static bool blue;
	public static void showmenu() {
		HS.ShowHide = !HS.ShowHide;
		HS.Textx = !HS.Textx;

	}
	public static int inputtype;
	public static void hack1() {
		MMInfo.hack1 = !MMInfo.hack1;
		HS.blue = !HS.blue;

	}
	public static void hack2() { MMInfo.hack2 = !MMInfo.hack2;
		HS.blue2 = !HS.blue2; }

	public static void hack3() { MMInfo.hack3 = !MMInfo.hack3;
		HS.blue3 = !HS.blue3; }
	public static void hack4() { MMInfo.hack4 = !MMInfo.hack4;
		HS.blue4 = !HS.blue4; }
	public static void hack5() { MMInfo.hack5 = !MMInfo.hack5;
		HS.blue5 = !HS.blue5; }
	public static void hack6() {
		MMInfo.hack6 = !MMInfo.hack6;
		HS.blue6 = !HS.blue6;

	}
	public static void openurl1() { Application.OpenURL (url1);
		HS.blueu1 = !HS.blueu1;
		ig = true;
	}
	public static void hack7() { MMInfo.hack7 = !MMInfo.hack7;
		HS.blue7 = !HS.blue7; }

	public static void hack8() { MMInfo.hack8 = !MMInfo.hack8;
		HS.blue8 = !HS.blue8; }
	public static void hack10() { MMInfo.hack10 = !MMInfo.hack10;
		HS.blue10 = !HS.blue10; }
	public static void hack9() { MMInfo.hack9 = !MMInfo.hack9;
		HS.blue9 = !HS.blue9; }
	public static void openurl2() {
		Application.OpenURL (url2);

		you = true;
	}
	public static void hack11() { MMInfo.hack11 = !MMInfo.hack11;
		HS.blue11 = !HS.blue11; }
	public static void hack12() { MMInfo.hack12 = !MMInfo.hack12;
		HS.blue12 = !HS.blue12; }
	public static void hack13() { MMInfo.hack13 = !MMInfo.hack13;
		HS.blue13 = !HS.blue13; }
	public static void hack14() { MMInfo.hack14 = !MMInfo.hack14;
		HS.blue14 = !HS.blue14; }
	public static void hack15() { MMInfo.hack15 = !MMInfo.hack15;
		HS.blue15 = !HS.blue15; }
	public static void hack16() { MMInfo.hack16 = !MMInfo.hack16;
		HS.blue16 = !HS.blue16; }
	public static void hack17() { MMInfo.hack17 = !MMInfo.hack17;
		HS.blue17 = !HS.blue17; }
	public static void hack18() { MMInfo.hack18 = !MMInfo.hack18;
		HS.blue18 = !HS.blue18; }
	public static void hack19() { MMInfo.hack19 = !MMInfo.hack19;
		HS.blue19 = !HS.blue19; }
	public static void hack20() { MMInfo.hack20 = !MMInfo.hack20;
		HS.blue20 = !HS.blue20; }
	public static bool blue2;
	public static bool blue3;
	public static bool blue4;
	public static bool blue5;
	public static bool blue6;
	public static string Thanks2;
	public static bool blue7;
	public static bool blue8;
	public static int Stylenum;
	public static bool blue9;
	public static bool blue10;
	public static bool blue11;
	public static bool blue12;
	public static bool blue13;
	public static bool blue14;
	public static bool blue15;
	public static bool blue16;
	public static bool blue17;
	public static bool blue18;
	public static bool blue19;
	public static bool blue20;
	public static string openc;
	public static string closec;
	public static float keyDelay;
	public static bool Textx;
	public static bool ShowHide = false;

	public static bool testss;
	public static string url1 = "https://iosgods.com";
	public static string url2 = "https://iosgg.com";
	public static string io;
	public static string yt;
	public static string Thanks;
	public static bool ig;
	public static float timepassed;
	public static int timeheld= 0;
	public static int  held = 0;
	public static bool showHide;
	public static float OpenX;
	public static float OpenY;
	public static float MenuX;
	public static float MenuY;

	public static Vector2 currentDrag1 = new Vector2();
	public static Vector2 currentDrag2 = new Vector2();

   

	public Vector2 scrollPosition = Vector2.zero;

	public float height = Screen.height;
	public float width = Screen.width;

	public static bool IntToBool(int x) {
		
		if (x == 0) {
			return false;
		}
		else{
			return true;
		}
	}

}
