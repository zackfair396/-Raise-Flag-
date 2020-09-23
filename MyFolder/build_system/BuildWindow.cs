using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWindow : MonoBehaviour
{
    public DataManager data_manager;
    // Start is called before the first frame update

    public IconBuildItem[] icon_build_item_arr;

    IEnumerator Start()
    {
        while(data_manager.Initialized != true)
        {
            yield return null;
        }

        icon_build_item_arr = GetComponentsInChildren<IconBuildItem>();

        foreach( IconBuildItem icon in icon_build_item_arr)
        {
            MasterBuildParam master = data_manager.master_build.list.Find(p => p.build_id == icon.m_iBuildId);
            DataBuildParam data = data_manager.data_build.list.Find(p => p.build_id == icon.m_iBuildId);
            icon.Initialize(master, data);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
