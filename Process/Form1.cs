using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var processor = new Processor
                    {
                        Name = txtName.Text,
                        Manufacturer = txtManufacturer.Text,
                        Model = txtModel.Text,
                        Country = txtCountry.Text,
                        Year = int.Parse(txtYear.Text),
                        TechProcess = txtTechProcess.Text,
                        Frequency = double.Parse(txtFrequency.Text),
                        CacheL3 = double.Parse(txtCacheL3.Text),
                        Cores = int.Parse(txtCores.Text),
                        Slot = txtSlot.Text,
                        ProductionDate = dtpProductionDate.Value,
                        WarrantyPeriod = int.Parse(txtWarrantyPeriod.Text),
                        Price = decimal.Parse(txtPrice.Text),
                        Points = int.Parse(txtPoints.Text),
                        IsOnSale = chkIsOnSale.Checked
                    };

                    //string json = JsonConvert.SerializeObject(processor);
                    //File.WriteAllText(saveFileDialog.FileName, json);
                    toolStrip1.Text = "Данные сохранены!";

                }
            }
        }

        private void btnLoad_Click_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                /*if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    //var Processor = JsonConvert.DeserializeObject<Processor>(json);
                    
                    var processor = JsonConvert.DeserializeObject<Processor>(json);

                    txtName.Text = processor.Name;
                    txtManufacturer.Text = processor.Manufacturer;
                    txtModel.Text = processor.Model;
                    txtCountry.Text = processor.Country;
                    txtYear.Text = processor.Year.ToString();
                    txtTechProcess.Text = processor.TechProcess;
                    txtFrequency.Text = processor.Frequency.ToString();
                    txtCacheL3.Text = processor.CacheL3.ToString();
                    txtCores.Text = processor.Cores.ToString();
                    txtSlot.Text = processor.Slot;
                    dtpProductionDate.Value = processor.ProductionDate;
                    txtWarrantyPeriod.Text = processor.WarrantyPeriod.ToString();
                    txtPrice.Text = processor.Price.ToString();
                    txtPoints.Text = processor.Points.ToString();
                    chkIsOnSale.Checked = processor.IsOnSale;

                    toolStrip1.Text = "Данные загружены!";
                }*/
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form2 About = new Form2();
            About.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form2 About = new Form2();
            About.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

public class Processor
{
    public int Id { get; set; }                  //id
    public string Name { get; set; }             //название
    public string Manufacturer { get; set; }     //производитель
    public string Model { get; set; }            //модель
    public string Country { get; set; }          //страна
    public int Year { get; set; }                //год
    public string TechProcess { get; set; }      //Техпроцесс
    public double Frequency { get; set; }        //Частота
    public double CacheL3 { get; set; }          //Кеш-память L3
    public int Cores { get; set; }               //Ядра
    public string Slot { get; set; }             //Слот
    public DateTime ProductionDate { get; set; } //дата производства
    public int WarrantyPeriod { get; set; }      //гарантийный срок
    public decimal Price { get; set; }           //цена
    public int Points { get; set; }              //баллы
    public bool IsOnSale { get; set; }           //акции
}
