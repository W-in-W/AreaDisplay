using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaDisplay.MapServices;

namespace AreaDisplay
{
    public partial class Form1 : Form
    {
        private MapService mapService;
        private FileDialog fileDialog = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddressTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите адрес для поиска");
            }
            else if (fileDialog.FileName == string.Empty)
            {
                MessageBox.Show("Выберите имя файла для сохранения точек");
            }
            else
            {
                if(mapService.SavePoints(AddressTextBox.Text, Convert.ToInt32(everyNPointBox.Value), fileDialog.FileName))
                    MessageBox.Show("Точки сохранены");
            }

        }
        
        private void ChooseDirectoryBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void servicesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                mapService = servicesComboBox.Text switch
                {
                    "Nominatim" => new Nominatim(),
                    _ => throw new ArgumentException("Выбран неопознанный сервис")
                };
                mapService.InitializeClient();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}