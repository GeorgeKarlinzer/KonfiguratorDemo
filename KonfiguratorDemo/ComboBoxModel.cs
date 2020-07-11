using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonfiguratorDemo
{
    class ComboBoxModel
    {
        public ComboBoxModel(ComboBox box)
        {
            box.Items.AddRange(GetElements());
        }
        /// <summary>
        /// Возвращает items из базы данных.
        /// </summary>
        private string[] GetElements()
        {
            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT title FROM models", dB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string[] items = new string[table.Rows.Count];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = table.Rows[i].ItemArray[0].ToString();
            }
            
            adapter.Dispose();
            
            return items;
        }
    }
}
