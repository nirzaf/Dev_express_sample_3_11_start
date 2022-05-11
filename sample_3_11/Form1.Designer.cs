namespace sample_3_11 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
      DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
      DevExpress.XtraEditors.TileItemFrame tileItemFrame4 = new DevExpress.XtraEditors.TileItemFrame();
      DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
      this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
      this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
      this.richEditUserControlDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
      this.RichEditUserControlTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
      this.gridUserControlDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
      this.GridUserControlTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.richEditUserControlDocument)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RichEditUserControlTile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridUserControlDocument)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridUserControlTile)).BeginInit();
      this.SuspendLayout();
      // 
      // documentManager1
      // 
      this.documentManager1.ContainerControl = this;
      this.documentManager1.View = this.windowsUIView1;
      this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
      // 
      // windowsUIView1
      // 
      this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
      this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.richEditUserControlDocument,
            this.gridUserControlDocument});
      this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.RichEditUserControlTile,
            this.GridUserControlTile});
      // 
      // richEditUserControlDocument
      // 
      this.richEditUserControlDocument.Caption = "RichEditUserControl";
      this.richEditUserControlDocument.ControlName = "RichEditUserControl";
      this.richEditUserControlDocument.ControlTypeName = "sample_3_11.RichEditUserControl";
      // 
      // RichEditUserControlTile
      // 
      this.RichEditUserControlTile.Document = this.richEditUserControlDocument;
      tileItemElement1.Text = "Rich";
      tileItemElement2.Text = "Edit";
      tileItemElement10.Text = "User";
      tileItemElement11.Text = "Control";
      tileItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemElement12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
      tileItemElement12.ImageOptions.ImageToTextIndent = 0;
      tileItemElement12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
      tileItemElement12.ImageOptions.SvgImageSize = new System.Drawing.Size(64, 64);
      tileItemElement12.Text = "Rich Edit User Control";
      this.RichEditUserControlTile.Elements.Add(tileItemElement1);
      this.RichEditUserControlTile.Elements.Add(tileItemElement2);
      this.RichEditUserControlTile.Elements.Add(tileItemElement10);
      this.RichEditUserControlTile.Elements.Add(tileItemElement11);
      this.RichEditUserControlTile.Elements.Add(tileItemElement12);
      this.RichEditUserControlTile.Name = "RichEditUserControlTile";
      // 
      // tileContainer1
      // 
      this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.RichEditUserControlTile,
            this.GridUserControlTile});
      this.tileContainer1.Name = "tileContainer1";
      // 
      // gridUserControlDocument
      // 
      this.gridUserControlDocument.Caption = "GridUserControl";
      this.gridUserControlDocument.ControlName = "GridUserControl";
      this.gridUserControlDocument.ControlTypeName = "sample_3_11.GridUserControl";
      // 
      // GridUserControlTile
      // 
      this.GridUserControlTile.Document = this.gridUserControlDocument;
      tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
      tileItemElement3.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
      tileItemElement3.Appearance.Normal.Options.UseFont = true;
      tileItemElement3.Appearance.Normal.Options.UseTextOptions = true;
      tileItemElement3.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      tileItemElement3.Text = "Grid User Control";
      tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemFrame3.Elements.Add(tileItemElement3);
      tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
      tileItemElement4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
      tileItemElement4.ImageOptions.SvgImageSize = new System.Drawing.Size(150, 150);
      tileItemElement4.Text = "";
      tileItemFrame4.Elements.Add(tileItemElement4);
      this.GridUserControlTile.Frames.Add(tileItemFrame3);
      this.GridUserControlTile.Frames.Add(tileItemFrame4);
      this.tileContainer1.SetID(this.GridUserControlTile, 1);
      this.GridUserControlTile.Name = "GridUserControlTile";
      this.GridUserControlTile.Properties.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft;
      this.GridUserControlTile.Properties.FrameAnimationInterval = 500;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(853, 543);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.richEditUserControlDocument)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RichEditUserControlTile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridUserControlDocument)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridUserControlTile)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile RichEditUserControlTile;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document richEditUserControlDocument;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile GridUserControlTile;
    private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document gridUserControlDocument;
  }
}

