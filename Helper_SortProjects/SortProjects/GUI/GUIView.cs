using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helper_SortProjects.SortProjects.Controller;
using Helper_SortProjects.SortProjects.Models;

namespace Helper_SortProjects.SortProjects.GUI {
    public partial class GUIView :Form {
        private GUIController _controller;

        public Boolean UpdatingList { get; private set; }

        public GUIView() {
            InitializeComponent();
        }

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
        }

        public void UpdateProjectList(GUIModel model) {
            UpdatingList = true;

            int selectedIndex = listBox_projects.SelectedIndex;
            listBox_projects.Items.Clear();

            foreach (Project project in model.AllProjects) listBox_projects.Items.Add(project);
            if(selectedIndex<listBox_projects.Items.Count) listBox_projects.SelectedIndex = selectedIndex;

            UpdatingList = false;
        }

        public void UpdateCategoryList(GUIModel model) {
            UpdatingList = true;

            int selectedIndex = listBox_categories.SelectedIndex;
            listBox_categories.Items.Clear();

            foreach(ProjectCategory project in model.AllCategories) listBox_categories.Items.Add(project);
            if(selectedIndex<listBox_categories.Items.Count) listBox_categories.SelectedIndex = selectedIndex;

            UpdatingList = false;
        }

        public void UpdateProjectCategoryList(GUIModel model) {
            UpdatingList = true;

            int selectedIndex = listBox_editProject_projectCategories.SelectedIndex;
            listBox_editProject_projectCategories.Items.Clear();

            foreach(ProjectCategory project in model.CurrentProjectCategories) listBox_editProject_projectCategories.Items.Add(project);
            if(selectedIndex<listBox_editProject_projectCategories.Items.Count) listBox_editProject_projectCategories.SelectedIndex = selectedIndex;

            UpdatingList = false;
        }

        public void UpdateEdits(GUIModel model) {
            //Project
            tb_editProject_projectName.Text = model.CurrentProjectName;
            tb_editProject_projectPath.Text = model.CurrentProjectPath;

            checkBox_editProject_finished.Checked = model.CurrentProjectFinished;


            //Category
            tb_editCategory_categoryName.Text = model.CurrentCategoryName;
        }

        public void UpdateAll(GUIModel model) {
            UpdateEdits(model);
            UpdateProjectCategoryList(model);
            UpdateCategoryList(model);
            UpdateProjectList(model);
        }
    }
}
