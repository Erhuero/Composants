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
            System.Windows.Forms.Label emp_serviceLabel;
            System.Windows.Forms.Label emp_sexeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_employe));
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
            this.emp_serviceTextBox = new System.Windows.Forms.TextBox();
            this.emp_sexeTextBox = new System.Windows.Forms.TextBox();
            emp_cadreLabel = new System.Windows.Forms.Label();
            emp_idLabel = new System.Windows.Forms.Label();
            emp_nomLabel = new System.Windows.Forms.Label();
            emp_prenomLabel = new System.Windows.Forms.Label();
            emp_salaireLabel = new System.Windows.Forms.Label();
            emp_serviceLabel = new System.Windows.Forms.Label();
            emp_sexeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_cadreLabel
            // 
            emp_cadreLabel.AutoSize = true;
            emp_cadreLabel.Location = new System.Drawing.Point(112, 89);
            emp_cadreLabel.Name = "emp_cadreLabel";
            emp_cadreLabel.Size = new System.Drawing.Size(60, 13);
            emp_cadreLabel.TabIndex = 1;
            emp_cadreLabel.Text = "emp cadre:";
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(112, 117);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(41, 13);
            emp_idLabel.TabIndex = 3;
            emp_idLabel.Text = "emp id:";
            emp_idLabel.Click += new System.EventHandler(this.emp_idLabel_Click);
            // 
            // emp_nomLabel
            // 
            emp_nomLabel.AutoSize = true;
            emp_nomLabel.Location = new System.Drawing.Point(112, 143);
            emp_nomLabel.Name = "emp_nomLabel";
            emp_nomLabel.Size = new System.Drawing.Size(53, 13);
            emp_nomLabel.TabIndex = 5;
            emp_nomLabel.Text = "emp nom:";
            // 
            // emp_prenomLabel
            // 
            emp_prenomLabel.AutoSize = true;
            emp_prenomLabel.Location = new System.Drawing.Point(112, 169);
            emp_prenomLabel.Name = "emp_prenomLabel";
            emp_prenomLabel.Size = new System.Drawing.Size(68, 13);
            emp_prenomLabel.TabIndex = 7;
            emp_prenomLabel.Text = "emp prenom:";
            // 
            // emp_salaireLabel
            // 
            emp_salaireLabel.AutoSize = true;
            emp_salaireLabel.Location = new System.Drawing.Point(112, 195);
            emp_salaireLabel.Name = "emp_salaireLabel";
            emp_salaireLabel.Size = new System.Drawing.Size(63, 13);
            emp_salaireLabel.TabIndex = 9;
            emp_salaireLabel.Text = "emp salaire:";
            // 
            // emp_serviceLabel
            // 
            emp_serviceLabel.AutoSize = true;
            emp_serviceLabel.Location = new System.Drawing.Point(112, 221);
            emp_serviceLabel.Name = "emp_serviceLabel";
            emp_serviceLabel.Size = new System.Drawing.Size(67, 13);
            emp_serviceLabel.TabIndex = 11;
            emp_serviceLabel.Text = "emp service:";
            // 
            // emp_sexeLabel
            // 
            emp_sexeLabel.AutoSize = true;
            emp_sexeLabel.Location = new System.Drawing.Point(112, 247);
            emp_sexeLabel.Name = "emp_sexeLabel";
            emp_sexeLabel.Size = new System.Drawing.Size(55, 13);
            emp_sexeLabel.TabIndex = 13;
            emp_sexeLabel.Text = "emp sexe:";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(MaintenanceComposants.Employe);
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
            this.bn.Size = new System.Drawing.Size(800, 25);
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
            this.employeBindingNavigatorSaveItem.Enabled = false;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // emp_cadreCheckBox
            // 
            this.emp_cadreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs, "emp_cadre", true));
            this.emp_cadreCheckBox.Location = new System.Drawing.Point(186, 84);
            this.emp_cadreCheckBox.Name = "emp_cadreCheckBox";
            this.emp_cadreCheckBox.Size = new System.Drawing.Size(104, 24);
            this.emp_cadreCheckBox.TabIndex = 2;
            this.emp_cadreCheckBox.Text = "checkBox1";
            this.emp_cadreCheckBox.UseVisualStyleBackColor = true;
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_id", true));
            this.emp_idTextBox.Location = new System.Drawing.Point(186, 114);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_idTextBox.TabIndex = 4;
            // 
            // emp_nomTextBox
            // 
            this.emp_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_nom", true));
            this.emp_nomTextBox.Location = new System.Drawing.Point(186, 140);
            this.emp_nomTextBox.Name = "emp_nomTextBox";
            this.emp_nomTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_nomTextBox.TabIndex = 6;
            // 
            // emp_prenomTextBox
            // 
            this.emp_prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_prenom", true));
            this.emp_prenomTextBox.Location = new System.Drawing.Point(186, 166);
            this.emp_prenomTextBox.Name = "emp_prenomTextBox";
            this.emp_prenomTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_prenomTextBox.TabIndex = 8;
            // 
            // emp_salaireTextBox
            // 
            this.emp_salaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_salaire", true));
            this.emp_salaireTextBox.Location = new System.Drawing.Point(186, 192);
            this.emp_salaireTextBox.Name = "emp_salaireTextBox";
            this.emp_salaireTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_salaireTextBox.TabIndex = 10;
            // 
            // emp_serviceTextBox
            // 
            this.emp_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_service", true));
            this.emp_serviceTextBox.Location = new System.Drawing.Point(186, 218);
            this.emp_serviceTextBox.Name = "emp_serviceTextBox";
            this.emp_serviceTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_serviceTextBox.TabIndex = 12;
            // 
            // emp_sexeTextBox
            // 
            this.emp_sexeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "emp_sexe", true));
            this.emp_sexeTextBox.Location = new System.Drawing.Point(186, 244);
            this.emp_sexeTextBox.Name = "emp_sexeTextBox";
            this.emp_sexeTextBox.Size = new System.Drawing.Size(104, 20);
            this.emp_sexeTextBox.TabIndex = 14;
            // 
            // Fm_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(emp_serviceLabel);
            this.Controls.Add(this.emp_serviceTextBox);
            this.Controls.Add(emp_sexeLabel);
            this.Controls.Add(this.emp_sexeTextBox);
            this.Controls.Add(this.bn);
            this.Name = "Fm_employe";
            this.Text = "Fm_employe";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
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
        private System.Windows.Forms.TextBox emp_serviceTextBox;
        private System.Windows.Forms.TextBox emp_sexeTextBox;
    }
}