using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComPortTest
{
  public partial class Form1 : Form
  {
    private SerialPort _serialPort = new SerialPort();
    private StringBuilder buff = new StringBuilder();

    public Form1()
    {
      InitializeComponent();
      string[] ports = SerialPort.GetPortNames();
      foreach(string p in ports)
      {
        comboBoxavailablePorts.Items.Add(p);
      }
      if(ports.Length > 0)
        comboBoxavailablePorts.SelectedIndex = 0;

      foreach (EMotorDriverCommands e in Enum.GetValues(typeof(EMotorDriverCommands)))
      {
        comboBoxCommand.Items.Add(e.ToString());
      }

      comboBoxCommand.SelectedIndex = 4;
      comboBoxName.SelectedIndex = 0;
    }

    private void availablePorts_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void openPortButton_Click(object sender, EventArgs e)
    {
      if (_serialPort.IsOpen || comboBoxavailablePorts.Items.Count == 0)
        return;
      _serialPort.PortName = comboBoxavailablePorts.SelectedItem.ToString();
      _serialPort.DataReceived += _serialPort_DataReceived;
      _serialPort.BaudRate = 9600;
      _serialPort.Parity = Parity.None;
      _serialPort.StopBits = StopBits.One;
      _serialPort.DataBits = 8;

      try
      {
        _serialPort.Open();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Błąd");
      }
    }

    void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      System.Threading.Thread.Sleep(10);
      byte[] b = new byte[8];
      int num = ((SerialPort)sender).Read(b, 0, 8);
      if (num > 0)
      {
        string f;
        if (num == 6)
        {
          char c1 = (char)b[0];
          char c2 = (char)b[2];
          f = string.Format("{4} bytes: {1} {0} {2} {3} {5} {6}", ((int)(b[1])).ToString(), c1.ToString(), c2.ToString(), ((int)(b[3])).ToString(), num, ((int)(b[4])).ToString(), ((int)(b[5])).ToString());
        }
        else
        {
          char c = (char)b[0];
          f = string.Format("{4} bytes: {1} {0} {2} {3}", ((int)(b[1])).ToString(), c.ToString(), ((int)(b[2])).ToString(), ((int)(b[3])).ToString(), num);
        }
       
        textBoxSent.Invoke(new Action(delegate()
        {
          textBoxRead.Text = f;
        }));

        buff.Clear();
      }
    }

    private void closePortButton_Click(object sender, EventArgs e)
    {
      if(_serialPort.IsOpen)
        _serialPort.Close();
    }

    private void sendCommand(byte name, byte command, byte hvalue, byte lvalue)
    {

      byte[] b = { name, command, hvalue, lvalue };
      _serialPort.Write(b, 0, 4);
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
      if(_serialPort.IsOpen)
      {
        EMotorDriverCommands c = (EMotorDriverCommands)Enum.Parse(typeof(EMotorDriverCommands), comboBoxCommand.Text);
        string f = string.Format("{0} {1} {2} {3}", comboBoxName.Text, c.ToString(), numericHValue.Value.ToString(), numericLValue.Value.ToString());
        textBoxSent.Text = f;
        sendCommand((byte)comboBoxName.SelectedIndex, (byte)c, (byte)numericHValue.Value, (byte)numericLValue.Value);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (_serialPort.IsOpen)
        _serialPort.Close();
    }

    private void availablePorts_MouseClick(object sender, MouseEventArgs e)
    {
      int ind = comboBoxavailablePorts.SelectedIndex;
      comboBoxavailablePorts.Items.Clear();
      string[] ports = SerialPort.GetPortNames();
      foreach (string p in ports)
      {
        comboBoxavailablePorts.Items.Add(p);
      }
      if (comboBoxavailablePorts.Items.Count > ind)
        comboBoxavailablePorts.SelectedIndex = ind;
      else if (comboBoxavailablePorts.Items.Count > 0)
        comboBoxavailablePorts.SelectedIndex = 0;
    }
  }
}
