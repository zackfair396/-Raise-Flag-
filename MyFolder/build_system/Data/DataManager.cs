using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public bool Initialized = false;
    public TextAsset m_taMasterBuild;
    public TextAsset m_taMasterBuildEffect;

    public MasterBuild master_build = new MasterBuild();
    public MasterBuildEffect master_build_effect = new MasterBuildEffect();

    public DataBuild data_build = new DataBuild();
    // Start is called before the first frame update
    void Start()
    {
        master_build.Load(m_taMasterBuild);
        master_build_effect.Load(m_taMasterBuildEffect);

        // デフォルト設定
        foreach( MasterBuildParam master_build_param in master_build.list)
        {
            if( master_build_param.pre_build_id_1 == 0)
            {
                DataBuildParam add = new DataBuildParam();
                add.build_id = master_build_param.build_id;
                add.state = 1;
                data_build.list.Add(add);
            }
        }

        Initialized = true;
    }

}
