using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TbsFramework.Units;
using TbsFramework.Cells;
using UnityEngine.UI;
using UnityEngine;

namespace TbsFramework.Example1
//ファイル名
{
    public class Duble : MyUnit
    //MyUnitが親、Acherが子クラス
    {
        protected override int Defend(Unit other, int damage)
        // protected override　はMyUnit親クラスの修飾子名。
        //親クラスとアクセス修飾子・修飾子をそろえる必要がある。
        {
            var realDamage = damage;
            // if (other is Paladin)
            //    realDamage *= 2;//Paladin deals double damage to archer.

            return realDamage - DefenceFactor;

        }



        private void Start()
        {

        }
    }

}