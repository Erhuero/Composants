namespace MaintenanceComposants
{
    partial class Fm_service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_service));
            System.Windows.Forms.Label ser_budgetLabel;
            System.Windows.Forms.Label ser_capaciteLabel;
            System.Windows.Forms.Label ser_produitLabel;
            System.Windows.Forms.Label ser_idLabel;
            System.Windows.Forms.Label ser_designationLabel;
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bt_plusProductif = new System.Windows.Forms.Button();
            this.bt_plusAdministratif = new System.Windows.Forms.Button();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ser_budgetTextBox = new System.Windows.Forms.TextBox();
            this.ser_capaciteTextBox = new System.Windows.Forms.TextBox();
            this.ser_produitTextBox = new System.Windows.Forms.TextBox();
            this.bs_employe = new System.Windows.Forms.BindingSource(this.components);
            this.lb_employe = new System.Windows.Forms.ListBox();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.rb_productif = new System.Windows.Forms.RadioButton();
            this.rb_administratif = new System.Windows.Forms.RadioButton();
            this.ser_idTextBox = new System.Windows.Forms.TextBox();
            this.ser_designationComboBox = new System.Windows.Forms.ComboBox();
            this.pn_productif = new System.Windows.Forms.Panel();
            this.pn_administratif = new System.Windows.Forms.Panel();
            ser_budgetLabel = new System.Windows.Forms.Label();
            ser_capaciteLabel = new System.Windows.Forms.Label();
            ser_produitLabel = new System.Windows.Forms.Label();
            ser_idLabel = new System.Windows.Forms.Label();
            ser_designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).BeginInit();
            this.gb_type.SuspendLayout();
            this.pn_productif.SuspendLayout();
            this.pn_administratif.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn
            // 
            this.bn.AddNewItem = null;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = null;
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
            this.bindingNavigatorDeleteItem,
            this.serviceBindingNavigatorSaveItem});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(800, 25);
            this.bn.TabIndex = 0;
            this.bn.Text = "bindingNavigator1";
            this.bn.RefreshItems += new System.EventHandler(this.bn_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // serviceBindingNavigatorSaveItem
            // 
            this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
            this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
            this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviceBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.serviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceBindingNavigatorSaveItem_Click);
            // 
            // bt_plusProductif
            // 
            this.bt_plusProductif.Location = new System.Drawing.Point(362, 35);
            this.bt_plusProductif.Name = "bt_plusProductif";
            this.bt_plusProductif.Size = new System.Drawing.Size(113, 23);
            this.bt_plusProductif.TabIndex = 16;
            this.bt_plusProductif.Text = "Ajouter productif";
            this.bt_plusProductif.UseVisualStyleBackColor = true;
            this.bt_plusProductif.Click += new System.EventHandler(this.bt_plusProductif_Click);
            // 
            // bt_plusAdministratif
            // 
            this.bt_plusAdministratif.Location = new System.Drawing.Point(362, 103);
            this.bt_plusAdministratif.Name = "bt_plusAdministratif";
            this.bt_plusAdministratif.Size = new System.Drawing.Size(113, 23);
            this.bt_plusAdministratif.TabIndex = 17;
            this.bt_plusAdministratif.Text = "Ajouter administratif";
            this.bt_plusAdministratif.UseVisualStyleBackColor = true;
            this.bt_plusAdministratif.Click += new System.EventHandler(this.bt_plusAdministratif_Click);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(MaintenanceComposants.Service);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged_2);
            // 
            // ser_budgetLabel
            // 
            ser_budgetLabel.AutoSize = true;
            ser_budgetLabel.Location = new System.Drawing.Point(25, 17);
            ser_budgetLabel.Name = "ser_budgetLabel";
            ser_budgetLabel.Size = new System.Drawing.Size(60, 13);
            ser_budgetLabel.TabIndex = 0;
            ser_budgetLabel.Text = "ser budget:";
            // 
            // ser_budgetTextBox
            // 
            this.ser_budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Budget", true));
            this.ser_budgetTextBox.Location = new System.Drawing.Point(91, 14);
            this.ser_budgetTextBox.Name = "ser_budgetTextBox";
            this.ser_budgetTextBox.Size = new System.Drawing.Size(121, 20);
            this.ser_budgetTextBox.TabIndex = 1;
            // 
            // ser_capaciteLabel
            // 
            ser_capaciteLabel.AutoSize = true;
            ser_capaciteLabel.Location = new System.Drawing.Point(17, 42);
            ser_capaciteLabel.Name = "ser_capaciteLabel";
            ser_capaciteLabel.Size = new System.Drawing.Size(68, 13);
            ser_capaciteLabel.TabIndex = 2;
            ser_capaciteLabel.Text = "ser capacite:";
            // 
            // ser_capaciteTextBox
            // 
            this.ser_capaciteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Capacite", true));
            this.ser_capaciteTextBox.Location = new System.Drawing.Point(91, 39);
            this.ser_capaciteTextBox.Name = "ser_capaciteTextBox";
            this.ser_capaciteTextBox.Size = new System.Drawing.Size(121, 20);
            this.ser_capaciteTextBox.TabIndex = 3;
            // 
            // ser_produitLabel
            // 
            ser_produitLabel.AutoSize = true;
            ser_produitLabel.Location = new System.Drawing.Point(26, 68);
            ser_produitLabel.Name = "ser_produitLabel";
            ser_produitLabel.Size = new System.Drawing.Size(59, 13);
            ser_produitLabel.TabIndex = 4;
            ser_produitLabel.Text = "ser produit:";
            // 
            // ser_produitTextBox
            // 
            this.ser_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Produit", true));
            this.ser_produitTextBox.Location = new System.Drawing.Point(91, 65);
            this.ser_produitTextBox.Name = "ser_produitTextBox";
            this.ser_produitTextBox.Size = new System.Drawing.Size(121, 20);
            this.ser_produitTextBox.TabIndex = 5;
            // 
            // bs_employe
            // 
            this.bs_employe.DataMember = "LesEmployes";
            this.bs_employe.DataSource = this.bs;
            this.bs_employe.CurrentChanged += new System.EventHandler(this.bs_employe_CurrentChanged);
            // 
            // lb_employe
            // 
            this.lb_employe.DataSource = this.bs_employe;
            this.lb_employe.DisplayMember = "emp_nom";
            this.lb_employe.FormattingEnabled = true;
            this.lb_employe.Location = new System.Drawing.Point(22, 167);
            this.lb_employe.Name = "lb_employe";
            this.lb_employe.Size = new System.Drawing.Size(244, 56);
            this.lb_employe.TabIndex = 17;
            this.lb_employe.ValueMember = "emp_id";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.rb_administratif);
            this.gb_type.Controls.Add(this.rb_productif);
            this.gb_type.Location = new System.Drawing.Point(302, 157);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(220, 66);
            this.gb_type.TabIndex = 18;
            this.gb_type.TabStop = false;
            this.gb_type.Enter += new System.EventHandler(this.gb_type_Enter_1);
            // 
            // rb_productif
            // 
            this.rb_productif.AutoSize = true;
            this.rb_productif.Enabled = false;
            this.rb_productif.Location = new System.Drawing.Point(22, 30);
            this.rb_productif.Name = "rb_productif";
            this.rb_productif.Size = new System.Drawing.Size(67, 17);
            this.rb_productif.TabIndex = 0;
            this.rb_productif.Text = "Productif";
            this.rb_productif.UseVisualStyleBackColor = true;
            this.rb_productif.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_administratif
            // 
            this.rb_administratif.AutoSize = true;
            this.rb_administratif.Enabled = false;
            this.rb_administratif.Location = new System.Drawing.Point(122, 30);
            this.rb_administratif.Name = "rb_administratif";
            this.rb_administratif.Size = new System.Drawing.Size(81, 17);
            this.rb_administratif.TabIndex = 1;
            this.rb_administratif.Text = "Administratif";
            this.rb_administratif.UseVisualStyleBackColor = true;
            // 
            // ser_idTextBox
            // 
            this.ser_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ser_id", true));
            this.ser_idTextBox.Location = new System.Drawing.Point(107, 43);
            this.ser_idTextBox.Name = "ser_idTextBox";
            this.ser_idTextBox.Size = new System.Drawing.Size(121, 20);
            this.ser_idTextBox.TabIndex = 3;
            // 
            // ser_idLabel
            // 
            ser_idLabel.AutoSize = true;
            ser_idLabel.Location = new System.Drawing.Point(20, 46);
            ser_idLabel.Name = "ser_idLabel";
            ser_idLabel.Size = new System.Drawing.Size(35, 13);
            ser_idLabel.TabIndex = 2;
            ser_idLabel.Text = "ser id:";
            // 
            // ser_designationComboBox
            // 
            this.ser_designationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ser_designation", true));
            this.ser_designationComboBox.FormattingEnabled = true;
            this.ser_designationComboBox.Location = new System.Drawing.Point(107, 16);
            this.ser_designationComboBox.Name = "ser_designationComboBox";
            this.ser_designationComboBox.Size = new System.Drawing.Size(121, 21);
            this.ser_designationComboBox.TabIndex = 1;
            // 
            // ser_designationLabel
            // 
            ser_designationLabel.AutoSize = true;
            ser_designationLabel.Location = new System.Drawing.Point(20, 19);
            ser_designationLabel.Name = "ser_designationLabel";
            ser_designationLabel.Size = new System.Drawing.Size(81, 13);
            ser_designationLabel.TabIndex = 0;
            ser_designationLabel.Text = "ser designation:";
            // 
            // pn_productif
            // 
            this.pn_productif.Controls.Add(ser_produitLabel);
            this.pn_productif.Controls.Add(this.ser_produitTextBox);
            this.pn_productif.Controls.Add(ser_capaciteLabel);
            this.pn_productif.Controls.Add(this.ser_capaciteTextBox);
            this.pn_productif.Controls.Add(ser_budgetLabel);
            this.pn_productif.Controls.Add(this.ser_budgetTextBox);
            this.pn_productif.Location = new System.Drawing.Point(22, 35);
            this.pn_productif.Name = "pn_productif";
            this.pn_productif.Size = new System.Drawing.Size(244, 100);
            this.pn_productif.TabIndex = 14;
            this.pn_productif.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pn_administratif
            // 
            this.pn_administratif.Controls.Add(ser_designationLabel);
            this.pn_administratif.Controls.Add(this.ser_designationComboBox);
            this.pn_administratif.Controls.Add(ser_idLabel);
            this.pn_administratif.Controls.Add(this.ser_idTextBox);
            this.pn_administratif.Location = new System.Drawing.Point(22, 35);
            this.pn_administratif.Name = "pn_administratif";
            this.pn_administratif.Size = new System.Drawing.Size(244, 100);
            this.pn_administratif.TabIndex = 15;
            // 
            // Fm_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.lb_employe);
            this.Controls.Add(this.bt_plusAdministratif);
            this.Controls.Add(this.bt_plusProductif);
            this.Controls.Add(this.pn_administratif);
            this.Controls.Add(this.pn_productif);
            this.Controls.Add(this.bn);
            this.Name = "Fm_service";
            this.Text = "Fm_service";
            this.Load += new System.EventHandler(this.Fm_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).EndInit();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.pn_productif.ResumeLayout(false);
            this.pn_productif.PerformLayout();
            this.pn_administratif.ResumeLayout(false);
            this.pn_administratif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bn;
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
        private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
        private System.Windows.Forms.Button bt_plusProductif;
        private System.Windows.Forms.Button bt_plusAdministratif;
        private System.Windows.Forms.TextBox ser_produitTextBox;
        private System.Windows.Forms.TextBox ser_capaciteTextBox;
        private System.Windows.Forms.TextBox ser_budgetTextBox;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bs_employe;
        private System.Windows.Forms.ListBox lb_employe;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.RadioButton rb_administratif;
        private System.Windows.Forms.RadioButton rb_productif;
        private System.Windows.Forms.TextBox ser_idTextBox;
        private System.Windows.Forms.ComboBox ser_designationComboBox;
        private System.Windows.Forms.Panel pn_productif;
        private System.Windows.Forms.Panel pn_administratif;
    }
}