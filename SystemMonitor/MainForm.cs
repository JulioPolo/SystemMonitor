using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;

namespace SystemMonitor
{
    public partial class MainForm : Form
    {
        SysMon _sysInfo;
        SpeechSynthesizer _synth;
        public MainForm()
        {
            InitializeComponent();
            _sysInfo = new SysMon();
            _synth = new SpeechSynthesizer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _synth.SelectVoiceByHints(VoiceGender.Male);
            _synth.SpeakAsync("Programa diseñado por Julio Polo");
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Monitortimer.Enabled = true;
            
            //_synth.
            _synth.SpeakAsync("Monitoreo iniciado");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _sysInfo = null;
            _synth = null;
        }

        private void Monitortimer_Tick(object sender, EventArgs e)
        {
            CoreUsagetextBox.Text =  _sysInfo.GetCoreUsageByPercent.ToString();
            MemoryUsagetextBox.Text = _sysInfo.GetMemoryCount.ToString();
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            Monitortimer.Enabled = false;
            _synth.SpeakAsync("Monitoreo Terminado");

        }
    }
}
