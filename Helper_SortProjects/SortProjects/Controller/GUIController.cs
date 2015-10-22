// GUIController.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Diagnostics;
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
                if(View!=null) View.UpdateAll(Model);
            }
        }

        public GUIView View { get; set; }

        public Serializer Serializer { get; private set; }

        public GUIController(GUIView view) {
            Serializer = new Serializer(this);
            Model = Serializer.Deserialize();
            if (Model == null) Model = new GUIModel();

            View = view;
            View.UpdateAll(Model);
        }

        public void ButtonPress(object sender, EventArgs e) {
            Button b = (Button) sender;
            String name = b.Name;

            if(name.Contains("editProject")) {
                EditProject(name);
            } else if (name.Contains("editCategory")) {
                EditCategory(name);
            }

            View.UpdateAll(Model);
        }

        private void EditCategory(string name) {
            ProjectCategory cat = new ProjectCategory(View.GetCategoryName());
            if (Model.CurrentSelectedCategory != null) cat = new ProjectCategory(Model.CurrentSelectedCategory.CategoryName);

            if (name.Contains("add")) {
                if (Model.AllCategories.Contains(cat)) {
                    MessageBox.Show("Equal category already exists!");
                    return;
                }
                Model.AllCategories.Add(cat);
            } else if (name.Contains("save")) {
                if (Model.AllCategories.Contains(cat)) {
                    MessageBox.Show("Equal category already exists!");
                    return;
                }
                Model.AllCategories[Model.CurrentSelectedCategoryIndex] = cat;
            } else if (name.Contains("delete")) {
                if (!Model.AllCategories.Contains(cat)) return;
                Model.AllCategories.Remove(Model.CurrentSelectedCategory);
                Model.CurrentSelectedCategory = null;
            }
        }

        private void EditProject(string name) {
            if (Model.CurrentProject == null) Model.CurrentProject = Model.LastSelectedObject;

            if (name.Contains("addProject")) {
                if (Model.AllProjects.Contains(Model.CurrentProject)) {
                    MessageBox.Show("Equal project already exists!");
                    return;
                }
                Model.AllProjects.Add(new Project(Model.CurrentProject));

            } else if (name.Contains("saveProject")) {
                Project currentProject = Model.CurrentProject;
                if(Model.CurrentSelectedProjectIndex == -1) return;

                foreach (Project itProject in Model.AllProjects) {
                    if (itProject.Equals(currentProject) && !ReferenceEquals(itProject, currentProject)) {
                        MessageBox.Show("Equal project already exists!");
                        return;
                    }
                }

                Model.AllProjects[Model.CurrentSelectedProjectIndex] = currentProject;
                Model.LastSelectedObject = currentProject;
                Model.CurrentProject = null;

            } else if (name.Contains("deleteProject")) {
                if(Model.CurrentProject == null) { return; }
                if(!Model.AllProjects.Contains(Model.CurrentProject)) return;
                Model.AllProjects.Remove(Model.CurrentProject);

            } else if (name.Contains("addCategory")) {
                if(Model.CurrentSelectedCategory == null) return;
                if(Model.CurrentProject == null) return;
                if(Model.CurrentProject.ProjectCategories.Contains(Model.CurrentSelectedCategory)) return;
                if(Model.CurrentSelectedProjectIndex == -1) return;
                Model.CurrentProject.ProjectCategories.Add(Model.CurrentSelectedCategory);
                Model.AllProjects[Model.CurrentSelectedProjectIndex] = Model.CurrentProject;

            } else if (name.Contains("removeCategory")) {
                if(Model.CurrentSelectedProjectCategory == null) return;
                if(Model.CurrentProject == null) return;
                if(!Model.CurrentProject.ProjectCategories.Contains(Model.CurrentSelectedProjectCategory)) return;
                Model.CurrentProject.ProjectCategories.Remove(Model.CurrentSelectedProjectCategory);
                Model.AllProjects[Model.CurrentSelectedProjectIndex] = Model.CurrentProject;

            } else if (name.Contains("projectPath")) {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Select the project you want to add";
                if (dialog.ShowDialog() == DialogResult.OK) Model.CurrentProject.ProjectPath = dialog.SelectedPath;
            }
        }

        public void SelectedListEntryChanged(object sender, EventArgs e) {
            ListBox listBox = (ListBox) sender;
            String name = listBox.Name;
            int selectedIndex = listBox.SelectedIndex;

            if(name.Equals("listBox_projects")) {
                Model.CurrentSelectedProjectIndex = selectedIndex;
                if(selectedIndex == -1) return;

                Project selectedProject = new Project(Model.AllProjects[selectedIndex]);
                Model.CurrentProject = selectedProject;
                Model.LastSelectedObject = selectedProject;
                View.UpdateProjectCategoryList(Model);

            } else if(name.Equals("listBox_categories")) {
                Model.CurrentSelectedCategoryIndex = selectedIndex;
                if (selectedIndex == -1) return;

                ProjectCategory selectedCategory = Model.AllCategories[selectedIndex];
                Model.CurrentSelectedCategory = selectedCategory;

            } else if(name.Equals("listBox_editProject_projectCategories")) {
                Model.CurrentSelectedProjectCategoryIndex = selectedIndex;
                if(selectedIndex == -1) return;

                Model.CurrentSelectedProjectCategory = Model.CurrentProject.ProjectCategories[selectedIndex];

            } else Debug.WriteLine("Warning: Could not find action for listbox: " + name);

            View.UpdateEdits(Model); 
        }

        public void CheckBoxChecked(object sender, EventArgs e) {
            CheckBox cbox = (CheckBox)sender;
            String name = cbox.Name;
            Boolean foundAction = true;

            if(name.Contains("editProject")) {
                Project projectToChange = Model.CurrentProject;
                if(projectToChange == null) projectToChange = Model.LastSelectedObject;
                if(projectToChange == null) return;

                if(name.Contains("finished")) projectToChange.Finished = cbox.Checked;
            } else foundAction = false;

            if(!foundAction) Debug.WriteLine("Warning: Could not find action for checkbox: "+name);

            View.UpdateEdits(Model);
        }

        public void TextBoxTextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            String name = tb.Name;
            Boolean foundAction = true;
            
            if(name.Contains("editProject")) {
                Project projectToChange = Model.CurrentProject;
                if(projectToChange == null) projectToChange = Model.LastSelectedObject;
                if(projectToChange == null) return;

                if(name.Contains("projectName")) projectToChange.ProjectName = tb.Text;
                else if(name.Contains("projectPath")) projectToChange.ProjectPath = tb.Text;
                else foundAction = false;

            } else if(name.Contains("editCategory")) {
                if(Model.CurrentSelectedCategory==null) Model.CurrentSelectedCategory = new ProjectCategory(tb.Text);
                if(name.Contains("categoryName")) Model.CurrentSelectedCategory.CategoryName = tb.Text;
                else foundAction = false;

            } else foundAction = false;

            if(!foundAction) Debug.WriteLine("Warning: Could not find action for textbox: "+name);

            View.UpdateEdits(Model);
        }
    }
}