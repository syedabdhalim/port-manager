using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PortManager
{
    public partial class PortManagerForm : Form
    {
        private readonly PortManager _portManager;
        public PortManagerForm()
        {
            var processStarter = new ProcessStarter();
            var processRetriever = new ProcessRetriever();
            _portManager = new PortManager(processStarter, processRetriever);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePorts();
        }
        private void PopulatePorts()
        {
            var ports = _portManager.GetUsedPorts();
            DisplayPorts(ports);
        }
        private void DisplayPorts(IEnumerable<PortInfo> ports)
        {
            if (!ports.Any())
            {
                MessageBox.Show("No ports found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var port in ports)
            {
                dataGridView1.Rows.Add(port.Protocol, port.LocalAddress, port.LocalPort, port.State, port.PID, port.ProcessName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["killButtonColumn"].Index && e.RowIndex >= 0)
            {
                var pidCell = dataGridView1.Rows[e.RowIndex].Cells["PID"];
                if (pidCell.Value != null && int.TryParse(pidCell.Value.ToString(), out int pid))
                {
                    var result = MessageBox.Show($"Are you sure you want to kill the process with PID {pid}?", "Confirm Kill", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        KillProcessByPid(pid);
                    }
                }
            }
        }

        private void KillProcessByPid(int pid)
        {
            try
            {
                _portManager.KillProcessById(pid);
                MessageBox.Show($"Process with PID {pid} killed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulatePorts(); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error killing process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterPort = txtPortNumber.Text;
            var ports = _portManager.GetUsedPorts();

            if (string.IsNullOrWhiteSpace(filterPort))
            {
                // If the filter is empty, show all ports
                DisplayPorts(ports);
            }
            else if (int.TryParse(filterPort, out int portNumber))
            {
                // Apply filter
                var filteredPorts = ports.Where(p => p.LocalPort.Contains(filterPort)).ToList();
                DisplayPorts(filteredPorts);
            }
            else
            {
                MessageBox.Show("Please enter a valid port number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulatePorts();
            MessageBox.Show("Successfully refreshed data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}