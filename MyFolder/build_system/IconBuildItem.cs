using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBuildItem : MonoBehaviour
{
	public int m_iBuildId;

	public Button m_btn;
	public Image m_imgIcon;

	public GameObject m_goRootHas;
	public GameObject m_goRootBuy;

	public Text m_txtName;
	public Text m_txtNameBuy;

	public Text m_txtGold;
	public Text m_txtGoldBuy;

	public GameObject m_goRootToken;
	public GameObject m_goRootTokenBuy;
	public Text m_txtToken;
	public Text m_txtTokenBuy;

	public void Initialize(MasterBuildParam _master , DataBuildParam _data)
	{
		m_txtName.text = _master.name;
		m_txtNameBuy.text = _master.name;

		m_txtGold.text = _master.gold.ToString();
		m_txtGoldBuy.text = _master.gold.ToString();
		m_txtToken.text = _master.token.ToString();
		m_txtTokenBuy.text = _master.token.ToString();

		bool bHas = false;
		if( _data != null && 0 < _data.state)
		{
			bHas = true;
		}
		m_goRootHas.SetActive(bHas);
		m_goRootBuy.SetActive(!bHas);
		m_imgIcon.color = bHas ? Color.white : Color.gray;

		bool bIsToken = false;
		if( 0 < _master.token)
		{
			bIsToken = true;
		}
		m_goRootToken.SetActive(bIsToken);
		m_goRootTokenBuy.SetActive(bIsToken);

	}
}






