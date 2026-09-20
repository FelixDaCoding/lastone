using System;
using System.Drawing;
using System.Windows.Forms;

namespace InfusionPumpV1
{
    public partial class Form1 : Form
    {
        // Crisp inputs
        private double heartRate = 40.0;
        private double bloodPressure = 60.0;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
            InitializeRulesGrid();

            calculateFuzzyLogic();
        }
        
        private void InitializeRulesGrid()
        {
            dgvRules.Rows.Add("1", "IF HR Low AND BP Low THEN Decrease", "0.00");
            dgvRules.Rows.Add("2", "IF HR Low AND BP Norm THEN Decrease", "0.00");
            dgvRules.Rows.Add("3", "IF HR Norm AND BP Low THEN Maintain", "0.00");
            dgvRules.Rows.Add("4", "IF HR Low AND BP High THEN Decrease", "0.00");
            dgvRules.Rows.Add("5", "IF HR Norm AND BP Norm THEN Maintain", "0.00");
            dgvRules.Rows.Add("6", "IF HR High AND BP Low THEN Increase", "0.00");
            dgvRules.Rows.Add("7", "IF HR Norm AND BP High THEN Maintain", "0.00");
            dgvRules.Rows.Add("8", "IF HR High AND BP Norm THEN Increase", "0.00");
            dgvRules.Rows.Add("9", "IF HR High AND BP High THEN Increase", "0.00");
        }

        private void calculateFuzzyLogic()
        {
            // 1. FUZZIFICATION (Input Memberships)
            double hrLow = TrapezoidalMembership(heartRate, 40, 40, 60, 80);
            double hrNormal = TrapezoidalMembership(heartRate, 60, 80, 100, 120);
            double hrHigh = TrapezoidalMembership(heartRate, 100, 120, 180, 180);

            double bpLow = TrapezoidalMembership(bloodPressure, 60, 60, 80, 100);
            double bpNormal = TrapezoidalMembership(bloodPressure, 90, 105, 125, 140);
            double bpHigh = TrapezoidalMembership(bloodPressure, 130, 145, 180, 180);

            // 2. RULE EVALUATION
            // Rule Group: Decrease Pump Rate
            double rule1 = Math.Min(hrLow, bpLow);
            double rule2 = Math.Min(hrLow, bpNormal);
            double rule4 = Math.Min(hrLow, bpHigh);

            // Rule Group: Maintain Pump Rate
            double rule3 = Math.Min(hrNormal, bpLow);
            double rule5 = Math.Min(hrNormal, bpNormal);
            double rule7 = Math.Min(hrNormal, bpHigh);

            // Rule Group: Increase Pump Rate
            double rule6 = Math.Min(hrHigh, bpLow);
            double rule8 = Math.Min(hrHigh, bpNormal);
            double rule9 = Math.Min(hrHigh, bpHigh);

            // Update Rules DataGridView
            UpdateGridRow(0, rule1);
            UpdateGridRow(1, rule2);
            UpdateGridRow(2, rule3);
            UpdateGridRow(3, rule4);
            UpdateGridRow(4, rule5);
            UpdateGridRow(5, rule6);
            UpdateGridRow(6, rule7);
            UpdateGridRow(7, rule8);
            UpdateGridRow(8, rule9);

            // Aggregate strengths for output sets
            double strengthDecrease = Math.Max(rule1, Math.Max(rule2, rule4));
            double strengthMaintain = Math.Max(rule3, Math.Max(rule5, rule7));
            double strengthIncrease = Math.Max(rule6, Math.Max(rule8, rule9));

            // 3. IMPLICATION, AGGREGATION & DEFUZZIFICATION (Center of Gravity)
            double sumNumerator = 0.0;
            double sumDenominator = 0.0;
            double step = 0.1;

            for (double y = 0.0; y <= 15.0; y += step)
            {
                double outDecrease = TrapezoidalMembership(y, 0.0, 0.0, 3.0, 6.0);
                double outMaintain = TrapezoidalMembership(y, 4.0, 6.0, 9.0, 11.0);
                double outIncrease = TrapezoidalMembership(y, 9.0, 12.0, 15.0, 15.0);

                double clippedDecrease = Math.Min(strengthDecrease, outDecrease);
                double clippedMaintain = Math.Min(strengthMaintain, outMaintain);
                double clippedIncrease = Math.Min(strengthIncrease, outIncrease);

                double aggregatedY = Math.Max(clippedDecrease, Math.Max(clippedMaintain, clippedIncrease));

                sumNumerator += y * aggregatedY * step;
                sumDenominator += aggregatedY * step;
            }

            double crispOutput = 0.0;
            if (sumDenominator > 0.0)
            {
                crispOutput = sumNumerator / sumDenominator;
            }

            label7.Text = $"Final Crisp Pump Rate:\n{crispOutput:F2} mg/h";
            
            // Update Output Chart
            pbPumpRate.Membership = new MembershipTriple(strengthDecrease, strengthMaintain, strengthIncrease);
            pbPumpRate.CurrentValue = crispOutput;
            pbPumpRate.Invalidate();
        }
        
