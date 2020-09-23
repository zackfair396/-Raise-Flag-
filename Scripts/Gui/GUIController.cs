using System;
using TbsFramework.Grid;
using TbsFramework.Grid.GridStates;
using TbsFramework.Players;
using TbsFramework.Units;
using UnityEngine;
using UnityEngine.UI;


namespace TbsFramework.Gui
{
    public class GUIController : MonoBehaviour
    {
        public CellGrid CellGrid;

        public GameObject Win;
        public GameObject Lose;
        public GameObject Result;

        public Text InfoText;
        public Text AlliesHp_Object;
        public Text AlliseAttack_Object;
        public Text AlliceDefence_Object;

        public Text EnemyHp_Object;
        public Text EnemyAttack_Object;
        public Text EnemyDefence_Object;
           
        



        //メソッドの宣言

        void Awake()
        {
            Debug.Log(CellGrid);
            if(CellGrid == null)
            {
                CellGrid = GameObject.FindObjectOfType<CellGrid>();
            }
            CellGrid.LevelLoading += onLevelLoading;
            CellGrid.LevelLoadingDone += onLevelLoadingDone;
            CellGrid.TurnEnded += CellGrid_TurnEnded;
            CellGrid.GameEnded += CellGrid_GameEnded;
            CellGrid.UnitAdded += OnUnitAdded;

            //おそらく宣言して代入
        }

        private void CellGrid_GameEnded(object sender, EventArgs e)
        {
            Debug.Log("ゲーム終了2");

            InfoText.text = "Player " + ((sender as CellGrid).CurrentPlayerNumber + 1) + " wins!";

            if (Result != null)
            {
                Result.SetActive(true);

                if ((sender as CellGrid).CurrentPlayerNumber == 0)
                {
                    if (Win != null)
                    {
                        Win.SetActive(true);
                    }
                    else
                    {
                        Win.SetActive(false);
                    }
                    
                }
                else
                {
                    if (Lose != null)
                    {
                        Lose.SetActive(true);
                    }
                    else
                    {
                        Lose.SetActive(false);
                    }
                }
            }
            else
            {
                Result.SetActive(false);
            }

        }

        private void CellGrid_TurnEnded(object sender, EventArgs e)
        {
            Debug.Log("ターン終了");
        }

        private void onLevelLoading(object sender, EventArgs e)
        {
            Debug.Log("Level is loading");
        }

        private void onLevelLoadingDone(object sender, EventArgs e)
        {
            Debug.Log("Level loading done");
            Debug.Log("Press 'n' to end turn");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.N) && !(CellGrid.CellGridState is CellGridStateAiTurn))
            {
                CellGrid.EndTurn();//User ends his turn by pressing "n" on keyboard.
            }
        }

        private void OnUnitAdded(object sender, UnitCreatedEventArgs e)
        {
            RegisterUnit(e.unit);
        }
        private void RegisterUnit(Transform unit)
        {
            unit.GetComponent<Unit>().UnitHighlighted += OnUnitHighlighted;
            unit.GetComponent<Unit>().UnitDehighlighted += OnUnitDehighlighted;
            unit.GetComponent<Unit>().UnitAttacked += OnUnitAttacked;
        }
        private void OnUnitHighlighted(object sender, EventArgs e)
        {
            var attack = (sender as Unit).AttackFactor;
            var defence = (sender as Unit).DefenceFactor;
            var range = (sender as Unit).AttackRange;

            float hpScale = (float)((float)(sender as Unit).HitPoints / (float)(sender as Unit).TotalHitPoints);

            Debug.Log((sender as Unit).HitPoints);
            Debug.Log(CellGrid.CurrentPlayerNumber);
            if ((sender as Unit).PlayerNumber == 0)
            {

            
            
               

                if (AlliesHp_Object != null)
                {
                    this.AlliesHp_Object.GetComponent<Text>().text = "HP" + (sender as Unit).HitPoints.ToString();

                    // Text AlliesHp = AlliesHp_Object.GetComponent<Text>();

                    //  AlliesHp = (sender as Unit).HitPoints.ToString();

                }

                if (AlliseAttack_Object != null)
                {
                    this.AlliseAttack_Object.GetComponent<Text>().text = "攻撃力" + (sender as Unit).AttackFactor.ToString();
                }

                if (AlliceDefence_Object != null)
                {
                    this.AlliceDefence_Object.GetComponent<Text>().text = "防御力" + (sender as Unit).DefenceFactor.ToString();

                }
            
                
                
            }
            else
            {
               

                if(EnemyHp_Object != null)
                {
                    this.EnemyHp_Object.GetComponent<Text>().text = "HP" + (sender as Unit).HitPoints.ToString();

                }
                if(EnemyAttack_Object != null)
                {
                    this.EnemyAttack_Object.text = "攻撃力" + (sender as Unit).AttackFactor.ToString();
                }
                if(EnemyDefence_Object != null)
                {
                    this.EnemyDefence_Object.text = "防御力" + (sender as Unit).DefenceFactor.ToString();
                }

            }

                

            
           
        }
        private void OnUnitDehighlighted(object sender, EventArgs e)
        {
           
        }
        private void OnUnitAttacked(object sender, AttackEventArgs e)
        {
            if (!(CellGrid.CurrentPlayer is HumanPlayer)) return;

            OnUnitDehighlighted(sender, e);

            if ((sender as Unit).HitPoints <= 0) return;

            OnUnitHighlighted(sender, e);
            Debug.Log("b");
        }
    }
}