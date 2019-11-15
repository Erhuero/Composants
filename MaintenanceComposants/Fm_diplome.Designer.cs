namespace MaintenanceComposants
{
    partial class Fm_diplome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_diplome));
            System.Windows.Forms.Label dip_idLabel;
            System.Windows.Forms.Label dip_libelleLabel;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.diplomeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dip_idTextBox = new System.Windows.Forms.TextBox();
            this.dip_libelleTextBox = new System.Windows.Forms.TextBox();
            this.bs_employe = new System.Windows.Forms.BindingSource(this.components);
            this.lesEmployesListBox = new System.Windows.Forms.ListBox();
            dip_idLabel = new System.Windows.Forms.Label();
            dip_libelleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // diplomeBindingSource
            // 
            this.bs.DataSource = typeof(MaintenanceComposants.Diplome);
            // 
            // diplomeBindingNavigator
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
            this.diplomeBindingNavigatorSaveItem});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "diplomeBindingNavigator";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(800, 25);
            this.bn.TabIndex = 0;
            this.bn.Text = "bindingNavigator1";
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
            // diplomeBindingNavigatorSaveItem
            // 
            this.diplomeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.diplomeBindingNavigatorSaveItem.Enabled = false;
            this.diplomeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("diplomeBindingNavigatorSaveItem.Image")));
            this.diplomeBindingNavigatorSaveItem.Name = "diplomeBindingNavigatorSaveItem";
            this.diplomeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.diplomeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // dip_idLabel
            // 
            dip_idLabel.AutoSize = true;
            dip_idLabel.Location = new System.Drawing.Point(45, 57);
            dip_idLabel.Name = "dip_idLabel";
            dip_idLabel.Size = new System.Drawing.Size(35, 13);
            dip_idLabel.TabIndex = 1;
            dip_idLabel.Text = "dip id:";
            dip_idLabel.Click += new System.EventHandler(this.dip_idLabel_Click);
            // 
            // dip_idTextBox
            // 
            this.dip_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "dip_id", true));
            this.dip_idTextBox.Location = new System.Drawing.Point(104, 54);
            this.dip_idTextBox.Name = "dip_idTextBox";
            this.dip_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.dip_idTextBox.TabIndex = 2;
            this.dip_idTextBox.TextChanged += new System.EventHandler(this.dip_idTextBox_TextChanged);
            // 
            // dip_libelleLabel
            // 
            dip_libelleLabel.AutoSize = true;
            dip_libelleLabel.Location = new System.Drawing.Point(45, 83);
            dip_libelleLabel.Name = "dip_libelleLabel";
            dip_libelleLabel.Size = new System.Drawing.Size(53, 13);
            dip_libelleLabel.TabIndex = 3;
            dip_libelleLabel.Text = "dip libelle:";
            dip_libelleLabel.Click += new System.EventHandler(this.dip_libelleLabel_Click);
            // 
            // dip_libelleTextBox
            // 
            this.dip_libelleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "dip_libelle", true));
            this.dip_libelleTextBox.Location = new System.Drawing.Point(104, 80);
            this.dip_libelleTextBox.Name = "dip_libelleTextBox";
            this.dip_libelleTextBox.Size = new System.Drawing.Size(100, 20);
            this.dip_libelleTextBox.TabIndex = 4;
            this.dip_libelleTextBox.TextChanged += new System.EventHandler(this.dip_libelleTextBox_TextChanged);
            // 
            // lesEmployesBindingSource
            // 
            this.bs_employe.DataMember = "LesEmployes";
            this.bs_employe.DataSource = this.bs;
            // 
            // lesEmployesListBox
            // 
            this.lesEmployesListBox.DataSource = this.bs_employe;
            this.lesEmployesListBox.DisplayMember = "emp_nom";
            this.lesEmployesListBox.FormattingEnabled = true;
            this.lesEmployesListBox.Location = new System.Drawing.Point(48, 115);
            this.lesEmployesListBox.Name = "lesEmployesListBox";
            this.lesEmployesListBox.Size = new System.Drawing.Size(300, 212);
            this.lesEmployesListBox.TabIndex = 5;
            this.lesEmployesListBox.ValueMember = "emp_id";
            this.lesEmployesListBox.SelectedIndexChanged += new System.EventHandler(this.lesEmployesListBox_SelectedIndexChanged);
            // 
            // Fm_diplome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lesEmployesListBox);
            this.Controls.Add(dip_idLabel);
            this.Controls.Add(this.dip_idTextBox);
            this.Controls.Add(dip_libelleLabel);
            this.Controls.Add(this.dip_libelleTextBox);
            this.Controls.Add(this.bn);
            this.Name = "Fm_diplome";
            this.Text = "Fm_diplome";
            this.Load += new System.EventHandler(this.Fm_diplome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_employe)).EndInit();
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
        private System.Windows.Forms.ToolStripButton diplomeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dip_idTextBox;
        private System.Windows.Forms.TextBox dip_libelleTextBox;
        private System.Windows.Forms.BindingSource bs_employe;
        private System.Windows.Forms.ListBox lesEmployesListBox;
    }
}