        private void UpdateGridRow(int rowIndex, double strength)
        {
            if (dgvRules.Rows.Count <= rowIndex) return;
            dgvRules.Rows[rowIndex].Cells[2].Value = strength.ToString("F2");
            if (strength > 0) 
            {
                dgvRules.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                dgvRules.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvRules.Font, FontStyle.Bold);
            }
            else
            {
                dgvRules.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvRules.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvRules.Font, FontStyle.Regular);
            }
        }

        static double TrapezoidalMembership(double x, double a, double b, double c, double d)
        {
            if (x <= a || x >= d) return 0.0;
            if (x >= b && x <= c) return 1.0;
            if (x > a && x < b) return (x - a) / (b - a);
            return (d - x) / (d - c);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int maxScrollableRange = hScrollBar1.Maximum - hScrollBar1.LargeChange + 1;
            double percentRatio = (double)hScrollBar1.Value / maxScrollableRange;
            percentRatio = Math.Min(1.0, Math.Max(0.0, percentRatio));

            heartRate = 40.0 + (percentRatio * 140.0);
            label2.Text = $"Heart Rate: {heartRate:F0}";

            calculateFuzzyLogic();

            pbHeartRate.CurrentValue = heartRate;
            pbHeartRate.Membership = new MembershipTriple(
                TrapezoidalMembership(heartRate, 40, 40, 60, 80),
                TrapezoidalMembership(heartRate, 60, 75, 105, 120),
                TrapezoidalMembership(heartRate, 100, 130, 180, 180));
            pbHeartRate.Invalidate();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int maxScrollableRange = hScrollBar2.Maximum - hScrollBar2.LargeChange + 1;
            double percentRatio = (double)hScrollBar2.Value / maxScrollableRange;
            percentRatio = Math.Min(1.0, Math.Max(0.0, percentRatio));

            bloodPressure = 60.0 + (percentRatio * 120.0);
            label3.Text = $"Blood Pressure: {bloodPressure:F0}";

            calculateFuzzyLogic();

            pbBloodPressure.CurrentValue = bloodPressure;
            pbBloodPressure.Membership = new MembershipTriple(
                TrapezoidalMembership(bloodPressure, 60, 60, 80, 100),
                TrapezoidalMembership(bloodPressure, 90, 100, 125, 140),
                TrapezoidalMembership(bloodPressure, 130, 155, 180, 180));
            pbBloodPressure.Invalidate();
        }
        
        private void SetSliders(double targetHr, double targetBp)
        {
            int maxHR = hScrollBar1.Maximum - hScrollBar1.LargeChange + 1;
            double hrRatio = (targetHr - 40.0) / 140.0;
            hScrollBar1.Value = (int)(hrRatio * maxHR);
            hScrollBar1_Scroll(null, null);
            
            int maxBP = hScrollBar2.Maximum - hScrollBar2.LargeChange + 1;
            double bpRatio = (targetBp - 60.0) / 120.0;
            hScrollBar2.Value = (int)(bpRatio * maxBP);
            hScrollBar2_Scroll(null, null);
        }

        private void btnScenarioStable_Click(object sender, EventArgs e)
        {
            SetSliders(80, 110);
        }

        private void btnScenarioBradycardia_Click(object sender, EventArgs e)
        {
            SetSliders(45, 65);
        }

        private void btnScenarioHypertensive_Click(object sender, EventArgs e)
        {
            SetSliders(140, 160);
        }
    }
}
