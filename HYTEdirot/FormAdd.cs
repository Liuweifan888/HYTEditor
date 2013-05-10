using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYTEdirot
{
    public partial class FormAdd : Form
    {
        private bool Isimage;

        public FormAdd(bool IsImage)
        {
            InitializeComponent();
            Isimage = IsImage;
            if (IsImage)
            {
                PanelAddImage.Visible = true;
            }
            else
            {
                PanelAddContent.Visible = true;
            }
        }
        /// <summary>
        /// 自定义属于用于返回值
        /// </summary>
        public string ReturnStyle
        {
            get
            {
                if (Isimage)
                {
                    return "background:url(" + TextBoxImageUrl.Text + ");width:" + TextBoxImageWidth.Text + "px;height:" + TextBoxImageHeight.Text + "px;margin:0 auto;padding:0px;";
                }
                else
                {
                    return "position:relative;left:" + TextBoxLeft.Text + "px;top: " + TextBoxTop.Text + "px;width:" + TextBoxWidth.Text + "px;height:" + TextBoxHeight.Text + "px;margin:0;padding:0;border: solid 1px #E0AE00";
                }
            }
        }

        public string[] ReturnParameter
        {
            get
            {
                if (Isimage)
                {
                    return new string[] { TextBoxImageUrl.Text, TextBoxImageWidth.Text, TextBoxImageHeight.Text };
                }
                else
                {
                    return new string[] { TextBoxLeft.Text, TextBoxTop.Text, TextBoxWidth.Text, TextBoxHeight.Text };
                }
            }
        }
        public void SetParameter(string[] Parameter)
        {
            if (Isimage)
            {
                TextBoxImageUrl.Text = Parameter[0];
                TextBoxImageWidth.Text = Parameter[1];
                TextBoxImageHeight.Text = Parameter[2];

            }
            else
            {
                TextBoxLeft.Text = Parameter[0];
                TextBoxTop.Text = Parameter[1];
                TextBoxWidth.Text = Parameter[2];
                TextBoxHeight.Text = Parameter[3];
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (Isimage)
            {
                if (TextBoxImageUrl.Text.Equals("") || TextBoxImageWidth.Text.Equals("") || TextBoxImageHeight.Text.Equals(""))
                {
                    MessageBox.Show("信息不完整");
                }
                else
                {
                    try
                    {
                        int.Parse(TextBoxImageWidth.Text);
                        int.Parse(TextBoxImageHeight.Text);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch { MessageBox.Show("信息有误"); }
                }
            }
            else
            {
                try
                {
                    int.Parse(TextBoxLeft.Text);
                    int.Parse(TextBoxTop.Text);
                    int.Parse(TextBoxWidth.Text);
                    int.Parse(TextBoxHeight.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch { MessageBox.Show("信息不完整或有误"); }
            }
        }
    }
}
