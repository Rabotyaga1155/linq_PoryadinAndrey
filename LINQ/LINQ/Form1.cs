using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        public struct a
        {
            public string f;
            public string i;
            public string o;
            public float age;
            public float ves;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a str;
            StreamReader FileInt = new StreamReader("text.txt");
            string line;
            Hashtable ludi = new Hashtable();
            string a;
            while ((line = FileInt.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                str.f = temp[0];
                str.i = temp[1];
                str.o = temp[2];
                str.age = float.Parse(temp[3]);
                str.ves = float.Parse(temp[4]);
                if (str.age < 40)
                {
                    MessageBox.Show($"{str.f}  \t  {str.i}  \t  {str.o}  \t  {str.age}  \t  {str.ves}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a str;
            StreamReader FileInt = new StreamReader("text.txt");
            string line;
            Hashtable ludi = new Hashtable();
            string a;
            while ((line = FileInt.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                str.f = temp[0];
                str.i = temp[1];
                str.o = temp[2];
                str.age = float.Parse(temp[3]);
                str.ves = float.Parse(temp[4]);
                if (str.age > 40)
                {
                    //label1.Text = ($"{str.f}  \t  {str.i}  \t  {str.o}  \t  {str.age}  \t  {str.ves}");
                    MessageBox.Show($"{str.f}  \t  {str.i}  \t  {str.o}  \t  {str.age}  \t  {str.ves}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<Employ> employes = new List<Employ>()
            {
            new Employ {Name="Иванов", Departament="Отдел закупок"},
            new Employ {Name="Петров", Departament="Отдел закупок"},
            new Employ {Name="Сидоров", Departament="Отдел продаж"},
            new Employ {Name="Лямин", Departament="Отдел продаж"},
            new Employ {Name="Сидоренко", Departament="Отдел маркетинга"},
            new Employ {Name="Кривоносов", Departament="Отдел продаж"}
            };

            List<Departament> department = new List<Departament>()
            {
            new Departament {Name = "Отдел закупок", Reg="Германия"},
            new Departament {Name = "Отдел продаж", Reg="Испания"},
            new Departament {Name = "Отдел маркетинга", Reg="Испания"}
            };

            var result = from a in employes
                         join t in department on a.Departament equals t.Name
                         select new { Name = a.Name, Department = a.Departament, Reg = t.Reg };
            foreach (var mb in result)
            {
                
                label1.Text = ($"{mb.Name}-{mb.Department} ({mb.Reg}) \n" + label1.Text);
            }











            //List<Departament> department = new List<Departament>()
            //{
            //    new Departament { Name = "Отдел закупок", Reg ="Германия" },
            //    new Departament { Name = "Отдел продаж", Reg ="Испания" },
            //    new Departament { Name = "Отдел маркетинга", Reg ="Россия" }
            //};
            //List<Employ> employes = new List<Employ>()
            //{
            //        new Employ {Name="Иванов", Departament ="Отдел закупок"},
            //        new Employ {Name="Петров", Departament ="Отдел закупок"},
            //        new Employ {Name="Сидоров", Departament ="Отдел продаж"},
            //        new Employ {Name="Лямин", Departament ="Отдел продаж "},
            //        new Employ {Name="Сидоренко", Departament ="Отдел маркетинга"},
            //        new Employ {Name="Кривоносов", Departament ="Отдел продаж "}
            //};
            //var result = from a in employes
            //             join t in department on a.Departament equals t.Name
            //             select new { Name = a.Name, Departament = a.Departament, Reg = t.Reg };
            //foreach (var mb in result)
            //{
            //    //MessageBox.Show($"{mb.Name} - {mb.Departament} ({mb.Reg}) \n" + label1.Text);
            //    label1.Text = ($"{mb.Name} - {mb.Departament} ({mb.Reg}) \n" + label1.Text);

            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show($"{item.Name} - {item.Dep} ({item.Reg})");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Employ> employes = new List<Employ>()
            {
            new Employ {Name="Иванов", Departament="Отдел закупок"},
            new Employ {Name="Петров", Departament="Отдел закупок"},
            new Employ {Name="Сидоров", Departament="Отдел продаж"},
            new Employ {Name="Лямин", Departament="Отдел продаж"},
            new Employ {Name="Сидоренко", Departament="Отдел маркетинга"},
            new Employ {Name="Кривоносов", Departament="Отдел продаж"}
            };

            List<Departament> department = new List<Departament>()
            {
            new Departament {Name = "Отдел закупок", Reg="Германия"},
            new Departament {Name = "Отдел продаж", Reg="Испания"},
            new Departament {Name = "Отдел маркетинга", Reg="Испания"}
            };

            var result = from a in employes
                         join t in department on a.Departament equals t.Name
                         select new { Name = a.Name, Department = a.Departament, Reg = t.Reg };
            foreach (var mb in result)
            {
                if (mb.Reg.StartsWith("И"))
                    label2.Text = ($"{mb.Name}-{mb.Department} ({mb.Reg}) \n" + label2.Text);
            }
            
        }
    }
}
