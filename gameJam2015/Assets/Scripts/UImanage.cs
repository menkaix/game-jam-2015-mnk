using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UImanage : MonoBehaviour {
	public Camera camera;
	public Image[] img;
	public Item[] itms;
	private static int pivot;
	// Use this for initialization
	void Start () {

		float worldScreenHeight = camera.orthographicSize * 2;
		float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

		transform.GetChild(0).localScale = new Vector3((worldScreenWidth/Resources.Load<Sprite>("caca").bounds.size.x )*0.1f,(worldScreenWidth/Resources.Load<Sprite>("caca").bounds.size.x )*0.1f, 1);
		transform.GetChild(0).position=new Vector3(0,Screen.height,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("u")){
			if(pivot!=0){
				Sprite tmp=img[0].sprite;
				int indTmp=itms[0].indice;
				string nbTmp=img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[0].sprite=img[itms[0].indice].sprite;
				img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=img[itms[0].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[itms[0].indice].sprite=tmp;
				img[itms[0].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=nbTmp;
				itms[pivot].nb=nbTmp;
				itms[0].indice=0;
				itms[pivot].indice=indTmp;
				pivot=0;
			}
		}
		if(Input.GetKeyDown("i")){
			if(pivot!=1){
				Sprite tmp=img[0].sprite;
				int indTmp=itms[1].indice;
				string nbTmp=img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[0].sprite=img[itms[1].indice].sprite;
				img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=img[itms[1].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[itms[1].indice].sprite=tmp;
				img[itms[1].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=nbTmp;
				itms[pivot].nb=nbTmp;
				itms[1].indice=0;
				itms[pivot].indice=indTmp;
				pivot=1;
			}
		}
		if(Input.GetKeyDown("o")){
			if(pivot!=2){
				Sprite tmp=img[0].sprite;
				int indTmp=itms[2].indice;
				string nbTmp=img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[0].sprite=img[itms[2].indice].sprite;
				img[0].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=img[itms[2].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
				img[itms[2].indice].sprite=tmp;
				img[itms[2].indice].transform.GetChild(0).GetChild(0).GetComponent<Text>().text=nbTmp;
				itms[pivot].nb=nbTmp;
				itms[2].indice=0;
				itms[pivot].indice=indTmp;
				pivot=2;
			}
		}
	}
}
