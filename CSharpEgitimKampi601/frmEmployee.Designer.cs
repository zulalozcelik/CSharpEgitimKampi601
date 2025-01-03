namespace CSharpEgitimKampi601
{
    partial class frmEmployee
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
            this.btnEmpployeeGetById = new System.Windows.Forms.Button();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmpployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmpployeeDelete = new System.Windows.Forms.Button();
            this.btnEmpployeeAdd = new System.Windows.Forms.Button();
            this.btnEmpployeeList = new System.Windows.Forms.Button();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmployeeDepartment = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpployeeGetById
            // 
            this.btnEmpployeeGetById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpployeeGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpployeeGetById.Location = new System.Drawing.Point(276, 405);
            this.btnEmpployeeGetById.Name = "btnEmpployeeGetById";
            this.btnEmpployeeGetById.Size = new System.Drawing.Size(133, 37);
            this.btnEmpployeeGetById.TabIndex = 49;
            this.btnEmpployeeGetById.Text = "Id\'ye göre getir";
            this.btnEmpployeeGetById.UseVisualStyleBackColor = false;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(275, 158);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(133, 22);
            this.txtEmployeeSalary.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(115, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Personel Maaşı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 362);
            this.dataGridView1.TabIndex = 46;
            // 
            // btnEmpployeeUpdate
            // 
            this.btnEmpployeeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpployeeUpdate.Location = new System.Drawing.Point(276, 361);
            this.btnEmpployeeUpdate.Name = "btnEmpployeeUpdate";
            this.btnEmpployeeUpdate.Size = new System.Drawing.Size(133, 37);
            this.btnEmpployeeUpdate.TabIndex = 45;
            this.btnEmpployeeUpdate.Text = "Güncelle";
            this.btnEmpployeeUpdate.UseVisualStyleBackColor = false;
            // 
            // btnEmpployeeDelete
            // 
            this.btnEmpployeeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpployeeDelete.Location = new System.Drawing.Point(276, 318);
            this.btnEmpployeeDelete.Name = "btnEmpployeeDelete";
            this.btnEmpployeeDelete.Size = new System.Drawing.Size(133, 37);
            this.btnEmpployeeDelete.TabIndex = 44;
            this.btnEmpployeeDelete.Text = "Sil";
            this.btnEmpployeeDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmpployeeAdd
            // 
            this.btnEmpployeeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpployeeAdd.Location = new System.Drawing.Point(276, 275);
            this.btnEmpployeeAdd.Name = "btnEmpployeeAdd";
            this.btnEmpployeeAdd.Size = new System.Drawing.Size(133, 37);
            this.btnEmpployeeAdd.TabIndex = 43;
            this.btnEmpployeeAdd.Text = "Ekle";
            this.btnEmpployeeAdd.UseVisualStyleBackColor = false;
            // 
            // btnEmpployeeList
            // 
            this.btnEmpployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpployeeList.Location = new System.Drawing.Point(276, 233);
            this.btnEmpployeeList.Name = "btnEmpployeeList";
            this.btnEmpployeeList.Size = new System.Drawing.Size(133, 37);
            this.btnEmpployeeList.TabIndex = 42;
            this.btnEmpployeeList.Text = "Listele";
            this.btnEmpployeeList.UseVisualStyleBackColor = false;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(276, 120);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(133, 22);
            this.txtEmployeeSurname.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(108, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Personel Soyadı:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(276, 84);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(133, 22);
            this.txtEmployeeName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(136, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Personel Adı:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(276, 47);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(133, 22);
            this.txtEmployeeId.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Personel Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Personel Departmanı:";
            // 
            // cmbEmployeeDepartment
            // 
            this.cmbEmployeeDepartment.AllowSpinLoop = false;
            this.cmbEmployeeDepartment.GapHeight = 0;
            this.cmbEmployeeDepartment.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cmbEmployeeDepartment.ItemsDisplayMember = "";
            this.cmbEmployeeDepartment.ItemsValueMember = "";
            this.cmbEmployeeDepartment.Location = new System.Drawing.Point(276, 197);
            this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
            this.cmbEmployeeDepartment.Size = new System.Drawing.Size(133, 20);
            this.cmbEmployeeDepartment.TabIndex = 51;
            this.cmbEmployeeDepartment.Tag = null;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 465);
            this.Controls.Add(this.cmbEmployeeDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEmpployeeGetById);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEmpployeeUpdate);
            this.Controls.Add(this.btnEmpployeeDelete);
            this.Controls.Add(this.btnEmpployeeAdd);
            this.Controls.Add(this.btnEmpployeeList);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpployeeGetById;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmpployeeUpdate;
        private System.Windows.Forms.Button btnEmpployeeDelete;
        private System.Windows.Forms.Button btnEmpployeeAdd;
        private System.Windows.Forms.Button btnEmpployeeList;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1ComboBox cmbEmployeeDepartment;
    }
}