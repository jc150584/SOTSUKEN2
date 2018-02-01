using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FoodStock01
{
    [Table("Stock")]//テーブル名を指定
    public class StockFoodModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int S_no { get; set; } //保存食材No

        public string S_name { get; set; } //保存食材名

        public int S_num { get; set; } //数量

        public string S_unit { get; set; } //単位

        /********************インサートメソッド**********************/
        public static void InsertStock(int s_no, string s_name, int s_num, string s_unit)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにStockテーブルを作成する
                    db.CreateTable<StockFoodModel>();

                    db.Insert(new StockFoodModel() { S_no = s_no, S_name = s_name, S_num = s_num, S_unit = s_unit });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /*******************セレクトメソッド**************************************/
        public static List<StockFoodModel> SelectStock()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    return db.Query<StockFoodModel>("SELECT * FROM [Stock] ORDER BY [S_num]");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        /********************デリートメソッド*************************************/
        public static void DeleteStock(int s_no)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<StockFoodModel>();

                    db.Delete<StockFoodModel>(s_no);//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************アップデートメソッド**************************************/
        public static void UpdateStockPlus02(int s_no, string s_name, int s_num, string s_unit)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<StockFoodModel>();

                    db.Update(new StockFoodModel() { S_no = s_no, S_name = s_name, S_num = s_num + 1, S_unit = s_unit });

                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************アップデートメソッド（マイナス）**************************************/
        public static void UpdateStockMinus(int s_no, string s_name, int s_num, string s_unit)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<StockFoodModel>();

                    db.Update(new StockFoodModel() { S_no = s_no, S_name = s_name, S_num = s_num - 1, S_unit = s_unit });

                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
    }
}