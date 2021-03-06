﻿using System.ComponentModel;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbnNICY = new System.Windows.Forms.RadioButton();
            this.rbnNICX = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.empLastIdlbl = new System.Windows.Forms.Label();
            this.empIdtxt = new System.Windows.Forms.TextBox();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empContacttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empAdd1txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empNICtxt = new System.Windows.Forms.TextBox();
            this.empFNametxt = new System.Windows.Forms.TextBox();
            this.empLNametxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.empPayID = new System.Windows.Forms.TextBox();
            this.btnEmployeePayment = new System.Windows.Forms.Button();
            this.payEmpAmounttxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.payEmpYeartxt = new System.Windows.Forms.TextBox();
            this.payEmpMonthcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.empAlldatagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 555);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.rbnNICY);
            this.tabPage1.Controls.Add(this.rbnNICX);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.empLastIdlbl);
            this.tabPage1.Controls.Add(this.empIdtxt);
            this.tabPage1.Controls.Add(this.btnEmployeeSearch);
            this.tabPage1.Controls.Add(this.btnEmployeeUpdate);
            this.tabPage1.Controls.Add(this.btnEmployeeSave);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.empContacttxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.empAdd1txt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.empNICtxt);
            this.tabPage1.Controls.Add(this.empFNametxt);
            this.tabPage1.Controls.Add(this.empLNametxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rbnNICY
            // 
            this.rbnNICY.AutoSize = true;
            this.rbnNICY.Location = new System.Drawing.Point(395, 218);
            this.rbnNICY.Name = "rbnNICY";
            this.rbnNICY.Size = new System.Drawing.Size(43, 29);
            this.rbnNICY.TabIndex = 43;
            this.rbnNICY.TabStop = true;
            this.rbnNICY.Text = "V";
            this.rbnNICY.UseVisualStyleBackColor = true;
            // 
            // rbnNICX
            // 
            this.rbnNICX.AutoSize = true;
            this.rbnNICX.Location = new System.Drawing.Point(455, 218);
            this.rbnNICX.Name = "rbnNICX";
            this.rbnNICX.Size = new System.Drawing.Size(43, 29);
            this.rbnNICX.TabIndex = 42;
            this.rbnNICX.TabStop = true;
            this.rbnNICX.Text = "X";
            this.rbnNICX.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Crimson;
            this.btnClear.Location = new System.Drawing.Point(744, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 40);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // empLastIdlbl
            // 
            this.empLastIdlbl.AutoSize = true;
            this.empLastIdlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empLastIdlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.empLastIdlbl.ForeColor = System.Drawing.Color.Black;
            this.empLastIdlbl.Location = new System.Drawing.Point(230, 15);
            this.empLastIdlbl.Name = "empLastIdlbl";
            this.empLastIdlbl.Size = new System.Drawing.Size(33, 25);
            this.empLastIdlbl.TabIndex = 40;
            this.empLastIdlbl.Text = "ID";
            // 
            // empIdtxt
            // 
            this.empIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIdtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empIdtxt.Location = new System.Drawing.Point(230, 60);
            this.empIdtxt.Name = "empIdtxt";
            this.empIdtxt.Size = new System.Drawing.Size(100, 26);
            this.empIdtxt.TabIndex = 28;
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btnEmployeeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeSearch.FlatAppearance.BorderSize = 0;
            this.btnEmployeeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSearch.Location = new System.Drawing.Point(413, 53);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(114, 33);
            this.btnEmployeeSearch.TabIndex = 39;
            this.btnEmployeeSearch.Text = "Search";
            this.btnEmployeeSearch.UseVisualStyleBackColor = false;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnEmployeeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeUpdate.FlatAppearance.BorderSize = 0;
            this.btnEmployeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(517, 459);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(111, 40);
            this.btnEmployeeUpdate.TabIndex = 37;
            this.btnEmployeeUpdate.Text = "Modify";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.empModbtn_Click);
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.BackColor = System.Drawing.Color.Maroon;
            this.btnEmployeeSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeSave.FlatAppearance.BorderSize = 0;
            this.btnEmployeeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSave.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSave.Location = new System.Drawing.Point(375, 459);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(111, 40);
            this.btnEmployeeSave.TabIndex = 36;
            this.btnEmployeeSave.Text = "Save";
            this.btnEmployeeSave.UseVisualStyleBackColor = false;
            this.btnEmployeeSave.Click += new System.EventHandler(this.empSavebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(57, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address";
            // 
            // empContacttxt
            // 
            this.empContacttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empContacttxt.Location = new System.Drawing.Point(230, 389);
            this.empContacttxt.MaxLength = 10;
            this.empContacttxt.Name = "empContacttxt";
            this.empContacttxt.Size = new System.Drawing.Size(159, 26);
            this.empContacttxt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(57, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Contact";
            // 
            // empAdd1txt
            // 
            this.empAdd1txt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empAdd1txt.Location = new System.Drawing.Point(230, 284);
            this.empAdd1txt.Multiline = true;
            this.empAdd1txt.Name = "empAdd1txt";
            this.empAdd1txt.Size = new System.Drawing.Size(159, 83);
            this.empAdd1txt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(57, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "NIC";
            // 
            // empNICtxt
            // 
            this.empNICtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empNICtxt.Location = new System.Drawing.Point(230, 221);
            this.empNICtxt.MaxLength = 10;
            this.empNICtxt.Name = "empNICtxt";
            this.empNICtxt.Size = new System.Drawing.Size(159, 26);
            this.empNICtxt.TabIndex = 31;
            // 
            // empFNametxt
            // 
            this.empFNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empFNametxt.Location = new System.Drawing.Point(230, 106);
            this.empFNametxt.Name = "empFNametxt";
            this.empFNametxt.Size = new System.Drawing.Size(159, 26);
            this.empFNametxt.TabIndex = 29;
            // 
            // empLNametxt
            // 
            this.empLNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empLNametxt.Location = new System.Drawing.Point(230, 164);
            this.empLNametxt.Name = "empLNametxt";
            this.empLNametxt.Size = new System.Drawing.Size(159, 26);
            this.empLNametxt.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.empPayID);
            this.tabPage2.Controls.Add(this.btnEmployeePayment);
            this.tabPage2.Controls.Add(this.payEmpAmounttxt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.payEmpYeartxt);
            this.tabPage2.Controls.Add(this.payEmpMonthcmb);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            // 
            // empPayID
            // 
            this.empPayID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empPayID.Location = new System.Drawing.Point(364, 67);
            this.empPayID.Name = "empPayID";
            this.empPayID.Size = new System.Drawing.Size(98, 26);
            this.empPayID.TabIndex = 20;
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.BackColor = System.Drawing.Color.DarkRed;
            this.btnEmployeePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeePayment.FlatAppearance.BorderSize = 0;
            this.btnEmployeePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnEmployeePayment.Location = new System.Drawing.Point(572, 359);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(145, 47);
            this.btnEmployeePayment.TabIndex = 19;
            this.btnEmployeePayment.Text = "Save";
            this.btnEmployeePayment.UseVisualStyleBackColor = false;
            this.btnEmployeePayment.Click += new System.EventHandler(this.button7_Click);
            // 
            // payEmpAmounttxt
            // 
            this.payEmpAmounttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpAmounttxt.Location = new System.Drawing.Point(364, 250);
            this.payEmpAmounttxt.MaxLength = 4;
            this.payEmpAmounttxt.Name = "payEmpAmounttxt";
            this.payEmpAmounttxt.Size = new System.Drawing.Size(192, 26);
            this.payEmpAmounttxt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(200, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Amount";
            // 
            // payEmpYeartxt
            // 
            this.payEmpYeartxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpYeartxt.Location = new System.Drawing.Point(364, 183);
            this.payEmpYeartxt.Name = "payEmpYeartxt";
            this.payEmpYeartxt.Size = new System.Drawing.Size(192, 26);
            this.payEmpYeartxt.TabIndex = 16;
            // 
            // payEmpMonthcmb
            // 
            this.payEmpMonthcmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpMonthcmb.FormattingEnabled = true;
            this.payEmpMonthcmb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.payEmpMonthcmb.Location = new System.Drawing.Point(364, 125);
            this.payEmpMonthcmb.Name = "payEmpMonthcmb";
            this.payEmpMonthcmb.Size = new System.Drawing.Size(192, 26);
            this.payEmpMonthcmb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(202, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(200, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(200, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Employee ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.empAlldatagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(882, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // empAlldatagrid
            // 
            this.empAlldatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empAlldatagrid.Location = new System.Drawing.Point(6, 29);
            this.empAlldatagrid.Name = "empAlldatagrid";
            this.empAlldatagrid.Size = new System.Drawing.Size(870, 481);
            this.empAlldatagrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 672);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 44);
            this.label6.TabIndex = 42;
            this.label6.Text = "Employee ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(57, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Last Id";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 668);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnClear;
        private Label empLastIdlbl;
        private TextBox empIdtxt;
        private Button btnEmployeeSearch;
        private Button btnEmployeeUpdate;
        private Button btnEmployeeSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox empContacttxt;
        private Label label5;
        private TextBox empAdd1txt;
        private Label label8;
        private TextBox empNICtxt;
        private TextBox empFNametxt;
        private TextBox empLNametxt;
        private TabPage tabPage2;
        private Button btnEmployeePayment;
        private TextBox payEmpAmounttxt;
        private Label label10;
        private TextBox payEmpYeartxt;
        private ComboBox payEmpMonthcmb;
        private Label label11;
        private Label label12;
        private Label label13;
        private TabPage tabPage3;
        private DataGridView empAlldatagrid;
        private Panel panel1;
        private Label label6;
        private TextBox empPayID;
        private RadioButton rbnNICY;
        private RadioButton rbnNICX;
        private Label label7;
    }
}

