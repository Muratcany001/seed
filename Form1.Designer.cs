namespace Code_First
{
    partial class Form1
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
            delete = new Button();
            save = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            callList = new Button();
            insertID = new TextBox();
            insertName = new TextBox();
            insertStock = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // delete
            // 
            delete.Location = new Point(474, 243);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 0;
            delete.Text = "kayıt sil";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button1_Click;
            // 
            // save
            // 
            save.Location = new Point(72, 243);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 1;
            save.Text = "kaydet";
            save.UseVisualStyleBackColor = true;
            save.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(718, 186);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // callList
            // 
            callList.Location = new Point(305, 243);
            callList.Name = "callList";
            callList.Size = new Size(94, 29);
            callList.TabIndex = 3;
            callList.Text = "liste çağır\r\n";
            callList.UseVisualStyleBackColor = true;
            // 
            // insertID
            // 
            insertID.Location = new Point(72, 288);
            insertID.Name = "insertID";
            insertID.Size = new Size(125, 27);
            insertID.TabIndex = 4;
            // 
            // insertName
            // 
            insertName.Location = new Point(72, 331);
            insertName.Name = "insertName";
            insertName.Size = new Size(125, 27);
            insertName.TabIndex = 5;
            // 
            // insertStock
            // 
            insertStock.Location = new Point(72, 374);
            insertStock.Name = "insertStock";
            insertStock.Size = new Size(125, 27);
            insertStock.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(474, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 291);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 8;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 338);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 9;
            label2.Text = "ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 381);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 10;
            label3.Text = "stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 304);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 11;
            label4.Text = "id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(insertStock);
            Controls.Add(insertName);
            Controls.Add(insertID);
            Controls.Add(callList);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(save);
            Controls.Add(delete);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete;
        private Button save;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button callList;
        private TextBox insertID;
        private TextBox insertName;
        private TextBox insertStock;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
