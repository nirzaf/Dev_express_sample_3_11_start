using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_3_11 {
  public partial class Form1 : DevExpress.XtraEditors.XtraForm {
    public Form1() {
      InitializeComponent();
      // Handling the QueryControl event that will populate all automatically generated Documents
      this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
    }

    // Assigning a required content for each auto generated Document
    void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {

      if (e.Document == richEditUserControlDocument)
        e.Control = new sample_3_11.RichEditUserControl();
      if (e.Document == gridUserControlDocument)
        e.Control = new sample_3_11.GridUserControl();
      if (e.Control == null)
        e.Control = new System.Windows.Forms.Control();
    }
  }
}
