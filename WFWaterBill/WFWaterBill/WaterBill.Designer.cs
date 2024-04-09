namespace WFWaterBill
{
    partial class WaterBill
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnShut = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            clName = new ColumnHeader();
            clType = new ColumnHeader();
            clLast = new ColumnHeader();
            clThis = new ColumnHeader();
            clWaterCon = new ColumnHeader();
            clWaterFee = new ColumnHeader();
            clTaxFee = new ColumnHeader();
            clTotal = new ColumnHeader();
            txbName = new TextBox();
            txbLast = new TextBox();
            txbThis = new TextBox();
            cbbType = new ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(168, 784);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(430, 784);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(699, 784);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnShut
            // 
            btnShut.Location = new Point(1364, 834);
            btnShut.Name = "btnShut";
            btnShut.Size = new Size(150, 46);
            btnShut.TabIndex = 3;
            btnShut.Text = "Shutdown";
            btnShut.UseVisualStyleBackColor = true;
            btnShut.Click += btnShut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 535);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 649);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 5;
            label2.Text = "Type of Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(732, 535);
            label3.Name = "label3";
            label3.Size = new Size(284, 32);
            label3.TabIndex = 6;
            label3.Text = "Last month's water meter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(732, 649);
            label4.Name = "label4";
            label4.Size = new Size(286, 32);
            label4.TabIndex = 7;
            label4.Text = "This month's water meter";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clName, clType, clLast, clThis, clWaterCon, clWaterFee, clTaxFee, clTotal });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(27, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(1469, 466);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clName
            // 
            clName.Text = "Name";
            clName.Width = 200;
            // 
            // clType
            // 
            clType.Text = "Type of Customer";
            clType.TextAlign = HorizontalAlignment.Center;
            clType.Width = 250;
            // 
            // clLast
            // 
            clLast.Text = "Last month";
            clLast.TextAlign = HorizontalAlignment.Center;
            clLast.Width = 150;
            // 
            // clThis
            // 
            clThis.Text = "This month";
            clThis.TextAlign = HorizontalAlignment.Center;
            clThis.Width = 150;
            // 
            // clWaterCon
            // 
            clWaterCon.Text = "Water consume";
            clWaterCon.TextAlign = HorizontalAlignment.Center;
            clWaterCon.Width = 200;
            // 
            // clWaterFee
            // 
            clWaterFee.Text = "Water Fee";
            clWaterFee.TextAlign = HorizontalAlignment.Center;
            clWaterFee.Width = 150;
            // 
            // clTaxFee
            // 
            clTaxFee.Text = "Tax, Fees";
            clTaxFee.TextAlign = HorizontalAlignment.Center;
            clTaxFee.Width = 150;
            // 
            // clTotal
            // 
            clTotal.Text = "Total Bill";
            clTotal.TextAlign = HorizontalAlignment.Center;
            clTotal.Width = 200;
            // 
            // txbName
            // 
            txbName.Location = new Point(84, 586);
            txbName.Name = "txbName";
            txbName.Size = new Size(485, 39);
            txbName.TabIndex = 9;
            // 
            // txbLast
            // 
            txbLast.Location = new Point(732, 586);
            txbLast.Name = "txbLast";
            txbLast.Size = new Size(185, 39);
            txbLast.TabIndex = 10;
            // 
            // txbThis
            // 
            txbThis.Location = new Point(732, 694);
            txbThis.Name = "txbThis";
            txbThis.Size = new Size(185, 39);
            txbThis.TabIndex = 11;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "Household Customer", "Administrative agency, public services", "Production units", "Business service" });
            cbbType.Location = new Point(84, 706);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(485, 40);
            cbbType.TabIndex = 12;
            cbbType.SelectedIndexChanged += cbbType_SelectedIndexChanged;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1526, 892);
            Controls.Add(cbbType);
            Controls.Add(txbThis);
            Controls.Add(txbLast);
            Controls.Add(txbName);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShut);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "WaterBill";
            Text = "WaterBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Button btnShut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private TextBox txbName;
        private TextBox txbLast;
        private TextBox txbThis;
        private ComboBox cbbType;
        private ColumnHeader clName;
        private ColumnHeader clType;
        private ColumnHeader clLast;
        private ColumnHeader clThis;
        private ColumnHeader clWaterCon;
        private ColumnHeader clWaterFee;
        private ColumnHeader clTaxFee;
        private ColumnHeader clTotal;
    }
}