namespace MaintenanceComposants
{
    partial class Fm_employe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emp_cadreLabel;
            System.Windows.Forms.Label emp_idLabel;
            System.Windows.Forms.Label emp_nomLabel;
            System.Windows.Forms.Label emp_prenomLabel;
            System.Windows.Forms.Label emp_salaireLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_employe));
            System.Windows.Forms.Label leServiceLabel;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emp_cadreCheckBox = new System.Windows.Forms.CheckBox();
            this.emp_idTextBox = new System.Windows.Forms.TextBox();
            this.emp_nomTextBox = new System.Windows.Forms.TextBox();
            this.emp_prenomTextBox = new System.Windows.Forms.TextBox();
            this.emp_salaireTextBox = new System.Windows.Forms.TextBox();
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.bs_service = new System.Windows.Forms.BindingSource(this.components);
            this.lesEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_sexe = new System.Windows.Forms.GroupBox();
            this.rb_feminin = new System.Windows.Forms.RadioButton();
            this.rb_masculin = new System.Windows.Forms.RadioButton();
            this.bs_diplomesPossedes = new System.Windows.Forms.BindingSource(this.components);
            this.lb_diplomesPossedes = new System.Windows.Forms.ListBox();
            this.lesDiplomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_autresDiplomes = new System.Windows.Forms.ListBox();
            this.bt_versAutresDiplomes = new System.Windows.Forms.Button();
            this.bt_versDiplomesPossedes = new System.Windows.Forms.Button();
            this.bs_autresDiplomes = new System.Windows.Forms.BindingSource(this.components);
            emp_cadreLabel = new System.Windows.Forms.Label();
            emp_idLabel = new System.Windows.Forms.Label();
            emp_nomLabel = new System.Windows.Forms.Label();
            emp_prenomLabel = new System.Windows.Forms.Label();
            emp_salaireLabel = new System.Windows.Forms.Label();
            leServiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesEmployesBindingSource)).BeginInit();
            this.gb_sexe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diplomesPossedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesDiplomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_autresDiplomes)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_cadreLabel
            // 
            emp_cadreLabel.AutoSize = true;
            emp_cadreLabel.Location = new System.Drawing.Point(47, 157);
            emp_cadreLabel.Name = "emp_cadreLabel";
            emp_cadreLabel.Size = new System.Drawing.Size(41, 13);
            emp_cadreLabel.TabIndex = 1;
            emp_cadreLabel.Text = "Cadre :";
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(47, 76);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(22, 13);
            emp_idLabel.TabIndex = 3;
            emp_idLabel.Text = "Id :";
            emp_idLabel.Click += new System.EventHandler(this.emp_idLabel_Click);
            // 
            // emp_nomLabel
            // 
            emp_nomLabel.AutoSize = true;
            emp_nomLabel.Location = new System.Drawing.Point(47, 105);
            emp_nomLabel.Name = "emp_nomLabel";
            emp_nomLabel.Size = new System.Drawing.Size(35, 13);
            emp_nomLabel.TabIndex = 5;
            emp_nomLabel.Text = "Nom :";
            // 
            // emp_prenomLabel
            // 
            emp_prenomLabel.AutoSize = true;
            emp_prenomLabel.Location = new System.Drawing.Point(47, 131);
            emp_prenomLabel.Name = "emp_prenomLabel";
            emp_prenomLabel.Size = new System.Drawing.Size(49, 13);
            emp_prenomLabel.TabIndex = 7;
            emp_prenomLabel.Text = "Prenom :";
            // 
            // emp_salaireLabel
            // 
            emp_salaireLabel.AutoSize = true;
            emp_salaireLabel.Location = new System.Drawing.Point(47, 185);
            emp_salaireLabel.Name = "emp_salaireLabel";
            emp_salaireLabel.Size = new System.Drawing.Size(45, 13);
            emp_salaireLabel.TabIndex = 9;
            emp_salaireLabel.Text = "Salaire :";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(MaintenanceComposants.Employe);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged);
            // 
            // bn
            // 
            this.bn.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeBindingNavigatorSaveItem});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(1050, 25);
            this.bn.TabIndex = 0;
            this.bn.Text = "bindingNavigator1";
            this.bn.RefreshItems += new System.EventHandler(this.employeBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click);
            // 
            // emp_cadreCheckBox
            // 
            this.emp_cadreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs, "emp_cadre", true));
            this.emp_cadreCheckBox.Location = new System.Drawing.Point(104, 152);
            this.emp_cadreCheckBox.Name = "emp_cadreCheckBox";
            this.emp_cadreCheckBox.Size = new System.Drawing.Size(104, 24);
            this.emp_cadreCheckBox.TabIndex = 2;
            this.emp_cadreCheckBox.UseVisualStyleBackColor = true;
            this.emp_cadreCheckBox.CheckedChanged += new System.EventHandler(this.emp_cadreCheckBox_CheckedChanged);
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_id", true));
            this.emp_idTextBox.Location = new System.Drawing.Point(104, 76);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(132, 20);
            this.emp_idTextBox.TabIndex = 4;
            // 
            // emp_nomTextBox
            // 
            this.emp_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_nom", true));
            this.emp_nomTextBox.Location = new System.Drawing.Point(104, 102);
            this.emp_nomTextBox.Name = "emp_nomTextBox";
            this.emp_nomTextBox.Size = new System.Drawing.Size(132, 20);
            this.emp_nomTextBox.TabIndex = 6;
            // 
            // emp_prenomTextBox
            // 
            this.emp_prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_prenom", true));
            this.emp_prenomTextBox.Location = new System.Drawing.Point(104, 128);
            this.emp_prenomTextBox.Name = "emp_prenomTextBox";
            this.emp_prenomTextBox.Size = new System.Drawing.Size(132, 20);
            this.emp_prenomTextBox.TabIndex = 8;
            // 
            // emp_salaireTextBox
            // 
            this.emp_salaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_salaire", true));
            this.emp_salaireTextBox.Location = new System.Drawing.Point(104, 182);
            this.emp_salaireTextBox.Name = "emp_salaireTextBox";
            this.emp_salaireTextBox.Size = new System.Drawing.Size(132, 20);
            this.emp_salaireTextBox.TabIndex = 10;
            // 
            // leServiceLabel
            // 
            leServiceLabel.AutoSize = true;
            leServiceLabel.Location = new System.Drawing.Point(399, 184);
            leServiceLabel.Name = "leServiceLabel";
            leServiceLabel.Size = new System.Drawing.Size(46, 13);
            leServiceLabel.TabIndex = 15;
            leServiceLabel.Text = "Service:";
            leServiceLabel.Click += new System.EventHandler(this.leServiceLabel_Click);
            // 
            // cb_service
            // 
            this.cb_service.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LeService", true));
            this.cb_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bs, "LeService", true));
            this.cb_service.DataSource = this.bs_service;
            this.cb_service.DisplayMember = "ser_designation";
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(451, 181);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(137, 21);
            this.cb_service.TabIndex = 16;
            this.cb_service.SelectedIndexChanged += new System.EventHandler(this.leServiceComboBox_SelectedIndexChanged);
            // 
            // bs_service
            // 
            this.bs_service.DataSource = typeof(MaintenanceComposants.Service);
            // 
            // lesEmployesBindingSource
            // 
            this.lesEmployesBindingSource.DataMember = "LesEmployes";
            this.lesEmployesBindingSource.DataSource = this.bs_service;
            // 
            // gb_sexe
            // 
            this.gb_sexe.Controls.Add(this.rb_masculin);
            this.gb_sexe.Controls.Add(this.rb_feminin);
            this.gb_sexe.Location = new System.Drawing.Point(402, 76);
            this.gb_sexe.Name = "gb_sexe";
            this.gb_sexe.Size = new System.Drawing.Size(186, 74);
            this.gb_sexe.TabIndex = 17;
            this.gb_sexe.TabStop = false;
            this.gb_sexe.Text = "Sexe";
            // 
            // rb_feminin
            // 
            this.rb_feminin.AutoSize = true;
            this.rb_feminin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "IsFemme", true));
            this.rb_feminin.Location = new System.Drawing.Point(15, 29);
            this.rb_feminin.Name = "rb_feminin";
            this.rb_feminin.Size = new System.Drawing.Size(61, 17);
            this.rb_feminin.TabIndex = 0;
            this.rb_feminin.TabStop = true;
            this.rb_feminin.Text = "Feminin";
            this.rb_feminin.UseVisualStyleBackColor = true;
            this.rb_feminin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_masculin
            // 
            this.rb_masculin.AutoSize = true;
            this.rb_masculin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "IsHomme", true));
            this.rb_masculin.Location = new System.Drawing.Point(104, 29);
            this.rb_masculin.Name = "rb_masculin";
            this.rb_masculin.Size = new System.Drawing.Size(67, 17);
            this.rb_masculin.TabIndex = 1;
            this.rb_masculin.TabStop = true;
            this.rb_masculin.Text = "Masculin";
            this.rb_masculin.UseVisualStyleBackColor = true;
            // 
            // bs_diplomesPossedes
            // 
            this.bs_diplomesPossedes.DataMember = "LesDiplomes";
            this.bs_diplomesPossedes.DataSource = this.bs;
            this.bs_diplomesPossedes.CurrentChanged += new System.EventHandler(this.lesDiplomesBindingSource_CurrentChanged);
            // 
            // lb_diplomesPossedes
            // 
            this.lb_diplomesPossedes.DataSource = this.bs_diplomesPossedes;
            this.lb_diplomesPossedes.DisplayMember = "dip_libelle";
            this.lb_diplomesPossedes.FormattingEnabled = true;
            this.lb_diplomesPossedes.Location = new System.Drawing.Point(50, 246);
            this.lb_diplomesPossedes.Name = "lb_diplomesPossedes";
            this.lb_diplomesPossedes.Size = new System.Drawing.Size(186, 134);
            this.lb_diplomesPossedes.TabIndex = 17;
            this.lb_diplomesPossedes.ValueMember = "dip_id";
            // 
            // lesDiplomesBindingSource
            // 
            this.lesDiplomesBindingSource.DataMember = "LesDiplomes";
            this.lesDiplomesBindingSource.DataSource = this.bs;
            // 
            // lb_autresDiplomes
            // 
            this.lb_autresDiplomes.DataSource = this.lesDiplomesBindingSource;
            this.lb_autresDiplomes.DisplayMember = "dip_libelle";
            this.lb_autresDiplomes.FormattingEnabled = true;
            this.lb_autresDiplomes.Location = new System.Drawing.Point(402, 246);
            this.lb_autresDiplomes.Name = "lb_autresDiplomes";
            this.lb_autresDiplomes.Size = new System.Drawing.Size(186, 134);
            this.lb_autresDiplomes.TabIndex = 17;
            this.lb_autresDiplomes.ValueMember = "dip_id";
            // 
            // bt_versAutresDiplomes
            // 
            this.bt_versAutresDiplomes.Location = new System.Drawing.Point(285, 262);
            this.bt_versAutresDiplomes.Name = "bt_versAutresDiplomes";
            this.bt_versAutresDiplomes.Size = new System.Drawing.Size(48, 39);
            this.bt_versAutresDiplomes.TabIndex = 18;
            this.bt_versAutresDiplomes.Text = ">>";
            this.bt_versAutresDiplomes.UseVisualStyleBackColor = true;
            this.bt_versAutresDiplomes.Click += new System.EventHandler(this.bt_versAutresDiplomes_Click);
            // 
            // bt_versDiplomesPossedes
            // 
            this.bt_versDiplomesPossedes.Location = new System.Drawing.Point(285, 320);
            this.bt_versDiplomesPossedes.Name = "bt_versDiplomesPossedes";
            this.bt_versDiplomesPossedes.Size = new System.Drawing.Size(48, 39);
            this.bt_versDiplomesPossedes.TabIndex = 19;
            this.bt_versDiplomesPossedes.Text = "<<";
            this.bt_versDiplomesPossedes.UseVisualStyleBackColor = true;
            this.bt_versDiplomesPossedes.Click += new System.EventHandler(this.bt_versDiplomesPossedes_Click);
            // 
            // bs_autresDiplomes
            // 
            this.bs_autresDiplomes.DataSource = this.lb_autresDiplomes.CustomTabOffsets;
            // 
            // Fm_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.bt_versDiplomesPossedes);
            this.Controls.Add(this.bt_versAutresDiplomes);
            this.Controls.Add(this.lb_autresDiplomes);
            this.Controls.Add(this.gb_sexe);
            this.Controls.Add(leServiceLabel);
            this.Controls.Add(this.cb_service);
            this.Controls.Add(emp_cadreLabel);
            this.Controls.Add(this.emp_cadreCheckBox);
            this.Controls.Add(emp_idLabel);
            this.Controls.Add(this.emp_idTextBox);
            this.Controls.Add(emp_nomLabel);
            this.Controls.Add(this.emp_nomTextBox);
            this.Controls.Add(emp_prenomLabel);
            this.Controls.Add(this.emp_prenomTextBox);
            this.Controls.Add(emp_salaireLabel);
            this.Controls.Add(this.emp_salaireTextBox);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.lb_diplomesPossedes);
            this.Name = "Fm_employe";
            this.Text = "Fm_employe";
            this.Load += new System.EventHandler(this.Fm_employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesEmployesBindingSource)).EndInit();
            this.gb_sexe.ResumeLayout(false);
            this.gb_sexe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_diplomesPossedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesDiplomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_autresDiplomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox emp_cadreCheckBox;
        private System.Windows.Forms.TextBox emp_idTextBox;
        private System.Windows.Forms.TextBox emp_nomTextBox;
        private System.Windows.Forms.TextBox emp_prenomTextBox;
        private System.Windows.Forms.TextBox emp_salaireTextBox;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.BindingSource bs_service;
        private System.Windows.Forms.BindingSource lesEmployesBindingSource;
        private System.Windows.Forms.GroupBox gb_sexe;
        private System.Windows.Forms.RadioButton rb_masculin;
        private System.Windows.Forms.RadioButton rb_feminin;
        private System.Windows.Forms.BindingSource bs_diplomesPossedes;
        private System.Windows.Forms.ListBox lb_diplomesPossedes;
        private System.Windows.Forms.BindingSource lesDiplomesBindingSource;
        private System.Windows.Forms.ListBox lb_autresDiplomes;
        private System.Windows.Forms.Button bt_versAutresDiplomes;
        private System.Windows.Forms.Button bt_versDiplomesPossedes;
        private System.Windows.Forms.BindingSource bs_autresDiplomes;
    }
}