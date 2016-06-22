using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogic;
using DataAccess;

using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraEditors;

namespace Entity {
    public partial class XuLyTabPageEN {
        public void ThemTabPage(XtraTabControl tabMain, XtraUserControl ucItem, string nameItem) {
            bool isExits = false;
            foreach(XtraTabPage temp in tabMain.TabPages) {
                if(temp.Text == nameItem) {
                    isExits = true;
                    tabMain.SelectedTabPage = temp;
                    break;
                }
            }
            if(!isExits) {
                XtraTabPage tabPage = new XtraTabPage();
                tabPage.Text = nameItem;
                ucItem.Dock = DockStyle.Fill;
                tabPage.Controls.Add(ucItem);
                tabMain.TabPages.Add(tabPage);
            }
        }
    }
}
