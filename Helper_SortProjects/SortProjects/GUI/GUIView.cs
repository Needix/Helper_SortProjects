using System;
using System.Diagnostics;
using System.Windows.Forms;
using Helper_SortProjects.SortProjects.Controller;
using Helper_SortProjects.SortProjects.Models;

namespace Helper_SortProjects.SortProjects.GUI {
    public partial class GUIView :Form {
        private GUIController _controller;

        public GUIView() {
            InitializeComponent();
        }

        //BIGTODO: Replace project ListBox with "real" sort option (ListView with collapse/expand option?)
        public void AddListener(GUIController controller) {
            _controller = controller;

            RegisterCustomEvents();
        }

        private void RegisterCustomEvents() {
            listBox_projects.SelectedIndexChanged += _controller.SelectedListEntryChanged;
            listBox_editProject_projectCategories.SelectedIndexChanged += _controller.SelectedListEntryChanged;
            listBox_categories.SelectedIndexChanged += _controller.SelectedListEntryChanged;

            b_main_save.Click += _controller.Serializer.Save;
            b_main_load.Click += _controller.Serializer.Load;
            b_main_reset.Click += _controller.Serializer.Reset;
            b_editProject_addProject.Click += _controller.ButtonPress;
            b_editProject_deleteProject.Click += _controller.ButtonPress;
            b_editProject_saveProject.Click += _controller.ButtonPress;
            b_editProject_projectPath.Click += _controller.ButtonPress;
            b_editProject_addCategory.Click += _controller.ButtonPress;
            b_editProject_removeCategory.Click += _controller.ButtonPress;
            b_editCategory_add.Click += _controller.ButtonPress;
            b_editCategory_delete.Click += _controller.ButtonPress;
            b_editCategory_save.Click += _controller.ButtonPress;

            checkBox_editProject_finished.CheckedChanged += _controller.CheckBoxChecked;

            tb_editProject_projectName.TextChanged += _controller.TextBoxTextChanged;
            tb_editProject_projectPath.TextChanged += _controller.TextBoxTextChanged;
            tb_editCategory_categoryName.TextChanged += _controller.TextBoxTextChanged;

            this.Closing += OnClosing;
        }

        public void UpdateProjectList(GUIModel model) {
            int selectedIndex = listBox_projects.SelectedIndex;
            listBox_projects.Items.Clear();

            foreach (Project project in model.AllProjects) listBox_projects.Items.Add(project);
            if(selectedIndex<listBox_projects.Items.Count) listBox_projects.SelectedIndex = selectedIndex;
        }

        public void UpdateCategoryList(GUIModel model) {
            int selectedIndex = listBox_categories.SelectedIndex;
            listBox_categories.Items.Clear();

            foreach(ProjectCategory project in model.AllCategories) listBox_categories.Items.Add(project);
            if(selectedIndex<listBox_categories.Items.Count) listBox_categories.SelectedIndex = selectedIndex;
        }

        public void UpdateProjectCategoryList(GUIModel model) {
            int selectedIndex = listBox_editProject_projectCategories.SelectedIndex;
            listBox_editProject_projectCategories.Items.Clear();

            if(model.CurrentProject == null) return;
            foreach(ProjectCategory project in model.CurrentProject.ProjectCategories) listBox_editProject_projectCategories.Items.Add(project);
            if(selectedIndex<listBox_editProject_projectCategories.Items.Count) listBox_editProject_projectCategories.SelectedIndex = selectedIndex;
        }

        public void UpdateEdits(GUIModel model) {
            //Project
            if (model.CurrentProject == null) return;
            tb_editProject_projectName.Text = model.CurrentProject.ProjectName;
            tb_editProject_projectPath.Text = model.CurrentProject.ProjectPath;

            checkBox_editProject_finished.Checked = model.CurrentProject.Finished;


            //Category
            if (model.CurrentSelectedCategory == null) return;
            tb_editCategory_categoryName.Text = model.CurrentSelectedCategory.CategoryName;
        }

        public void UpdateAll(GUIModel model) {
            UpdateEdits(model);
            UpdateProjectCategoryList(model);
            UpdateCategoryList(model);
            UpdateProjectList(model);
        }

        private void OnClosing(object sender, EventArgs e) {
            _controller.Serializer.Serialize(_controller.Model);
        }

        public String GetCategoryName() {
            return tb_editCategory_categoryName.Text;
        }
    }
}
