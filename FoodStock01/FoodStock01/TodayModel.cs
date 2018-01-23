using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FoodStock01
{
    [Table("Today")]//テーブル名を指定
    public class TodayModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public string date { get; set; } //今日の日付

        /******************* 今日の日付とってくる ***************************************************/
        public static string SelectToday()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    /**********試し*************/
                    List<TodayModel> SetList = db.Query<TodayModel>("SELECT strftime('%Y-%m-%d', CURRENT_DATE) AS date");

                    string[] SetArray = new string[1];

                    string alert = "";

                    int i = 0;

                    foreach (TodayModel stm in SetList)
                    {
                        //SetArray[i++] = stm.Set_alert;
                        SetArray[i] = stm.date;
                        i++;
                    }

                    alert = SetArray[0];

                    //データベースに指定したSQLを発行
                    return alert;

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }
    }

}
