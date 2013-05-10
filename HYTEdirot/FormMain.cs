using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace HYTEdirot
{
    public partial class FormMain : Form
    {
        private TreeNode CurrentNode;
        private int CntImage = 0, CntText = 0;
        private List<DivInfo> Divinfo = new List<DivInfo>();

        public class DivInfo
        {
            public string ID { get; set; }
            public string Style { get; set; }
            public string[] Parameter { get; set; }
            public string ParentID { get; set; }
        }

        public FormMain()
        {
            InitializeComponent();
            
            Gecko.Xpcom.Initialize(System.Environment.CurrentDirectory.ToString() + @"\xulrunner\");

            //TreeViewDiv.
            TreeNode tnRoot = new TreeNode();
            tnRoot.Text = "Product";
            TreeViewDiv.Nodes.Add(tnRoot);
            
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(System.Environment.CurrentDirectory.ToString() + @"\html\html.html");
            GeckoWebBrowserBody.Navigate(System.Environment.CurrentDirectory.ToString() + @"\html\html.html");
        }
        private void TreeViewDiv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//判断你点的是不是右键
            {
                Point ClickPoint = new Point(e.X, e.Y);
                CurrentNode = TreeViewDiv.GetNodeAt(ClickPoint);
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    CurrentNode.ContextMenuStrip = ContextMenuStripTreeView;
                    ToolStripMenuItemAdd.Enabled = true;
                    ToolStripMenuItemEdit.Enabled = true;
                    ToolStripMenuItemDelete.Enabled = true;
                    CurrentNode.Tag = false;
                    if (CurrentNode.Parent == null)
                    {
                        ToolStripMenuItemDelete.Enabled = false;
                        ToolStripMenuItemEdit.Enabled = false;
                        CurrentNode.Tag = true;
                    }
                    try
                    {
                        if (CurrentNode.Parent.Parent != null && CurrentNode.Parent.Parent.Parent == null)
                        {
                            ToolStripMenuItemAdd.Enabled = false;
                        }
                    }
                    catch { }
                }
            }
        }

        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd(bool.Parse(CurrentNode.Tag.ToString()));
            frm.Owner = this;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
               // GeckoWebBrowserBody.Document.("alertbox", new object[] { el.Id });
                //webBrowserBody.Document.Body

                GeckoElement el= this.GeckoWebBrowserBody.Document.CreateElement("DIV");
                //el.SetAttribute("style", "background-color:#ff0000;width:750px;height:300px");
                el.SetAttribute("Style", frm.ReturnStyle);
                


                if (bool.Parse(CurrentNode.Tag.ToString()))
                {
                    el.SetAttribute("ID", "Img_" + (++CntImage));
                }
                else
                {
                    el.SetAttribute("ID", "Div_" + (++CntText));
                //    //el.SetAttribute("name", "editor");
                    el.SetAttribute("onClick", "alert('" + el.GetAttribute("ID") + "')");
                }
                DivInfo DivItem = new DivInfo();
                DivItem.ID = el.GetAttribute("ID");
                DivItem.Style = frm.ReturnStyle;
                DivItem.Parameter = frm.ReturnParameter;
                DivItem.ParentID = CurrentNode.Text;
                Divinfo.Add(DivItem);
                GeckoElement elParent = this.GeckoWebBrowserBody.Document.GetElementById(CurrentNode.Text);
                elParent.AppendChild(el);

                CurrentNode.Nodes.Add(el.GetAttribute("ID"));


            }
            this.TreeViewDiv.ExpandAll();
        }
    }
}
