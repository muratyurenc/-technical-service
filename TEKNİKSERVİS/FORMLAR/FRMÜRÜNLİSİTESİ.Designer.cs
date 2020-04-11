namespace TEKNİKSERVİS.FORMLAR
{
    partial class FRMÜRÜNLİSİTESİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMÜRÜNLİSİTESİ));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtıd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.güncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSİL = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.txtalısfıyat = new DevExpress.XtraEditors.TextEdit();
            this.txtsatısfıyat = new DevExpress.XtraEditors.TextEdit();
            this.txtstok = new DevExpress.XtraEditors.TextEdit();
            this.txturunad = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalısfıyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatısfıyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(17, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 500);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtıd);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.güncelle);
            this.groupControl1.Controls.Add(this.BTNSİL);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtmarka);
            this.groupControl1.Controls.Add(this.txtalısfıyat);
            this.groupControl1.Controls.Add(this.txtsatısfıyat);
            this.groupControl1.Controls.Add(this.txtstok);
            this.groupControl1.Controls.Add(this.txturunad);
            this.groupControl1.Location = new System.Drawing.Point(1027, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(348, 513);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜN İŞLMLERİ";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(95, 53);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(142, 20);
            this.txtıd.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "ÜRÜNID :\r\n";
            // 
            // btnlistele
            // 
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(85, 441);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(164, 47);
            this.btnlistele.TabIndex = 17;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // güncelle
            // 
            this.güncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("güncelle.ImageOptions.Image")));
            this.güncelle.Location = new System.Drawing.Point(85, 376);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(164, 47);
            this.güncelle.TabIndex = 16;
            this.güncelle.Text = "GÜNCELLE";
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // BTNSİL
            // 
            this.BTNSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSİL.ImageOptions.Image")));
            this.BTNSİL.Location = new System.Drawing.Point(85, 312);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(164, 47);
            this.BTNSİL.TabIndex = 15;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(85, 250);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(164, 47);
            this.btnkaydet.TabIndex = 14;
            this.btnkaydet.Text = "KAYDET\r\n";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(95, 212);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(142, 20);
            this.lookUpEdit1.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 215);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 26);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "KATEGORİ :\r\n\r\n";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(95, 284);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 189);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "STOK :\r\n";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "SATIŞ FİYAT :\r\n";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "ALIŞ FİYAT :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "MARKA :\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = " AD:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(95, 105);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(142, 20);
            this.txtmarka.TabIndex = 5;
            // 
            // txtalısfıyat
            // 
            this.txtalısfıyat.Location = new System.Drawing.Point(95, 131);
            this.txtalısfıyat.Name = "txtalısfıyat";
            this.txtalısfıyat.Size = new System.Drawing.Size(142, 20);
            this.txtalısfıyat.TabIndex = 4;
            // 
            // txtsatısfıyat
            // 
            this.txtsatısfıyat.Location = new System.Drawing.Point(95, 157);
            this.txtsatısfıyat.Name = "txtsatısfıyat";
            this.txtsatısfıyat.Size = new System.Drawing.Size(142, 20);
            this.txtsatısfıyat.TabIndex = 3;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(95, 186);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(142, 20);
            this.txtstok.TabIndex = 1;
            this.txtstok.EditValueChanged += new System.EventHandler(this.txtstok_EditValueChanged);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(95, 79);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(142, 20);
            this.txturunad.TabIndex = 0;
            // 
            // FRMÜRÜNLİSİTESİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMÜRÜNLİSİTESİ";
            this.Text = "FRMÜRÜNLİSİTESİ";
            this.Load += new System.EventHandler(this.FRMÜRÜNLİSİTESİ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalısfıyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatısfıyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.TextEdit txtalısfıyat;
        private DevExpress.XtraEditors.TextEdit txtsatısfıyat;
        private DevExpress.XtraEditors.TextEdit txtstok;
        private DevExpress.XtraEditors.TextEdit txturunad;
        private DevExpress.XtraEditors.SimpleButton güncelle;
        private DevExpress.XtraEditors.SimpleButton BTNSİL;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.TextEdit txtıd;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}