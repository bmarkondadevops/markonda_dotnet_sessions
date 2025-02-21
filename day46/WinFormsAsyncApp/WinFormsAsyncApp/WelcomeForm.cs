using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncApp.Services;

namespace WinFormsAsyncApp
{
    //Controller class
    public partial class WelcomeForm : Form
    {

        private PrintService _printService;
        public WelcomeForm()
        {
            _printService = new PrintService();
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Handler2");
        }

        private void btnMyHelloClick_Handler(object sender, EventArgs e)
        {
            MessageBox.Show("Event Handler1");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printService.Print();
        }

        private void PrintViaThreadClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaThread();
            MessageBox.Show("thread method completed");
        }

        private void btnViaTaskClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaTask();
            MessageBox.Show("Task completed");
        }

        private async Task btnViaTaskAwait_ClickAsync(object sender, EventArgs e)
        {
            await _printService.PrintViaTaskAwaitable();
            MessageBox.Show("Awaitable task completed after 10 second");

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAwaitWithResult_Click(object sender, EventArgs e)
        {
            string result= await  _printService.PrintViaTaskAwaitableResult();
            MessageBox.Show("task completed after 10 second result is:" + result);
        }
    }
}
