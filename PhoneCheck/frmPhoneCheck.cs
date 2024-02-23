using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace PhoneCheck
{
    public partial class frmPhoneCheck : Form
    {
        private Dictionary<string, string> DicDeviceInfo { get; set; }
        private Dictionary<string, string> DicBatteryInfo { get; set; }
        private Dictionary<string, string> DicDiskInfo { get; set; }
        private const string LibLocation = @"C:\libimobiledevice";
        private static readonly string DeviceInfo = Path.Combine(LibLocation, "ideviceinfo.exe");
        private static readonly string DeviceDiagnostics = Path.Combine(LibLocation, "idevicediagnostics.exe");
        
        public enum Device
        {
            [Description("InternationalMobileEquipmentIdentity")]
            IMEI,
            [Description("InternationalMobileEquipmentIdentity2")]
            IMEI2,
            [Description("DeviceName")]
            DeviceName,
            [Description("ProductVersion")]
            OSVerison,
            [Description("ModelNumber")]
            ModelNumber,
            [Description("SerialNumber")]
            SerialNumber,
            [Description("CurrentCapacity")]
            CurrentCapacity,
            [Description("CycleCount")]
            CycleCount,
            [Description("TotalDiskCapacity")]
            TotalDiskCapacity,
            [Description("TotalDataCapacity")]
            TotalDataCapacity,
            [Description("PhotoUsage")]
            PhotoUsage,
        };

        public frmPhoneCheck()
        {
            InitializeComponent();
        }


        #region Event
        private void frmPhoneCheck_Load(object sender, EventArgs e)
        {
            GetDeviceInfo();
            GetBatteryInfo();
            GetDiskInfo();
        }

        private void BtnLoadInfo_Click(object? sender, EventArgs e)
        {
            GetDeviceInfo();
            GetBatteryInfo();
            GetDiskInfo();
            LoadData();
        }

        private void frmPhoneCheck_Shown(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearDataInScreen();

        }

        private void btnPair_Click(object sender, EventArgs e)
        {
            // usage
            const string ToolFileName = "D:\\lib\\phoneCheck\\idevicepair.exe";
            string output = RunExternalExe(ToolFileName, "pair");
        }
        #endregion

        #region method

        private void GetDeviceInfo()
        {
            // usage
            string output = RunExternalExe(DeviceInfo);


            var arrInfo = output.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            // Create a dictionary to store key-value pairs
            DicDeviceInfo = new Dictionary<string, string>();

            // Iterate through each line and split by colon to get key and value
            foreach (string line in arrInfo)
            {
                string[] parts = line.Split(':');
                string key = parts[0].Trim();
                string value = parts[1].Trim();

                if (DicDeviceInfo.ContainsKey(key))
                {
                    continue;
                }

                DicDeviceInfo.Add(key, value);
            }
        }

        private void GetBatteryInfo()
        {
            // usage
            string output = RunExternalExe(DeviceDiagnostics, "ioregentry AppleSmartBattery");

            XDocument xmlDoc = XDocument.Parse(output);

            // Find the element with the key "CurrentCapacity"
            XElement currentCapacityElement = xmlDoc.Descendants("key")
                .FirstOrDefault(e => e.Value == "CurrentCapacity")
                ?.ElementsAfterSelf("integer").FirstOrDefault()!;

            // Find the element with the key "CycleCount"
            XElement cycleCountElement = xmlDoc.Descendants("key")
                .FirstOrDefault(e => e.Value == "CycleCount")
                ?.ElementsAfterSelf("integer").FirstOrDefault()!;

            DicBatteryInfo = new Dictionary<string, string>
            {
                { Device.CurrentCapacity.GetDescription(), currentCapacityElement.Value },
                { Device.CycleCount.GetDescription(), cycleCountElement.Value }
            };
        }

        private void GetDiskInfo()
        {
            // usage
            string output = RunExternalExe(DeviceInfo, "-q com.apple.disk_usage.factory");
            
            var arrInfo = output.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            // Create a dictionary to store key-value pairs
            DicDiskInfo = new Dictionary<string, string>();

            // Iterate through each line and split by colon to get key and value
            foreach (string line in arrInfo)
            {
                string[] parts = line.Split(':');
                string key = parts[0].Trim();

                if (key.Equals("NANDInfo"))
                {
                    continue;
                }

                string value = parts[1].Trim();

                if (DicDiskInfo.ContainsKey(key))
                {
                    continue;
                }

                DicDiskInfo.Add(key, value);
            }
        }

        private void LoadData()
        {
            if (DicDeviceInfo == null)
            {
                return;
            }

            if (DicDeviceInfo.ContainsKey(Device.DeviceName.GetDescription()))
            {
                this.txtDeviceName.Text = DicDeviceInfo[Device.DeviceName.GetDescription()];
            }

            if (DicDeviceInfo.ContainsKey(Device.OSVerison.GetDescription()))
            {
                this.txtOSVersion.Text = DicDeviceInfo[Device.OSVerison.GetDescription()];
            }

            if (DicDeviceInfo.ContainsKey(Device.ModelNumber.GetDescription()))
            {
                this.txtModelNumber.Text = DicDeviceInfo[Device.ModelNumber.GetDescription()];
            }

            if (DicDeviceInfo.ContainsKey(Device.SerialNumber.GetDescription()))
            {
                this.txtSerialNumber.Text = DicDeviceInfo[Device.SerialNumber.GetDescription()];
            }

            if (DicDeviceInfo.ContainsKey(Device.IMEI.GetDescription()))
            {
                this.txtImei.Text = DicDeviceInfo[Device.IMEI.GetDescription()];
            }

            if (DicDeviceInfo.ContainsKey(Device.IMEI2.GetDescription()))
            {
                this.txtImei2.Text = DicDeviceInfo[Device.IMEI2.GetDescription()];
            }

            if (DicDiskInfo.ContainsKey(Device.TotalDiskCapacity.GetDescription()))
            {
                var format = Convert.ToDecimal(DicDiskInfo[Device.TotalDiskCapacity.GetDescription()]) / 1000000000;
                this.txtTotalMemory.Text = format.ToString();
            }
            
            if (DicDiskInfo.ContainsKey(Device.PhotoUsage.GetDescription()))
            {
                var format = Convert.ToDecimal(DicDiskInfo[Device.PhotoUsage.GetDescription()]) / 1000000000;
                this.txtPhotoUsage.Text = Math.Round(format, 2).ToString();
            }
            
            if (DicDiskInfo.ContainsKey(Device.TotalDataCapacity.GetDescription()))
            {
                var format = Convert.ToDecimal(DicDiskInfo[Device.TotalDataCapacity.GetDescription()]) / 1000000000;
                this.txtTotalDataCapacity.Text = Math.Round(format, 2).ToString();
            }
            
            if (DicBatteryInfo.ContainsKey(Device.CycleCount.GetDescription()))
            {
                this.txtCycleCount.Text = DicBatteryInfo[Device.CycleCount.GetDescription()];
            }
            
            if (DicBatteryInfo.ContainsKey(Device.CurrentCapacity.GetDescription()))
            {
                this.txtCurrentCapacity.Text = DicBatteryInfo[Device.CurrentCapacity.GetDescription()];
            }
           
        }

        private void ClearDataInScreen()
        {
            this.txtDeviceName.Text = string.Empty;
            this.txtOSVersion.Text = string.Empty;
            this.txtModelNumber.Text = string.Empty;
            this.txtSerialNumber.Text = string.Empty;
            this.txtImei.Text = string.Empty;
            this.txtImei2.Text = string.Empty;
            this.txtTotalMemory.Text = string.Empty;
            this.txtPhotoUsage.Text = string.Empty;
            this.txtTotalDataCapacity.Text = string.Empty;
            this.txtCycleCount.Text = string.Empty;
            this.txtCurrentCapacity.Text = string.Empty;
        }

        private string Format(string filename, string arguments)
        {
            return "'" + filename +
                   ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) +
                   "'";
        }

        private string RunExternalExe(string filename, string arguments = null)
        {
            var process = new Process();

            process.StartInfo.FileName = filename;
            if (!string.IsNullOrEmpty(arguments))
            {
                process.StartInfo.Arguments = arguments;
            }

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            var stdOutput = new StringBuilder();
            process.OutputDataReceived += (sender, args) => stdOutput.AppendLine(args.Data); // Use AppendLine rather than Append since args.Data is one line of output, not including the newline character.

            string stdError = null;
            try
            {
                process.Start();
                process.BeginOutputReadLine();
                stdError = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception("OS error while executing " + Format(filename, arguments) + ": " + e.Message, e);
            }

            if (process.ExitCode == 0)
            {
                return stdOutput.ToString();
            }
            else
            {
                var message = new StringBuilder();

                if (!string.IsNullOrEmpty(stdError))
                {
                    message.AppendLine(stdError);
                }

                if (stdOutput.Length != 0)
                {
                    message.AppendLine(stdOutput.ToString());
                }

                //throw new Exception(Format(filename, arguments) + " finished with exit code = " + process.ExitCode + ": " + message);
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        #endregion




    }
}
