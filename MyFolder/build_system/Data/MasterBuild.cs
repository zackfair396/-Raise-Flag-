using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBuildParam : CsvDataParam
{
    public int build_id { get; set; }
    public string name { get; set; }

    public int gold { get; set; }
    public int token { get; set; }

    public int pre_build_id_1 { get; set; }
    public int pre_build_id_2 { get; set; }
}

public class MasterBuild : CsvData<MasterBuildParam>
{
}
