using TradeCategory.Model;
using TradeCategory.Controller;

namespace TradeCategory
{
    public partial class MainForm : Form
    {
        private Portfolio _portfolio;
        private List<Trade> _listTrade;
        private string _fileName = "";
        private string _outPutFileName = "";
        private readonly TradeController _controller;

        public MainForm()
        {
            InitializeComponent();
            _listTrade = new List<Trade>();
            _portfolio = new Portfolio();
            _controller = new TradeController();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                    _fileName = openFileDialog.FileName;
                    if (!string.IsNullOrEmpty(_fileName))
                        OpenFileToRead();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OpenFileToRead()
        {
            string line;
            int lineNumber = 0;
            
            try
            {
                StreamReader sr = new StreamReader(_fileName);

                line = sr.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    GetTrade(line, lineNumber);
                    line = sr.ReadLine();
                }
                sr.Close();

                tradeDataGridView.DataSource = null;
                tradeDataGridView.DataSource = _listTrade;
                portfolioLabel.Text = portfolioLabel.Text.Substring(0, 11 ) + _listTrade.Count;
                _portfolio.Trades = _listTrade;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        private void GetTrade(string item, int lineNumber)
        {
            //Remove aspas e colchetes..
            string strTrade = item.Replace("\"", "").Replace("{", "").Replace("}", "");

            string[] arrTrade = strTrade.Split(";");
            double trValue = Convert.ToDouble(arrTrade[0].Replace("Value = ", ""));
            string trSector = arrTrade[1].Replace(" ClientSector = ", "");

            Trade trade = new Trade();
            trade.Id = lineNumber;
            trade.Value = trValue;
            trade.Sector = GetEnumSector(trSector);
            trade.RiskLevel = _controller.GetRisk(trade);

            _listTrade.Add(trade);
        }

        private Enums.ClientSectorEnum GetEnumSector(string trSector)
        {
            switch (trSector)
            {
                case "Private":
                    return Enums.ClientSectorEnum.Privavte;
                case "Public":
                    return Enums.ClientSectorEnum.Public;
                default:
                    return Enums.ClientSectorEnum.None;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (GenerateOutPut())
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to open the file?", "Success", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.EnvironmentVariables.Add("file", _outPutFileName);
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = "/c notepad %file%";
                    proc.Start();
                    proc.CloseMainWindow();
                }
            }
        }

        private bool GenerateOutPut()
        {
            string strLine = string.Empty;
            
            
            Stream myStream;
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            
            try
            {
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        _outPutFileName = ((FileStream)myStream).Name;
                        // Code to write the stream goes here.
                        myStream.Close();
                        using (StreamWriter sw = File.CreateText(_outPutFileName))
                        {
                            strLine = "tradeCategories = {\"";
                            foreach (var item in _portfolio.Trades)
                            {
                                strLine = strLine + item.RiskLevel + "\", \"";
                            }
                            strLine = strLine.Remove(strLine.Length - 3);
                            strLine = strLine + "}";

                            sw.Write(strLine);
                        }
                        myStream.Close();
                        
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}