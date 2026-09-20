namespace InfusionPumpV1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInputs = new System.Windows.Forms.TabPage();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.gbOverview = new System.Windows.Forms.GroupBox();
            this.lblOverview = new System.Windows.Forms.Label();
            this.gbScenarios = new System.Windows.Forms.GroupBox();
            this.btnScenarioHypertensive = new System.Windows.Forms.Button();
            this.btnScenarioBradycardia = new System.Windows.Forms.Button();
            this.btnScenarioStable = new System.Windows.Forms.Button();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pbBloodPressure = new InfusionPumpV1.MembershipChartPanel();
            this.pbHeartRate = new InfusionPumpV1.MembershipChartPanel();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.colRuleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuleDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDefuzz = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbPumpRate = new InfusionPumpV1.MembershipChartPanel();
            this.tabControl1.SuspendLayout();
            this.tabPageInputs.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.gbOverview.SuspendLayout();
            this.gbScenarios.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.gbRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.gbDefuzz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInputs);
            this.tabControl1.Controls.Add(this.tabPageRules);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInputs
            // 
            this.tabPageInputs.Controls.Add(this.gbInputs);
            this.tabPageInputs.Controls.Add(this.gbScenarios);
            this.tabPageInputs.Controls.Add(this.gbOverview);
            this.tabPageInputs.Location = new System.Drawing.Point(4, 25);
            this.tabPageInputs.Name = "tabPageInputs";
            this.tabPageInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputs.Size = new System.Drawing.Size(892, 571);
            this.tabPageInputs.TabIndex = 0;
            this.tabPageInputs.Text = "1. Inputs & Scenarios";
            this.tabPageInputs.UseVisualStyleBackColor = true;
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.gbRules);
            this.tabPageRules.Location = new System.Drawing.Point(4, 25);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(892, 571);
            this.tabPageRules.TabIndex = 1;
            this.tabPageRules.Text = "2. Fuzzy Rules";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.gbDefuzz);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 25);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(892, 571);
            this.tabPageOutput.TabIndex = 2;
            this.tabPageOutput.Text = "3. Output & Defuzzification";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // gbOverview
            // 
            this.gbOverview.Controls.Add(this.lblOverview);
            this.gbOverview.Location = new System.Drawing.Point(15, 15);
            this.gbOverview.Name = "gbOverview";
            this.gbOverview.Size = new System.Drawing.Size(350, 150);
            this.gbOverview.TabIndex = 0;
            this.gbOverview.TabStop = false;
            this.gbOverview.Text = "System Overview & Problem Statement";
            // 
            // lblOverview
            // 
            this.lblOverview.Location = new System.Drawing.Point(15, 30);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(315, 105);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Fuzzy logic handles the vagueness and non-linear relationship between vital signs (HR, BP) to determine safe, continuous adjustments to the infusion pump rate.\r\n\r\nInputs: Heart Rate, Blood Pressure\r\nOutput: Pump Dosage Rate";
            // 
            // gbScenarios
            // 
            this.gbScenarios.Controls.Add(this.btnScenarioHypertensive);
            this.gbScenarios.Controls.Add(this.btnScenarioBradycardia);
            this.gbScenarios.Controls.Add(this.btnScenarioStable);
            this.gbScenarios.Location = new System.Drawing.Point(15, 180);
            this.gbScenarios.Name = "gbScenarios";
            this.gbScenarios.Size = new System.Drawing.Size(350, 200);
            this.gbScenarios.TabIndex = 1;
            this.gbScenarios.TabStop = false;
            this.gbScenarios.Text = "Edge Case / Scenario Testing";
            // 
            // btnScenarioHypertensive
            // 
            this.btnScenarioHypertensive.Location = new System.Drawing.Point(20, 130);
            this.btnScenarioHypertensive.Name = "btnScenarioHypertensive";
            this.btnScenarioHypertensive.Size = new System.Drawing.Size(310, 40);
            this.btnScenarioHypertensive.TabIndex = 2;
            this.btnScenarioHypertensive.Text = "Hypertensive Crisis (High BP)";
            this.btnScenarioHypertensive.UseVisualStyleBackColor = true;
            this.btnScenarioHypertensive.Click += new System.EventHandler(this.btnScenarioHypertensive_Click);
            // 
            // btnScenarioBradycardia
            // 
            this.btnScenarioBradycardia.Location = new System.Drawing.Point(20, 80);
            this.btnScenarioBradycardia.Name = "btnScenarioBradycardia";
            this.btnScenarioBradycardia.Size = new System.Drawing.Size(310, 40);
            this.btnScenarioBradycardia.TabIndex = 1;
            this.btnScenarioBradycardia.Text = "Extreme Bradycardia (Low HR)";
            this.btnScenarioBradycardia.UseVisualStyleBackColor = true;
            this.btnScenarioBradycardia.Click += new System.EventHandler(this.btnScenarioBradycardia_Click);
            // 
            // btnScenarioStable
            // 
            this.btnScenarioStable.Location = new System.Drawing.Point(20, 30);
            this.btnScenarioStable.Name = "btnScenarioStable";
            this.btnScenarioStable.Size = new System.Drawing.Size(310, 40);
            this.btnScenarioStable.TabIndex = 0;
            this.btnScenarioStable.Text = "Stable Patient (Normal Vitals)";
            this.btnScenarioStable.UseVisualStyleBackColor = true;
            this.btnScenarioStable.Click += new System.EventHandler(this.btnScenarioStable_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.pbBloodPressure);
            this.gbInputs.Controls.Add(this.pbHeartRate);
            this.gbInputs.Controls.Add(this.label3);
            this.gbInputs.Controls.Add(this.label2);
            this.gbInputs.Controls.Add(this.hScrollBar2);
            this.gbInputs.Controls.Add(this.hScrollBar1);
            this.gbInputs.Location = new System.Drawing.Point(380, 15);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(490, 500);
            this.gbInputs.TabIndex = 2;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Fuzzification (Input Membership Degrees)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blood Pressure: 60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Heart Rate: 40";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(20, 290);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(450, 25);
            this.hScrollBar2.TabIndex = 5;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(20, 60);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(450, 25);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // pbBloodPressure
            // 
            this.pbBloodPressure.ChartType = InfusionPumpV1.ChartVariableType.BloodPressure;
            this.pbBloodPressure.CurrentValue = 60D;
            this.pbBloodPressure.InputMax = 180D;
            this.pbBloodPressure.InputMin = 60D;
            this.pbBloodPressure.Location = new System.Drawing.Point(20, 325);
            this.pbBloodPressure.Name = "pbBloodPressure";
            this.pbBloodPressure.Size = new System.Drawing.Size(450, 150);
            this.pbBloodPressure.TabIndex = 9;
            // 
            // pbHeartRate
            // 
            this.pbHeartRate.ChartType = InfusionPumpV1.ChartVariableType.HeartRate;
            this.pbHeartRate.CurrentValue = 40D;
            this.pbHeartRate.InputMax = 180D;
            this.pbHeartRate.InputMin = 40D;
            this.pbHeartRate.Location = new System.Drawing.Point(20, 95);
            this.pbHeartRate.Name = "pbHeartRate";
            this.pbHeartRate.Size = new System.Drawing.Size(450, 150);
            this.pbHeartRate.TabIndex = 8;
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.dgvRules);
            this.gbRules.Location = new System.Drawing.Point(20, 20);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(850, 500);
            this.gbRules.TabIndex = 3;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Fuzzy Rule Base & Inference";
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AllowUserToDeleteRows = false;
            this.dgvRules.AllowUserToResizeColumns = false;
            this.dgvRules.AllowUserToResizeRows = false;
            this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRules.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleNum,
            this.colRuleDesc,
            this.colFiring});
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(3, 18);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.ReadOnly = true;
            this.dgvRules.RowHeadersVisible = false;
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.RowTemplate.Height = 30;
            this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRules.Size = new System.Drawing.Size(844, 479);
            this.dgvRules.TabIndex = 0;
            // 
            // colRuleNum
            // 
            this.colRuleNum.FillWeight = 15F;
            this.colRuleNum.HeaderText = "Rule #";
            this.colRuleNum.MinimumWidth = 6;
            this.colRuleNum.Name = "colRuleNum";
            this.colRuleNum.ReadOnly = true;
            // 
            // colRuleDesc
            // 
            this.colRuleDesc.FillWeight = 70F;
            this.colRuleDesc.HeaderText = "Rule Description";
            this.colRuleDesc.MinimumWidth = 6;
            this.colRuleDesc.Name = "colRuleDesc";
            this.colRuleDesc.ReadOnly = true;
            // 
            // colFiring
            // 
            this.colFiring.FillWeight = 15F;
            this.colFiring.HeaderText = "Strength";
            this.colFiring.MinimumWidth = 6;
            this.colFiring.Name = "colFiring";
            this.colFiring.ReadOnly = true;
            // 
            // gbDefuzz
            // 
            this.gbDefuzz.Controls.Add(this.label7);
            this.gbDefuzz.Controls.Add(this.pbPumpRate);
            this.gbDefuzz.Location = new System.Drawing.Point(20, 20);
            this.gbDefuzz.Name = "gbDefuzz";
            this.gbDefuzz.Size = new System.Drawing.Size(850, 500);
            this.gbDefuzz.TabIndex = 4;
            this.gbDefuzz.TabStop = false;
            this.gbDefuzz.Text = "Defuzzification & Output";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Final Crisp Output: 0 mg/h";
            // 
            // pbPumpRate
            // 
            this.pbPumpRate.ChartType = InfusionPumpV1.ChartVariableType.PumpRate;
            this.pbPumpRate.CurrentValue = 0D;
            this.pbPumpRate.InputMax = 15D;
            this.pbPumpRate.InputMin = 0D;
            this.pbPumpRate.Location = new System.Drawing.Point(20, 40);
            this.pbPumpRate.Name = "pbPumpRate";
            this.pbPumpRate.Size = new System.Drawing.Size(800, 300);
            this.pbPumpRate.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fuzzy Logic Infusion Pump Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPageInputs.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.tabPageOutput.ResumeLayout(false);
            this.gbOverview.ResumeLayout(false);
            this.gbScenarios.ResumeLayout(false);
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.gbRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.gbDefuzz.ResumeLayout(false);
            this.gbDefuzz.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInputs;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.GroupBox gbOverview;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.GroupBox gbScenarios;
        private System.Windows.Forms.Button btnScenarioStable;
        private System.Windows.Forms.Button btnScenarioHypertensive;
        private System.Windows.Forms.Button btnScenarioBradycardia;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private InfusionPumpV1.MembershipChartPanel pbHeartRate;
        private InfusionPumpV1.MembershipChartPanel pbBloodPressure;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiring;
        private System.Windows.Forms.GroupBox gbDefuzz;
        private InfusionPumpV1.MembershipChartPanel pbPumpRate;
        private System.Windows.Forms.Label label7;
    }
}
