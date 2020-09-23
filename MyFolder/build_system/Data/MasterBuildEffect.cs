using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBuildEffectParam : CsvDataParam
{
    public int build_effect_id { get; set; }
    public int build_id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public int add_city { get; set; }
}

public class MasterBuildEffect : CsvData<MasterBuildEffectParam>
{
}
