using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBuildParam : CsvDataParam
{
    public int build_id { get; set; }
    public int state { get; set; }
}

public class DataBuild : CsvData<DataBuildParam>
{
}
