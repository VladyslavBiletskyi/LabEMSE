using System.Collections.Generic;
using System.Windows.Forms;
using EmSELab1.DTOs;

namespace EmSELab1
{
    public partial class DataGridForm : Form
    {
        public DataGridForm(IEnumerable<InputDataDto> data)
        {
            InitializeComponent();
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
        }
    }
}
