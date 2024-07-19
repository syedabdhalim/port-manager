namespace PortManager
{
    partial class PortManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Protocol = new DataGridViewTextBoxColumn();
            LocalAddress = new DataGridViewTextBoxColumn();
            LocalPort = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            PID = new DataGridViewTextBoxColumn();
            ProcessName = new DataGridViewTextBoxColumn();
            killButtonColumn = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtPortNumber = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Protocol, LocalAddress, LocalPort, State, PID, ProcessName, killButtonColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 78);
            dataGridView1.Margin = new Padding(44, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1072, 519);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Protocol
            // 
            Protocol.HeaderText = "Protocol";
            Protocol.MinimumWidth = 8;
            Protocol.Name = "Protocol";
            Protocol.Width = 150;
            // 
            // LocalAddress
            // 
            LocalAddress.HeaderText = "Local Address";
            LocalAddress.MinimumWidth = 8;
            LocalAddress.Name = "LocalAddress";
            LocalAddress.Width = 150;
            // 
            // LocalPort
            // 
            LocalPort.HeaderText = "Local Port";
            LocalPort.MinimumWidth = 8;
            LocalPort.Name = "LocalPort";
            LocalPort.Width = 150;
            // 
            // State
            // 
            State.HeaderText = "State";
            State.MinimumWidth = 8;
            State.Name = "State";
            State.Width = 150;
            // 
            // PID
            // 
            PID.HeaderText = "PID";
            PID.MinimumWidth = 8;
            PID.Name = "PID";
            PID.Width = 150;
            // 
            // ProcessName
            // 
            ProcessName.HeaderText = "Process Name";
            ProcessName.MinimumWidth = 8;
            ProcessName.Name = "ProcessName";
            ProcessName.Width = 150;
            // 
            // killButtonColumn
            // 
            killButtonColumn.HeaderText = "Kill Process";
            killButtonColumn.MinimumWidth = 8;
            killButtonColumn.Name = "killButtonColumn";
            killButtonColumn.Text = "Kill";
            killButtonColumn.UseColumnTextForButtonValue = true;
            killButtonColumn.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtPortNumber);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 78);
            panel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(564, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 32);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh data";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(427, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPortNumber
            // 
            txtPortNumber.Location = new Point(217, 27);
            txtPortNumber.Name = "txtPortNumber";
            txtPortNumber.Size = new Size(194, 31);
            txtPortNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by port number:";
            // 
            // PortManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 597);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PortManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Port Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Protocol;
        private DataGridViewTextBoxColumn LocalAddress;
        private DataGridViewTextBoxColumn LocalPort;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewButtonColumn killButtonColumn;
        private TextBox txtPortNumber;
        private Label label1;
        private Button btnSearch;
        private Button btnRefresh;
    }
}
