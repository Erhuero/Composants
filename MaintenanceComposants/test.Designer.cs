namespace MaintenanceComposants
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            System.Windows.Forms.Label ser_designationLabel;
            System.Windows.Forms.Label ser_idLabel;
            System.Windows.Forms.Label ser_budgetLabel;
            System.Windows.Forms.Label ser_capaciteLabel;
            System.Windows.Forms.Label ser_produitLabel;
            this.bnTest = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bsTest = new System.Windows.Forms.BindingSource(this.components);
            this.ser_designationComboBox = new System.Windows.Forms.ComboBox();
            this.ser_idTextBox = new System.Windows.Forms.TextBox();
            this.bs_employe = new System.Windows.Forms.BindingSource(this.components);
            this.lb_employeTest = new System.Windows.Forms.ListBox();
            this.ser_budgetTextBox = new System.Windows.Forms.TextBox();
            this.ser_capaciteTextBox = new System.Windows.Forms.TextBox();
            this.ser_produitTextBox = new System.Windows.Forms.TextBox();
            ser_designationLabel = new System.Windows.Forms.Label();
            ser_idLabel = new System.Windows.Forms.Label();
            ser_budgetLabel = new System.Windows.Forms.Label();
            ser_capaciteLabel = new System.Windows.Forms.Label();
            ser_produitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnTest)).BeginInit();
            this.bnTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).BeginInit();
            this.SuspendLayout();
            // 
            // bnTest
            // 
            this.bnTest.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnTest.BindingSource = this.bsTest;
            this.bnTest.CountItem = this.bindingNavigatorCountItem;
            this.bnTest.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.serviceBindingNavigatorSaveItem});
            this.bnTest.Location = new System.Drawing.Point(0, 0);
            this.bnTest.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnTest.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnTest.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnTest.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnTest.Name = "bnTest";
            this.bnTest.PositionItem = this.bindingNavigatorPositionItem;
            this.bnTest.Size = new System.Drawing.Size(800, 25);
            this.bnTest.TabIndex = 0;
            this.bnTest.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // serviceBindingNavigatorSaveItem
            // 
            this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceBindingNavigatorSaveItem.Enabled = false;
            this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
            this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
            this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviceBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // bsTest
            // 
            this.bsTest.DataSource = typeof(MaintenanceComposants.Service);
            // 
            // ser_designationLabel
            // 
            ser_designationLabel.AutoSize = true;
            ser_designationLabel.Location = new System.Drawing.Point(24, 49);
            ser_designationLabel.Name = "ser_designationLabel";
            ser_designationLabel.Size = new System.Drawing.Size(81, 13);
            ser_designationLabel.TabIndex = 5;
            ser_designationLabel.Text = "ser designation:";
            // 
            // ser_designationComboBox
            // 
            this.ser_designationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTest, "ser_designation", true));
            this.ser_designationComboBox.FormattingEnabled = true;
            this.ser_designationComboBox.Location = new System.Drawing.Point(111, 46);
            this.ser_designationComboBox.Name = "ser_designationComboBox";
            this.ser_designationComboBox.Size = new System.Drawing.Size(121, 21);
            this.ser_designationComboBox.TabIndex = 6;
            // 
            // ser_idLabel
            // 
            ser_idLabel.AutoSize = true;
            ser_idLabel.Location = new System.Drawing.Point(24, 76);
            ser_idLabel.Name = "ser_idLabel";
            ser_idLabel.Size = new System.Drawing.Size(35, 13);
            ser_idLabel.TabIndex = 7;
            ser_idLabel.Text = "ser id:";
            // 
            // ser_idTextBox
            // 
            this.ser_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTest, "ser_id", true));
            this.ser_idTextBox.Location = new System.Drawing.Point(111, 73);
            this.ser_idTextBox.Name = "ser_idTextBox";
            this.ser_idTextBox.Size = new System.Drawing.Size(121, 20);
            this.ser_idTextBox.TabIndex = 8;
            // 
            // bs_employe
            // 
            this.bs_employe.DataMember = "LesEmployes";
            this.bs_employe.DataSource = this.bsTest;
            // 
            // lb_employeTest
            // 
            this.lb_employeTest.DataSource = this.bs_employe;
            this.lb_employeTest.DisplayMember = "emp_nom";
            this.lb_employeTest.FormattingEnabled = true;
            this.lb_employeTest.Location = new System.Drawing.Point(137, 148);
            this.lb_employeTest.Name = "lb_employeTest";
            this.lb_employeTest.Size = new System.Drawing.Size(300, 173);
            this.lb_employeTest.TabIndex = 8;
            this.lb_employeTest.ValueMember = "emp_id";
            // 
            // ser_budgetLabel
            // 
            ser_budgetLabel.AutoSize = true;
            ser_budgetLabel.Location = new System.Drawing.Point(289, 53);
            ser_budgetLabel.Name = "ser_budgetLabel";
            ser_budgetLabel.Size = new System.Drawing.Size(60, 13);
            ser_budgetLabel.TabIndex = 8;
            ser_budgetLabel.Text = "ser budget:";
            // 
            // ser_budgetTextBox
            // 
            this.ser_budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTest, "Budget", true));
            this.ser_budgetTextBox.Location = new System.Drawing.Point(355, 50);
            this.ser_budgetTextBox.Name = "ser_budgetTextBox";
            this.ser_budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.ser_budgetTextBox.TabIndex = 9;
            // 
            // ser_capaciteLabel
            // 
            ser_capaciteLabel.AutoSize = true;
            ser_capaciteLabel.Location = new System.Drawing.Point(387, 27);
            ser_capaciteLabel.Name = "ser_capaciteLabel";
            ser_capaciteLabel.Size = new System.Drawing.Size(68, 13);
            ser_capaciteLabel.TabIndex = 9;
            ser_capaciteLabel.Text = "ser capacite:";
            // 
            // ser_capaciteTextBox
            // 
            this.ser_capaciteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTest, "Capacite", true));
            this.ser_capaciteTextBox.Location = new System.Drawing.Point(461, 24);
            this.ser_capaciteTextBox.Name = "ser_capaciteTextBox";
            this.ser_capaciteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ser_capaciteTextBox.TabIndex = 10;
            // 
            // ser_produitLabel
            // 
            ser_produitLabel.AutoSize = true;
            ser_produitLabel.Location = new System.Drawing.Point(290, 79);
            ser_produitLabel.Name = "ser_produitLabel";
            ser_produitLabel.Size = new System.Drawing.Size(59, 13);
            ser_produitLabel.TabIndex = 10;
            ser_produitLabel.Text = "ser produit:";
            // 
            // ser_produitTextBox
            // 
            this.ser_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTest, "Produit", true));
            this.ser_produitTextBox.Location = new System.Drawing.Point(355, 76);
            this.ser_produitTextBox.Name = "ser_produitTextBox";
            this.ser_produitTextBox.Size = new System.Drawing.Size(100, 20);
            this.ser_produitTextBox.TabIndex = 11;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(ser_produitLabel);
            this.Controls.Add(this.ser_produitTextBox);
            this.Controls.Add(ser_capaciteLabel);
            this.Controls.Add(this.ser_capaciteTextBox);
            this.Controls.Add(ser_budgetLabel);
            this.Controls.Add(this.ser_budgetTextBox);
            this.Controls.Add(this.lb_employeTest);
            this.Controls.Add(ser_designationLabel);
            this.Controls.Add(this.ser_designationComboBox);
            this.Controls.Add(ser_idLabel);
            this.Controls.Add(this.ser_idTextBox);
            this.Controls.Add(this.bnTest);
            this.Name = "test";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.bnTest)).EndInit();
            this.bnTest.ResumeLayout(false);
            this.bnTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTest;
        private System.Windows.Forms.BindingNavigator bnTest;
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
        private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox ser_designationComboBox;
        private System.Windows.Forms.TextBox ser_idTextBox;
        private System.Windows.Forms.BindingSource bs_employe;
        private System.Windows.Forms.ListBox lb_employeTest;
        private System.Windows.Forms.TextBox ser_budgetTextBox;
        private System.Windows.Forms.TextBox ser_capaciteTextBox;
        private System.Windows.Forms.TextBox ser_produitTextBox;
    }
}