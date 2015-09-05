namespace Helper_SortProjects.SortProjects.GUI {
    partial class GUIView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.groupBox_lists = new System.Windows.Forms.GroupBox();
            this.b_main_reset = new System.Windows.Forms.Button();
            this.b_main_load = new System.Windows.Forms.Button();
            this.b_main_save = new System.Windows.Forms.Button();
            this.splitContainer_lists = new System.Windows.Forms.SplitContainer();
            this.listBox_projects = new System.Windows.Forms.ListBox();
            this.listBox_categories = new System.Windows.Forms.ListBox();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.page_editProject = new System.Windows.Forms.TabPage();
            this.b_editProject_removeCategory = new System.Windows.Forms.Button();
            this.b_editProject_addCategory = new System.Windows.Forms.Button();
            this.listBox_editProject_projectCategories = new System.Windows.Forms.ListBox();
            this.checkBox_editProject_finished = new System.Windows.Forms.CheckBox();
            this.b_editProject_projectPath = new System.Windows.Forms.Button();
            this.tb_editProject_projectPath = new System.Windows.Forms.TextBox();
            this.tb_editProject_projectName = new System.Windows.Forms.TextBox();
            this.b_editProject_deleteProject = new System.Windows.Forms.Button();
            this.b_editProject_saveProject = new System.Windows.Forms.Button();
            this.b_editProject_addProject = new System.Windows.Forms.Button();
            this.page_editCategory = new System.Windows.Forms.TabPage();
            this.tb_editCategory_categoryName = new System.Windows.Forms.TextBox();
            this.b_editCategory_delete = new System.Windows.Forms.Button();
            this.b_editCategory_save = new System.Windows.Forms.Button();
            this.b_editCategory_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.groupBox_lists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_lists)).BeginInit();
            this.splitContainer_lists.Panel1.SuspendLayout();
            this.splitContainer_lists.Panel2.SuspendLayout();
            this.splitContainer_lists.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.page_editProject.SuspendLayout();
            this.page_editCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.groupBox_lists);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.tabControl_main);
            this.splitContainer_main.Size = new System.Drawing.Size(1057, 437);
            this.splitContainer_main.SplitterDistance = 417;
            this.splitContainer_main.TabIndex = 1;
            // 
            // groupBox_lists
            // 
            this.groupBox_lists.Controls.Add(this.b_main_reset);
            this.groupBox_lists.Controls.Add(this.b_main_load);
            this.groupBox_lists.Controls.Add(this.b_main_save);
            this.groupBox_lists.Controls.Add(this.splitContainer_lists);
            this.groupBox_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_lists.Location = new System.Drawing.Point(0, 0);
            this.groupBox_lists.Name = "groupBox_lists";
            this.groupBox_lists.Size = new System.Drawing.Size(417, 437);
            this.groupBox_lists.TabIndex = 0;
            this.groupBox_lists.TabStop = false;
            this.groupBox_lists.Text = "Lists";
            // 
            // b_main_reset
            // 
            this.b_main_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_main_reset.Location = new System.Drawing.Point(174, 408);
            this.b_main_reset.Name = "b_main_reset";
            this.b_main_reset.Size = new System.Drawing.Size(75, 23);
            this.b_main_reset.TabIndex = 5;
            this.b_main_reset.Text = "Reset";
            this.b_main_reset.UseVisualStyleBackColor = true;
            // 
            // b_main_load
            // 
            this.b_main_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_main_load.Location = new System.Drawing.Point(93, 408);
            this.b_main_load.Name = "b_main_load";
            this.b_main_load.Size = new System.Drawing.Size(75, 23);
            this.b_main_load.TabIndex = 4;
            this.b_main_load.Text = "Load";
            this.b_main_load.UseVisualStyleBackColor = true;
            // 
            // b_main_save
            // 
            this.b_main_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_main_save.Location = new System.Drawing.Point(12, 408);
            this.b_main_save.Name = "b_main_save";
            this.b_main_save.Size = new System.Drawing.Size(75, 23);
            this.b_main_save.TabIndex = 3;
            this.b_main_save.Text = "Save";
            this.b_main_save.UseVisualStyleBackColor = true;
            // 
            // splitContainer_lists
            // 
            this.splitContainer_lists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer_lists.Location = new System.Drawing.Point(3, 16);
            this.splitContainer_lists.Name = "splitContainer_lists";
            this.splitContainer_lists.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_lists.Panel1
            // 
            this.splitContainer_lists.Panel1.Controls.Add(this.listBox_projects);
            // 
            // splitContainer_lists.Panel2
            // 
            this.splitContainer_lists.Panel2.Controls.Add(this.listBox_categories);
            this.splitContainer_lists.Size = new System.Drawing.Size(411, 388);
            this.splitContainer_lists.SplitterDistance = 244;
            this.splitContainer_lists.TabIndex = 2;
            // 
            // listBox_projects
            // 
            this.listBox_projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_projects.FormattingEnabled = true;
            this.listBox_projects.Location = new System.Drawing.Point(0, 0);
            this.listBox_projects.Name = "listBox_projects";
            this.listBox_projects.Size = new System.Drawing.Size(411, 244);
            this.listBox_projects.TabIndex = 0;
            // 
            // listBox_categories
            // 
            this.listBox_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_categories.FormattingEnabled = true;
            this.listBox_categories.Location = new System.Drawing.Point(0, 0);
            this.listBox_categories.Name = "listBox_categories";
            this.listBox_categories.Size = new System.Drawing.Size(411, 140);
            this.listBox_categories.TabIndex = 1;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.page_editProject);
            this.tabControl_main.Controls.Add(this.page_editCategory);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(636, 437);
            this.tabControl_main.TabIndex = 0;
            // 
            // page_editProject
            // 
            this.page_editProject.Controls.Add(this.b_editProject_removeCategory);
            this.page_editProject.Controls.Add(this.b_editProject_addCategory);
            this.page_editProject.Controls.Add(this.listBox_editProject_projectCategories);
            this.page_editProject.Controls.Add(this.checkBox_editProject_finished);
            this.page_editProject.Controls.Add(this.b_editProject_projectPath);
            this.page_editProject.Controls.Add(this.tb_editProject_projectPath);
            this.page_editProject.Controls.Add(this.tb_editProject_projectName);
            this.page_editProject.Controls.Add(this.b_editProject_deleteProject);
            this.page_editProject.Controls.Add(this.b_editProject_saveProject);
            this.page_editProject.Controls.Add(this.b_editProject_addProject);
            this.page_editProject.Location = new System.Drawing.Point(4, 22);
            this.page_editProject.Name = "page_editProject";
            this.page_editProject.Size = new System.Drawing.Size(628, 411);
            this.page_editProject.TabIndex = 2;
            this.page_editProject.Text = "Edit Project";
            this.page_editProject.UseVisualStyleBackColor = true;
            // 
            // b_editProject_removeCategory
            // 
            this.b_editProject_removeCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_editProject_removeCategory.Location = new System.Drawing.Point(437, 380);
            this.b_editProject_removeCategory.Name = "b_editProject_removeCategory";
            this.b_editProject_removeCategory.Size = new System.Drawing.Size(183, 23);
            this.b_editProject_removeCategory.TabIndex = 9;
            this.b_editProject_removeCategory.Text = "Remove Category from project";
            this.b_editProject_removeCategory.UseVisualStyleBackColor = true;
            // 
            // b_editProject_addCategory
            // 
            this.b_editProject_addCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editProject_addCategory.Location = new System.Drawing.Point(298, 380);
            this.b_editProject_addCategory.Name = "b_editProject_addCategory";
            this.b_editProject_addCategory.Size = new System.Drawing.Size(133, 23);
            this.b_editProject_addCategory.TabIndex = 8;
            this.b_editProject_addCategory.Text = "Add Category to project";
            this.b_editProject_addCategory.UseVisualStyleBackColor = true;
            // 
            // listBox_editProject_projectCategories
            // 
            this.listBox_editProject_projectCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_editProject_projectCategories.FormattingEnabled = true;
            this.listBox_editProject_projectCategories.Location = new System.Drawing.Point(3, 65);
            this.listBox_editProject_projectCategories.Name = "listBox_editProject_projectCategories";
            this.listBox_editProject_projectCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_editProject_projectCategories.Size = new System.Drawing.Size(617, 303);
            this.listBox_editProject_projectCategories.TabIndex = 7;
            // 
            // checkBox_editProject_finished
            // 
            this.checkBox_editProject_finished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_editProject_finished.AutoSize = true;
            this.checkBox_editProject_finished.Location = new System.Drawing.Point(555, 7);
            this.checkBox_editProject_finished.Name = "checkBox_editProject_finished";
            this.checkBox_editProject_finished.Size = new System.Drawing.Size(65, 17);
            this.checkBox_editProject_finished.TabIndex = 6;
            this.checkBox_editProject_finished.Text = "Finished";
            this.checkBox_editProject_finished.UseVisualStyleBackColor = true;
            // 
            // b_editProject_projectPath
            // 
            this.b_editProject_projectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_editProject_projectPath.Location = new System.Drawing.Point(523, 3);
            this.b_editProject_projectPath.Name = "b_editProject_projectPath";
            this.b_editProject_projectPath.Size = new System.Drawing.Size(26, 23);
            this.b_editProject_projectPath.TabIndex = 5;
            this.b_editProject_projectPath.Text = "...";
            this.b_editProject_projectPath.UseVisualStyleBackColor = true;
            // 
            // tb_editProject_projectPath
            // 
            this.tb_editProject_projectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_editProject_projectPath.Location = new System.Drawing.Point(3, 5);
            this.tb_editProject_projectPath.Name = "tb_editProject_projectPath";
            this.tb_editProject_projectPath.Size = new System.Drawing.Size(514, 20);
            this.tb_editProject_projectPath.TabIndex = 4;
            this.tb_editProject_projectPath.Text = "Project Path";
            // 
            // tb_editProject_projectName
            // 
            this.tb_editProject_projectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_editProject_projectName.Location = new System.Drawing.Point(3, 31);
            this.tb_editProject_projectName.Name = "tb_editProject_projectName";
            this.tb_editProject_projectName.Size = new System.Drawing.Size(617, 20);
            this.tb_editProject_projectName.TabIndex = 3;
            this.tb_editProject_projectName.Text = "Project Name";
            // 
            // b_editProject_deleteProject
            // 
            this.b_editProject_deleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editProject_deleteProject.Location = new System.Drawing.Point(165, 380);
            this.b_editProject_deleteProject.Name = "b_editProject_deleteProject";
            this.b_editProject_deleteProject.Size = new System.Drawing.Size(84, 23);
            this.b_editProject_deleteProject.TabIndex = 2;
            this.b_editProject_deleteProject.Text = "Delete Project";
            this.b_editProject_deleteProject.UseVisualStyleBackColor = true;
            // 
            // b_editProject_saveProject
            // 
            this.b_editProject_saveProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editProject_saveProject.Location = new System.Drawing.Point(84, 380);
            this.b_editProject_saveProject.Name = "b_editProject_saveProject";
            this.b_editProject_saveProject.Size = new System.Drawing.Size(75, 23);
            this.b_editProject_saveProject.TabIndex = 1;
            this.b_editProject_saveProject.Text = "Edit Project";
            this.b_editProject_saveProject.UseVisualStyleBackColor = true;
            // 
            // b_editProject_addProject
            // 
            this.b_editProject_addProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editProject_addProject.Location = new System.Drawing.Point(3, 380);
            this.b_editProject_addProject.Name = "b_editProject_addProject";
            this.b_editProject_addProject.Size = new System.Drawing.Size(75, 23);
            this.b_editProject_addProject.TabIndex = 0;
            this.b_editProject_addProject.Text = "Add Project";
            this.b_editProject_addProject.UseVisualStyleBackColor = true;
            // 
            // page_editCategory
            // 
            this.page_editCategory.Controls.Add(this.tb_editCategory_categoryName);
            this.page_editCategory.Controls.Add(this.b_editCategory_delete);
            this.page_editCategory.Controls.Add(this.b_editCategory_save);
            this.page_editCategory.Controls.Add(this.b_editCategory_add);
            this.page_editCategory.Location = new System.Drawing.Point(4, 22);
            this.page_editCategory.Name = "page_editCategory";
            this.page_editCategory.Size = new System.Drawing.Size(628, 411);
            this.page_editCategory.TabIndex = 3;
            this.page_editCategory.Text = "Edit Project Category";
            this.page_editCategory.UseVisualStyleBackColor = true;
            // 
            // tb_editCategory_categoryName
            // 
            this.tb_editCategory_categoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_editCategory_categoryName.Location = new System.Drawing.Point(7, 3);
            this.tb_editCategory_categoryName.Name = "tb_editCategory_categoryName";
            this.tb_editCategory_categoryName.Size = new System.Drawing.Size(613, 20);
            this.tb_editCategory_categoryName.TabIndex = 6;
            this.tb_editCategory_categoryName.Text = "Category Name";
            // 
            // b_editCategory_delete
            // 
            this.b_editCategory_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editCategory_delete.Location = new System.Drawing.Point(188, 380);
            this.b_editCategory_delete.Name = "b_editCategory_delete";
            this.b_editCategory_delete.Size = new System.Drawing.Size(92, 23);
            this.b_editCategory_delete.TabIndex = 5;
            this.b_editCategory_delete.Text = "Delete Category";
            this.b_editCategory_delete.UseVisualStyleBackColor = true;
            // 
            // b_editCategory_save
            // 
            this.b_editCategory_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editCategory_save.Location = new System.Drawing.Point(97, 380);
            this.b_editCategory_save.Name = "b_editCategory_save";
            this.b_editCategory_save.Size = new System.Drawing.Size(85, 23);
            this.b_editCategory_save.TabIndex = 4;
            this.b_editCategory_save.Text = "Edit Category";
            this.b_editCategory_save.UseVisualStyleBackColor = true;
            // 
            // b_editCategory_add
            // 
            this.b_editCategory_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_editCategory_add.Location = new System.Drawing.Point(7, 380);
            this.b_editCategory_add.Name = "b_editCategory_add";
            this.b_editCategory_add.Size = new System.Drawing.Size(84, 23);
            this.b_editCategory_add.TabIndex = 3;
            this.b_editCategory_add.Text = "Add Category";
            this.b_editCategory_add.UseVisualStyleBackColor = true;
            // 
            // GUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 437);
            this.Controls.Add(this.splitContainer_main);
            this.Name = "GUIView";
            this.Text = "GUIView";
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.groupBox_lists.ResumeLayout(false);
            this.splitContainer_lists.Panel1.ResumeLayout(false);
            this.splitContainer_lists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_lists)).EndInit();
            this.splitContainer_lists.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.page_editProject.ResumeLayout(false);
            this.page_editProject.PerformLayout();
            this.page_editCategory.ResumeLayout(false);
            this.page_editCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.GroupBox groupBox_lists;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.ListBox listBox_projects;
        private System.Windows.Forms.SplitContainer splitContainer_lists;
        private System.Windows.Forms.ListBox listBox_categories;
        private System.Windows.Forms.TabPage page_editProject;
        private System.Windows.Forms.Button b_editProject_deleteProject;
        private System.Windows.Forms.Button b_editProject_saveProject;
        private System.Windows.Forms.Button b_editProject_addProject;
        private System.Windows.Forms.TabPage page_editCategory;
        private System.Windows.Forms.Button b_editCategory_delete;
        private System.Windows.Forms.Button b_editCategory_save;
        private System.Windows.Forms.Button b_editCategory_add;
        private System.Windows.Forms.TextBox tb_editCategory_categoryName;
        private System.Windows.Forms.CheckBox checkBox_editProject_finished;
        private System.Windows.Forms.Button b_editProject_projectPath;
        private System.Windows.Forms.TextBox tb_editProject_projectPath;
        private System.Windows.Forms.TextBox tb_editProject_projectName;
        private System.Windows.Forms.ListBox listBox_editProject_projectCategories;
        private System.Windows.Forms.Button b_editProject_removeCategory;
        private System.Windows.Forms.Button b_editProject_addCategory;
        private System.Windows.Forms.Button b_main_reset;
        private System.Windows.Forms.Button b_main_load;
        private System.Windows.Forms.Button b_main_save;
    }
}