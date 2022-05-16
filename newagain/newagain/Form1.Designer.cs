namespace newagain
{
    partial class frmMenu
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
            this.lbJustMuesils = new System.Windows.Forms.Label();
            this.rdEnglish = new System.Windows.Forms.RadioButton();
            this.rdHindi = new System.Windows.Forms.RadioButton();
            this.btEditCoustemerDetail = new System.Windows.Forms.Button();
            this.btMix = new System.Windows.Forms.Button();
            this.btMyMuesilsMix = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJustMuesils
            // 
            this.lbJustMuesils.AutoSize = true;
            this.lbJustMuesils.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJustMuesils.Location = new System.Drawing.Point(127, 32);
            this.lbJustMuesils.Name = "lbJustMuesils";
            this.lbJustMuesils.Size = new System.Drawing.Size(215, 44);
            this.lbJustMuesils.TabIndex = 0;
            this.lbJustMuesils.Text = "Just Muesils";
            // 
            // rdEnglish
            // 
            this.rdEnglish.AutoSize = true;
            this.rdEnglish.Location = new System.Drawing.Point(120, 143);
            this.rdEnglish.Name = "rdEnglish";
            this.rdEnglish.Size = new System.Drawing.Size(72, 20);
            this.rdEnglish.TabIndex = 1;
            this.rdEnglish.TabStop = true;
            this.rdEnglish.Text = "English";
            this.rdEnglish.UseVisualStyleBackColor = true;
            this.rdEnglish.CheckedChanged += new System.EventHandler(this.rdEnglish_CheckedChanged);
            // 
            // rdHindi
            // 
            this.rdHindi.AutoSize = true;
            this.rdHindi.Location = new System.Drawing.Point(237, 143);
            this.rdHindi.Name = "rdHindi";
            this.rdHindi.Size = new System.Drawing.Size(59, 20);
            this.rdHindi.TabIndex = 2;
            this.rdHindi.TabStop = true;
            this.rdHindi.Text = "Hindi";
            this.rdHindi.UseVisualStyleBackColor = true;
            this.rdHindi.CheckedChanged += new System.EventHandler(this.rdHindi_CheckedChanged);
            // 
            // btEditCoustemerDetail
            // 
            this.btEditCoustemerDetail.Location = new System.Drawing.Point(135, 194);
            this.btEditCoustemerDetail.Name = "btEditCoustemerDetail";
            this.btEditCoustemerDetail.Size = new System.Drawing.Size(161, 32);
            this.btEditCoustemerDetail.TabIndex = 3;
            this.btEditCoustemerDetail.Text = "Edit Customer Detail";
            this.btEditCoustemerDetail.UseVisualStyleBackColor = true;
            this.btEditCoustemerDetail.Click += new System.EventHandler(this.btEditCoustemerDetail_Click);
            // 
            // btMix
            // 
            this.btMix.Location = new System.Drawing.Point(163, 246);
            this.btMix.Name = "btMix";
            this.btMix.Size = new System.Drawing.Size(75, 23);
            this.btMix.TabIndex = 4;
            this.btMix.Text = "Mix";
            this.btMix.UseVisualStyleBackColor = true;
            this.btMix.Click += new System.EventHandler(this.btMix_Click);
            // 
            // btMyMuesilsMix
            // 
            this.btMyMuesilsMix.Location = new System.Drawing.Point(135, 290);
            this.btMyMuesilsMix.Name = "btMyMuesilsMix";
            this.btMyMuesilsMix.Size = new System.Drawing.Size(139, 34);
            this.btMyMuesilsMix.TabIndex = 5;
            this.btMyMuesilsMix.Text = "My Muesils Mixes";
            this.btMyMuesilsMix.UseVisualStyleBackColor = true;
            this.btMyMuesilsMix.Click += new System.EventHandler(this.btMyMuesilsMix_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(163, 340);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(75, 23);
            this.btOrder.TabIndex = 6;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(163, 392);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 554);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btMyMuesilsMix);
            this.Controls.Add(this.btMix);
            this.Controls.Add(this.btEditCoustemerDetail);
            this.Controls.Add(this.rdHindi);
            this.Controls.Add(this.rdEnglish);
            this.Controls.Add(this.lbJustMuesils);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJustMuesils;
        private System.Windows.Forms.RadioButton rdEnglish;
        private System.Windows.Forms.RadioButton rdHindi;
        private System.Windows.Forms.Button btEditCoustemerDetail;
        private System.Windows.Forms.Button btMix;
        private System.Windows.Forms.Button btMyMuesilsMix;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btExit;
    }
}

