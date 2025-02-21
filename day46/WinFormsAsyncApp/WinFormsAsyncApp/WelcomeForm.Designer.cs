namespace WinFormsAsyncApp
{
    //View Class
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnPrint = new Button();
            btnHello = new Button();
            btnViaThread = new Button();
            btnViaTask = new Button();
            btnViaTaskAwait = new Button();
            btnAwaitWithResult = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(580, 42);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(167, 70);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(306, 12);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(167, 70);
            btnHello.TabIndex = 1;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnViaThread
            // 
            btnViaThread.Location = new Point(580, 118);
            btnViaThread.Name = "btnViaThread";
            btnViaThread.Size = new Size(167, 70);
            btnViaThread.TabIndex = 2;
            btnViaThread.Text = "PrintViaThread";
            btnViaThread.UseVisualStyleBackColor = true;
            btnViaThread.Click += PrintViaThreadClick_Handler;
            // 
            // btnViaTask
            // 
            btnViaTask.Location = new Point(297, 98);
            btnViaTask.Name = "btnViaTask";
            btnViaTask.Size = new Size(167, 70);
            btnViaTask.TabIndex = 3;
            btnViaTask.Text = "PrintViaTask";
            btnViaTask.UseVisualStyleBackColor = true;
            btnViaTask.Click += btnViaTaskClick_Handler;
            // 
            // btnViaTaskAwait
            // 
            btnViaTaskAwait.Location = new Point(273, 204);
            btnViaTaskAwait.Name = "btnViaTaskAwait";
            btnViaTaskAwait.Size = new Size(243, 70);
            btnViaTaskAwait.TabIndex = 4;
            btnViaTaskAwait.Text = "PrintViaTaskButAwait";
            btnViaTaskAwait.UseVisualStyleBackColor = true;
            // 
            // btnAwaitWithResult
            // 
            btnAwaitWithResult.Location = new Point(273, 304);
            btnAwaitWithResult.Name = "btnAwaitWithResult";
            btnAwaitWithResult.Size = new Size(243, 70);
            btnAwaitWithResult.TabIndex = 5;
            btnAwaitWithResult.Text = "PrintViaTaskButAwaitWithResult";
            btnAwaitWithResult.UseVisualStyleBackColor = true;
            btnAwaitWithResult.Click += btnAwaitWithResult_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAwaitWithResult);
            Controls.Add(btnViaTaskAwait);
            Controls.Add(btnViaTask);
            Controls.Add(btnViaThread);
            Controls.Add(btnHello);
            Controls.Add(btnPrint);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnHello;
        private Button btnViaThread;
        private Button btnViaTask;
        private Button btnViaTaskAwait;
        private Button btnAwaitWithResult;
    }
}