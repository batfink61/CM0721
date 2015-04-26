using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderMgt
{
    public partial class BuildingOptionsSelectForm : Form
    {
        private String _buildingType="";

        private String _selectedOption="";
        private String _selectedId = "";
        private Decimal _selectedPrice = 0;

        public BuildingOptionsSelectForm()
        {
            InitializeComponent();
        }

        public String BuildingType
        {
            set
            {
                _buildingType = value;
            }
        }

        public String SelectedId
        {
            get { return _selectedId; }
        }

        public String SelectedOption
        {
            get { return _selectedOption; }
        }

        public Decimal SelectedPrice
        {
            get { return _selectedPrice; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _selectedOption="";
            _selectedId = "";
            _selectedPrice = 0;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildingOptionsSelectForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BuildingGateway.Options(_buildingType);
            vwOptions.DataSource = ds.Tables[0];
        }

        private void vwOptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedId = vwOptions.SelectedRows[0].Cells["id"].Value.ToString();
            _selectedOption = vwOptions.SelectedRows[0].Cells["option"].Value.ToString();
            _selectedPrice = Decimal.Parse(vwOptions.SelectedRows[0].Cells["price"].Value.ToString());
        }
    }
}
