using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          
            
                string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
                var xmldoc = new XmlDocument();
                xmldoc.Load(bugun);
                DateTime Tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string USD = xmldoc.SelectSingleNode("//Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                label5.Text = String.Format("Tarih {0} USD; {1}", Tarih.ToShortDateString(), USD);


            string EURO = xmldoc.SelectSingleNode("//Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            label6.Text = String.Format("Tarih {0} EURO; {1}", Tarih.ToShortDateString(), EURO);

            string İNGİLİZ_STERLİNİ = xmldoc.SelectSingleNode("//Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            label7.Text = String.Format("Tarih {0} İNGİLİZ_STERLİNİ; {1}", Tarih.ToShortDateString(), İNGİLİZ_STERLİNİ);


            string SWISS_FRANK = xmldoc.SelectSingleNode("//Currency[@Kod='CHF']/BanknoteSelling").InnerXml;
            label8.Text = String.Format("Tarih {0} SWISS_FRANK; {1}", Tarih.ToShortDateString(), SWISS_FRANK);
        }
    }
}
