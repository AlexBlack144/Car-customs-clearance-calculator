using System;
using System.Drawing;
using System.Windows.Forms;
namespace HW3CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Text = "Customs clearance of cars";
            this.BackColor = Color.WhiteSmoke;
            // Button CAR
            CAR.Size = new Size(100, 50);
            CAR.Location = new Point(10, 10);
            CAR.Font = new Font("Arial", 11);
            CAR.Text = "CAR";
            CAR.ForeColor = Color.DarkSlateBlue;
            CAR.Image = Image.FromFile($"pics\\1.png");
            CAR.Click += Btn_Click_CAR;
            Controls.Add(CAR);
            // Button MOTO
            MOTO.Size = new Size(100, 50);
            MOTO.Location = new Point(CAR.Location.X+150, CAR.Location.Y);
            MOTO.Font = new Font("Arial", 11);
            MOTO.Text = "MOTO";
            MOTO.ForeColor = Color.DarkSlateBlue;
            MOTO.Image = Image.FromFile($"pics\\2.png");
            MOTO.Click += Btn_Click_MOTO;
            Controls.Add(MOTO);
            // Button TRUCK
            TRUCK.Size = new Size(100, 50);
            TRUCK.Location = new Point(MOTO.Location.X + 150, CAR.Location.Y);
            TRUCK.Font = new Font("Arial", 11);
            TRUCK.Text = "TRUCK";
            TRUCK.ForeColor = Color.DarkSlateBlue;
            TRUCK.Image = Image.FromFile($"pics\\3.png");
            TRUCK.Click += Btn_Click_TRUCK;
            Controls.Add(TRUCK);
            // Button BUS
            BUS.Size = new Size(100, 50);
            BUS.Location = new Point(TRUCK.Location.X + 150, CAR.Location.Y);
            BUS.Font = new Font("Arial", 11);
            BUS.Text = "BUS";
            BUS.ForeColor = Color.DarkSlateBlue;
            BUS.Image = Image.FromFile($"pics\\4.png");
            BUS.Click += Btn_Click_CAR;
            Controls.Add(BUS);

            // TextBox EUR
            EUR.Location = new Point(20, 285);
            EUR.Size = new Size(200, 500);
            EUR.ScrollBars = ScrollBars.Vertical;
            
            // TextBox cm3
            CM.Location = new Point(20, 345);
            CM.Size = new Size(200, 500);
            CM.ScrollBars = ScrollBars.Vertical;
           
            //Label:
            //1
            label_the_cost_of_a_car_abroad.Location = new Point(EUR.Location.X, EUR.Location.Y - 20);
            label_the_cost_of_a_car_abroad.Size = new Size(200, 50);
            label_the_cost_of_a_car_abroad.Font = new Font("Arial", 11);
            label_the_cost_of_a_car_abroad.Text = "The cost of a car abroad";
           
            //2
            label_eur.Location = new Point(EUR.Location.X + 210, EUR.Location.Y);
            label_eur.Size = new Size(50, 50);
            label_eur.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_eur.Text = "EUR";
            
            //3
            label_engine_displacement.Location = new Point(CM.Location.X, CM.Location.Y - 20);
            label_engine_displacement.Size = new Size(200, 50);
            label_engine_displacement.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_engine_displacement.Text = "Engine displacement";
            
            //4
            label_cm.Location = new Point(CM.Location.X + 210, CM.Location.Y);
            label_cm.Size = new Size(50, 50);
            label_cm.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_cm.Text = "см3";
           
            //5
            label_the_age_of_the_car.Location = new Point(label_the_cost_of_a_car_abroad.Location.X, label_the_cost_of_a_car_abroad.Location.Y - 60);
            label_the_age_of_the_car.Size = new Size(200, 20);
            label_the_age_of_the_car.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_the_age_of_the_car.Text = "The age of the car";
            
            //6
            label_country_of_origin.Location = new Point(label_the_age_of_the_car.Location.X, label_the_age_of_the_car.Location.Y - 60);
            label_country_of_origin.Size = new Size(200, 20);
            label_country_of_origin.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_country_of_origin.Text = "Country of origin";
           
            //7
            label_fuel.Location = new Point(label_country_of_origin.Location.X, label_country_of_origin.Location.Y - 60);
            label_fuel.Size = new Size(200, 20);
            label_fuel.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_fuel.Text = "Fuel";

            //8
            label_Import_duty.Location = new Point(label_fuel.Location.X + 350, label_fuel.Location.Y + 20);
            label_Import_duty.Size = new Size(200, 20);
            label_Import_duty.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_Import_duty.Text = "Import duty:";
            

            //9
            label_Excise_duty.Location = new Point(label_Import_duty.Location.X, label_Import_duty.Location.Y + 60);
            label_Excise_duty.Size = new Size(200, 20);
            label_Excise_duty.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_Excise_duty.Text = "Excise duty:";
           
            //10
            label_VAT.Location = new Point(label_Import_duty.Location.X, label_Excise_duty.Location.Y + 60);
            label_VAT.Size = new Size(200, 20);
            label_VAT.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_VAT.Text = "VAT:";
           
            //11
            label_The_cost_of_a_car_with_customs_clearance.Location = new Point(label_Import_duty.Location.X, label_VAT.Location.Y + 60);
            label_The_cost_of_a_car_with_customs_clearance.Size = new Size(400, 20);
            label_The_cost_of_a_car_with_customs_clearance.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_The_cost_of_a_car_with_customs_clearance.Text = "The cost of a car with customs clearance:";

            //11
            label_full_mass.Location = new Point(label_engine_displacement.Location.X, label_engine_displacement.Location.Y + 60);
            label_full_mass.Size = new Size(100, 20);
            label_full_mass.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            label_full_mass.Text = "Full mass:";

            //12
            Documents.Location = new Point(400, 355);
            Documents.Size = new Size(400, 100);
            Documents.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            Documents.Text = "Documents required for customs. design\n\n" +
                "Examples of calculating the cost of customs clearance\n\n" +
                "News on car customs clearance";
            Documents.ForeColor = Color.DarkSlateBlue;

            //13
            line.Location = new Point(300, 100);
            line.Size = new Size(30, 500);
            line.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            line.Text = "|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n";
            line.ForeColor = Color.LightGray;

            //ComboBox age of the car
            the_age_of_the_car.FlatStyle = FlatStyle.Popup;
            the_age_of_the_car.Size = new Size(200, 50);
            the_age_of_the_car.Location = new Point(label_the_cost_of_a_car_abroad.Location.X, label_the_cost_of_a_car_abroad.Location.Y - 40);
            the_age_of_the_car.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            the_age_of_the_car.Items.AddRange(new string[] { "1 year", "2 year", "3 year", "4 year", "5 year", "6 year", "7 year", "8 year", "9 year", "from 10 years", });
           
            //ComboBox country of origin
            country_of_origin.FlatStyle = FlatStyle.Popup;
            country_of_origin.Size = new Size(200, 50);
            country_of_origin.Location = new Point(label_the_age_of_the_car.Location.X, label_the_age_of_the_car.Location.Y - 40);
            country_of_origin.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 12);
            country_of_origin.Items.AddRange(new string[] { "other", "EU", "EFTA", "Canada" });
          
            //ComboBox fuel
            fuel.FlatStyle = FlatStyle.Popup;
            fuel.Size = new Size(200, 50);
            fuel.Location = new Point(label_country_of_origin.Location.X, label_country_of_origin.Location.Y - 40);
            fuel.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            fuel.Items.AddRange(new string[] { "gasoline", "diesel" });

            //ComboBox full mass 
            full_mass.FlatStyle = FlatStyle.Popup;
            full_mass.Size = new Size(200, 50);
            full_mass.Location = new Point(CM.Location.X, CM.Location.Y + 60);
            full_mass.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            full_mass.Items.AddRange(new string[] { "up to 5 tons", "from 5 to 20 tons", "from 20 tons" });
           
            // Button сalculate
            сalculate.Size = new Size(200, 30);
            сalculate.Location = new Point(CM.Location.X, CM.Location.Y + 120);
            сalculate.Font = new Font(label_the_cost_of_a_car_abroad.Font.FontFamily, 11);
            сalculate.Text = "Calculate";
            сalculate.ForeColor = Color.WhiteSmoke;
            сalculate.BackColor = Color.DeepSkyBlue;
        }
        private void Picture_SelectedIdexChanged()
        {
            picture.Size = new Size(100, 100);
            picture.Location = new Point(330, 350);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile($"pics\\5.png");
        }
        private void Btn_Click_CAR(object sender, System.EventArgs e)
        {
            сalculate.Click -= Calculate_for_CAR_and_BAS;
            Add_Controls_not_all();

            Controls.Add(this.label_the_age_of_the_car);
            Controls.Add(this.the_age_of_the_car);
            Controls.Add(this.picture);

            the_age_of_the_car.SelectedIndex = 0;
            country_of_origin.SelectedIndex = 0;
            fuel.SelectedIndex = 0;

            сalculate.Click += Calculate_for_CAR_and_BAS;

            Picture_SelectedIdexChanged();          
        }
        private void Btn_Click_MOTO(object sender, System.EventArgs e)
        {
           
            Add_Controls_not_all();

            country_of_origin.SelectedIndex = 0;
            fuel.SelectedIndex = 0;
 
            сalculate.Click += Calculate_for_MOTO;

            Picture_SelectedIdexChanged();
        }
        private void Btn_Click_TRUCK(object sender, System.EventArgs e)
        {
            Add_Controls_not_all();

            Controls.Add(this.label_the_age_of_the_car);
            Controls.Add(this.the_age_of_the_car);
            Controls.Add(this.label_full_mass);
            Controls.Add(this.full_mass);
            Controls.Add(this.picture);

            the_age_of_the_car.SelectedIndex = 0;
            country_of_origin.SelectedIndex = 0;
            fuel.SelectedIndex = 0;
            full_mass.SelectedIndex = 0;

            сalculate.Click += Calculate_for_TRUCK;

            Picture_SelectedIdexChanged();
        }
        private void Calculate_for_CAR_and_BAS(object sender, EventArgs e)
        {
            try
            {
                    fuele = fuele + fuel.SelectedIndex.GetHashCode();
                    country = country + country_of_origin.SelectedIndex.GetHashCode();
                    age = age + the_age_of_the_car.SelectedIndex.GetHashCode();
                    mass = 0;
                    eur = int.Parse(EUR.Text);
                    cm = int.Parse(CM.Text);
                    Formula(eur, cm, country, fuele, age, mass);    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check spelling of fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Calculate_for_MOTO(object sender, EventArgs e)
        {
            try
            {
                    fuele = fuele + fuel.SelectedIndex.GetHashCode();
                    country = country + country_of_origin.SelectedIndex.GetHashCode();
                    age = 0;
                    mass = 0;
                    eur = int.Parse(EUR.Text);
                    cm = int.Parse(CM.Text);
                    Formula(eur, cm, country, fuele, age, mass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check spelling of fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Calculate_for_TRUCK(object sender, EventArgs e)
        {
            try
            {
                fuele = fuele + fuel.SelectedIndex.GetHashCode();
                country = country + country_of_origin.SelectedIndex.GetHashCode();
                age = age + the_age_of_the_car.SelectedIndex.GetHashCode();
                mass = mass * (full_mass.SelectedIndex.GetHashCode()+1);
                eur = int.Parse(EUR.Text);
                cm = int.Parse(CM.Text);
                Formula(eur, cm, country, fuele, age, mass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check spelling of fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Formula(int eur, int cm, int country,int fuele, int age, int mass)// Это не настоящая формула)
        {
            Import_duty = ((100 * country) + (eur + mass)) / 10;
            Excise_duty = cm / (fuele + age);
            VAT = (eur + cm + fuele + country + age + mass) / 10;
            The_cost_of_a_car_with_customs_clearance = eur + VAT + Import_duty + Excise_duty;
            label_Import_duty.Text = $"Import duty: \t{Import_duty} €";
            label_Excise_duty.Text = $"Excise duty: \t{Excise_duty} €";
            label_VAT.Text = $"VAT: \t{VAT} €";
            label_The_cost_of_a_car_with_customs_clearance.Text = $"The cost of a car with customs clearance: {The_cost_of_a_car_with_customs_clearance} €";
        }
        private void Add_Controls_not_all()
        {
            сalculate.Click -= Calculate_for_CAR_and_BAS;
            сalculate.Click -= Calculate_for_MOTO;
            сalculate.Click -= Calculate_for_TRUCK;

            Controls.Clear();
            EUR.Text = "";
            CM.Text = "";
            label_Import_duty.Text = "Import duty:";
            label_Excise_duty.Text = "Excise duty:";
            label_VAT.Text = "VAT:";
            label_The_cost_of_a_car_with_customs_clearance.Text = "The cost of a car with customs clearance:";

            Controls.Add(CAR);
            Controls.Add(MOTO);
            Controls.Add(TRUCK);
            Controls.Add(BUS);

            Controls.Add(this.EUR);
            Controls.Add(this.CM);

            Controls.Add(this.label_the_cost_of_a_car_abroad);
            Controls.Add(this.label_eur);
            Controls.Add(this.label_engine_displacement);
            Controls.Add(this.label_cm);
            Controls.Add(this.label_country_of_origin);
            Controls.Add(this.label_fuel);
            Controls.Add(this.label_Import_duty);
            Controls.Add(this.label_Excise_duty);
            Controls.Add(this.label_VAT);
            Controls.Add(this.label_The_cost_of_a_car_with_customs_clearance);
            Controls.Add(this.Documents);

            Controls.Add(this.country_of_origin);
            Controls.Add(this.fuel);

            Controls.Add(this.picture);

            Controls.Add(this.сalculate);

            Controls.Add(this.line);
        }


        TextBox EUR = new TextBox();
        TextBox CM = new TextBox();

        Label label_eur = new Label();
        Label label_cm = new Label();
        Label label_the_cost_of_a_car_abroad = new Label();
        Label label_engine_displacement = new Label();
        Label label_the_age_of_the_car = new Label();
        Label label_country_of_origin = new Label();
        Label label_fuel = new Label();
        Label label_Import_duty = new Label();
        Label label_Excise_duty = new Label();
        Label label_VAT = new Label();
        Label label_The_cost_of_a_car_with_customs_clearance = new Label();
        Label label_full_mass = new Label();
        Label Documents = new Label();
        Label line = new Label();

        Button CAR = new Button(); 
        Button MOTO = new Button();
        Button TRUCK = new Button();
        Button BUS = new Button();
        Button сalculate = new Button();

        ComboBox the_age_of_the_car = new ComboBox();
        ComboBox country_of_origin = new ComboBox();
        ComboBox fuel = new ComboBox();
        ComboBox full_mass = new ComboBox();

        PictureBox picture = new PictureBox();

        //свойства для формулы
        float Import_duty = 0;
        float Excise_duty = 0;
        float VAT = 0;
        float The_cost_of_a_car_with_customs_clearance = 0;

        int eur = 0;
        int cm = 0;
        int fuele = 1;
        int country = 1;
        int age = 1;
        int mass = 100;
        

        #endregion
    }
}

