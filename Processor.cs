using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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