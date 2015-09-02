// GUIController.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Helper_SortProjects.SortProjects.GUI;
using Helper_SortProjects.SortProjects.Models;

namespace Helper_SortProjects.SortProjects.Controller {
    public class GUIController {
        private GUIModel _model;
        public GUIModel Model {
            get { return _model; }
            set {
                _model = value;
                View.UpdateAll(Model);
            }
        }

        public GUIView View { get; set; }

        public Serializer Serializer { get; private set; }

        public GUIController(GUIView view) {
            View = view;
            Model = Serializer.Deserialize();
            if (Model == null) {
                Model = new GUIModel();
                InitModel();
            }

            View.UpdateAll(Model);

            Serializer = new Serializer(this);
        }

        private void InitModel() {
            Model.CurrentProjectName = "Project Name";
            Model.CurrentProjectPath = "Project Path";
            Model.CurrentCategoryName = "Category Name";
        }

        public void ButtonPress(object sender, EventArgs e) {
            Button b = (Button) sender;
            String name = b.Name;
            Boolean foundAction = true;

            if (name.Contains("editProject")) {
                Project newProject = new Project(Model.CurrentProjectName, Model.CurrentProjectPath, Model.CurrentProjectFinished, Model.CurrentProjectCategories);

                if(name.Contains("addProject")) {
                    if(Model.AllProjects.Contains(newProject)) return;
                    Model.AllProjects.Add(newProject); 
                    View.UpdateProjectList(Model);
                }  else if (name.Contains("saveProject")) {
                    if (Model.AllProjects.Contains(newProject)) return;
                    Model.AllProjects[Model.CurrentSelectedProjectIndex] = newProject; 
                    View.UpdateProjectList(Model); 
                } else if(name.Contains("deleteProject")) {
                    if(Model.CurrentSelectedProject == null) return;
                    if(!Model.AllProjects.Contains(Model.CurrentSelectedProject)) return;
                    Model.AllProjects.Remove(Model.CurrentSelectedProject);
                    View.UpdateProjectList(Model);

                } else if(name.Contains("addCategory")) { //TODO: Add/Remove category adds/removes cat to/from ALL projects!
                    if (Model.CurrentSelectedCategory == null) return;
                    Model.CurrentSelectedProject.ProjectCategories.Add(Model.CurrentSelectedCategory);
                    View.UpdateProjectCategoryList(Model);
                } else if(name.Contains("removeCategory")) {
                    if(Model.CurrentSelectedProjectCategory == null) return;
                    if(!Model.CurrentSelectedProject.ProjectCategories.Contains(Model.CurrentSelectedProjectCategory)) return;
                    Model.CurrentSelectedProject.ProjectCategories.Remove(Model.CurrentSelectedProjectCategory);
                    View.UpdateProjectCategoryList(Model);
                }

                else if (name.Contains("projectPath")) {
                    FolderBrowserDialog dig = new FolderBrowserDialog();
                    dig.Description = "Select the project you want to add";
                    if (dig.ShowDialog() == DialogResult.OK) Model.CurrentProjectPath = dig.SelectedPath;
                }
                else foundAction = false;

            } else if (name.Contains("editCategory")) {
                ProjectCategory cat = new ProjectCategory(Model.CurrentCategoryName);
                if (name.Contains("add")) {
                    if (Model.AllCategories.Contains(cat)) return;
                    Model.AllCategories.Add(cat);
                } else if(name.Contains("save")) {
                    if(Model.AllCategories.Contains(cat)) return;
                    Model.AllCategories[Model.CurrentSelectedCategoryIndex] = cat;
                } else if(name.Contains("delete")) {
                    if(!Model.AllCategories.Contains(cat)) return;
                    Model.AllCategories.Remove(Model.CurrentSelectedCategory);
                } else foundAction = false;
                View.UpdateCategoryList(Model);

            } else foundAction = false;

            if(!foundAction) Debug.WriteLine("Warning: Could not find action for button: "+name);

            View.UpdateEdits(Model);
        }

        public void CheckBoxChecked(object sender, EventArgs e) {
            CheckBox cbox = (CheckBox) sender;
            String name = cbox.Name;
            Boolean foundAction = true;

            if(name.Contains("editProject")) {
                if (name.Contains("finished")) Model.CurrentProjectFinished = cbox.Checked;
            } else foundAction = false;

            if(!foundAction) Debug.WriteLine("Warning: Could not find action for checkbox: "+name);

            View.UpdateEdits(Model);
        }

        public void TextBoxTextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox) sender;
            String name = tb.Name;
            Boolean foundAction = true;

            if (name.Contains("editProject")) {
                if (name.Contains("projectName")) Model.CurrentProjectName = tb.Text;
                else if (name.Contains("projectPath")) Model.CurrentProjectPath = tb.Text;
                else foundAction = false;

            } else if (name.Contains("editCategory")) {
                if (name.Contains("categoryName")) Model.CurrentCategoryName = tb.Text;
                else foundAction = false;

            } else foundAction = false;

            if(!foundAction) Debug.WriteLine("Warning: Could not find action for textbox: "+name);

            View.UpdateEdits(Model);
        }

        public void SelectedListEntryChanged(object sender, EventArgs e) {
            ListBox listBox = (ListBox) sender;
            String name = listBox.Name;
            int selectedIndex = listBox.SelectedIndex;

            if (name.Equals("listBox_projects")) {
                Model.CurrentSelectedProjectIndex = selectedIndex;
                Project selectedProject = Model.AllProjects[selectedIndex];
                Model.CurrentProjectName = selectedProject.ProjectName;
                Model.CurrentProjectPath = selectedProject.ProjectPath;
                Model.CurrentProjectFinished = selectedProject.Finished;
                Model.CurrentProjectCategories = selectedProject.ProjectCategories;
                Model.CurrentSelectedProject = selectedProject;
                if(!View.UpdatingList) View.UpdateProjectList(Model); //Prevent infinite loop

            } else if (name.Equals("listBox_categories")) {
                Model.CurrentSelectedCategoryIndex = selectedIndex;
                ProjectCategory selectedCategory = Model.AllCategories[selectedIndex];
                Model.CurrentCategoryName = selectedCategory.CategoryName;
                Model.CurrentSelectedCategory = selectedCategory;
                if(!View.UpdatingList) View.UpdateCategoryList(Model); //Prevent infinite loop

            } else if (name.Equals("listBox_editProject_projectCategories")) {
                Model.CurrentSelectedProjectCategoryIndex = selectedIndex;
                Model.CurrentSelectedProjectCategory = Model.CurrentProjectCategories[selectedIndex];
                if(!View.UpdatingList) View.UpdateProjectCategoryList(Model); //Prevent infinite loop

            } else Debug.WriteLine("Warning: Could not find action for listbox: " + name);

            if(!View.UpdatingList) View.UpdateEdits(Model); //Prevent infinite loop
        }
    }
}