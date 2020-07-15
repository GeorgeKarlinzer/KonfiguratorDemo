using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonfiguratorDemo
{
    static class SecondaryComboBoxesSystem
    {
        static public Dictionary<string, Panel> secondaryPanels;

        static public void SetSecondaryBoxes(string selectedModel)
        {
            SecondaryBoxesLocationSystem.NewModel();

            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `models` WHERE `title` = \"" + selectedModel + "\"", dB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table); 

            for (int i = 0; i < table.Columns.Count; i++)
            {
                string indexes = table.Rows[0].ItemArray[i].ToString();// 1,2,3
                string columnName = table.Columns[i].ColumnName; // colors
                if (secondaryPanels.ContainsKey(columnName))
                    if (indexes.Length != 0)
                    {
                        SecondaryBoxesLocationSystem.SetLocation(secondaryPanels[columnName]);

                        secondaryPanels[columnName].Visible = true;

                        ComboBox box = (ComboBox)secondaryPanels[columnName].Controls[1];

                        DataTable table1 = new DataTable();
                        command = new MySqlCommand(String.Format("SELECT `title` FROM `{0}` WHERE `id` in ({1})", columnName, indexes), dB.GetConnection());

                        adapter.SelectCommand = command;
                        adapter.Fill(table1);

                        string[] items = new string[table1.Rows.Count];
                        for (int j = 0; j < table1.Rows.Count; j++)
                        {
                            items[j] = table1.Rows[j].ItemArray[0].ToString();
                        }

                        box.Items.Clear();
                        box.Items.AddRange(items);
                    }
                    else
                    {
                        secondaryPanels[columnName].Visible = false;
                    }
            }

            adapter.Dispose();
        }
    }
}
