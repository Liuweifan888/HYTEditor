namespace HYTEdirot
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.PanelAddImage = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxImageUrl = new System.Windows.Forms.TextBox();
            this.TextBoxImageHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxImageWidth = new System.Windows.Forms.TextBox();
            this.宽 = new System.Windows.Forms.Label();
            this.PanelAddContent = new System.Windows.Forms.Panel();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxTop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLeft = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelAddImage.SuspendLayout();
            this.PanelAddContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddImage
            // 
            this.PanelAddImage.Controls.Add(this.TextBoxImageHeight);
            this.PanelAddImage.Controls.Add(this.label2);
            this.PanelAddImage.Controls.Add(this.TextBoxImageWidth);
            this.PanelAddImage.Controls.Add(this.宽);
            this.PanelAddImage.Controls.Add(this.TextBoxImageUrl);
            this.PanelAddImage.Controls.Add(this.label1);
            this.PanelAddImage.Location = new System.Drawing.Point(12, 10);
            this.PanelAddImage.Name = "PanelAddImage";
            this.PanelAddImage.Size = new System.Drawing.Size(372, 60);
            this.PanelAddImage.TabIndex = 0;
            this.PanelAddImage.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(309, 77);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(228, 77);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "确定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片地址";
            // 
            // TextBoxImageUrl
            // 
            this.TextBoxImageUrl.Location = new System.Drawing.Point(62, 4);
            this.TextBoxImageUrl.Name = "TextBoxImageUrl";
            this.TextBoxImageUrl.Size = new System.Drawing.Size(307, 21);
            this.TextBoxImageUrl.TabIndex = 1;
            // 
            // TextBoxImageHeight
            // 
            this.TextBoxImageHeight.Location = new System.Drawing.Point(244, 31);
            this.TextBoxImageHeight.Name = "TextBoxImageHeight";
            this.TextBoxImageHeight.Size = new System.Drawing.Size(125, 21);
            this.TextBoxImageHeight.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "图片高";
            // 
            // TextBoxImageWidth
            // 
            this.TextBoxImageWidth.Location = new System.Drawing.Point(62, 31);
            this.TextBoxImageWidth.Name = "TextBoxImageWidth";
            this.TextBoxImageWidth.Size = new System.Drawing.Size(120, 21);
            this.TextBoxImageWidth.TabIndex = 7;
            this.TextBoxImageWidth.Text = "750";
            // 
            // 宽
            // 
            this.宽.AutoSize = true;
            this.宽.Location = new System.Drawing.Point(15, 34);
            this.宽.Name = "宽";
            this.宽.Size = new System.Drawing.Size(41, 12);
            this.宽.TabIndex = 6;
            this.宽.Text = "图片宽";
            // 
            // PanelAddContent
            // 
            this.PanelAddContent.Controls.Add(this.TextBoxHeight);
            this.PanelAddContent.Controls.Add(this.label5);
            this.PanelAddContent.Controls.Add(this.TextBoxWidth);
            this.PanelAddContent.Controls.Add(this.label4);
            this.PanelAddContent.Controls.Add(this.TextBoxTop);
            this.PanelAddContent.Controls.Add(this.label3);
            this.PanelAddContent.Controls.Add(this.TextBoxLeft);
            this.PanelAddContent.Controls.Add(this.label6);
            this.PanelAddContent.Location = new System.Drawing.Point(12, 10);
            this.PanelAddContent.Name = "PanelAddContent";
            this.PanelAddContent.Size = new System.Drawing.Size(372, 60);
            this.PanelAddContent.TabIndex = 3;
            this.PanelAddContent.Visible = false;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(244, 30);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(125, 21);
            this.TextBoxHeight.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Div 高";
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Location = new System.Drawing.Point(51, 31);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(125, 21);
            this.TextBoxWidth.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Div 宽";
            // 
            // TextBoxTop
            // 
            this.TextBoxTop.Location = new System.Drawing.Point(244, 4);
            this.TextBoxTop.Name = "TextBoxTop";
            this.TextBoxTop.Size = new System.Drawing.Size(125, 21);
            this.TextBoxTop.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "顶边距";
            // 
            // TextBoxLeft
            // 
            this.TextBoxLeft.Location = new System.Drawing.Point(51, 4);
            this.TextBoxLeft.Name = "TextBoxLeft";
            this.TextBoxLeft.Size = new System.Drawing.Size(125, 21);
            this.TextBoxLeft.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "左边距";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 112);
            this.Controls.Add(this.PanelAddContent);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.PanelAddImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "添加信息";
            this.PanelAddImage.ResumeLayout(false);
            this.PanelAddImage.PerformLayout();
            this.PanelAddContent.ResumeLayout(false);
            this.PanelAddContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAddImage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.TextBox TextBoxImageUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxImageHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxImageWidth;
        private System.Windows.Forms.Label 宽;
        private System.Windows.Forms.Panel PanelAddContent;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLeft;
        private System.Windows.Forms.Label label6;
    }
}