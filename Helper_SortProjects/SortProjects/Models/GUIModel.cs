// GUIModel.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Helper_SortProjects.SortProjects.Controller;

namespace Helper_SortProjects.SortProjects.Models {
    [XmlRoot("GUIModel")]
    [XmlInclude(typeof(Project)), XmlInclude(typeof(ProjectCategory))] // include type class Person
    public class GUIModel {
        [XmlArray("AllProjects")]
        [XmlArrayItem("ProjectObject")]
        public List<Project> AllProjects { get; set; }
        [XmlArray("AllCategories")]
        [XmlArrayItem("CategoryObject")]
        public List<ProjectCategory> AllCategories { get; set; }

        public String CurrentProjectName { get; set; }
        public String CurrentProjectPath { get; set; }
        public Boolean CurrentProjectFinished { get; set; }
        [XmlArray("CurrentProjectCategories")]
        [XmlArrayItem("ProjectCategoryObject")]
        public List<ProjectCategory> CurrentProjectCategories { get; set; }

        public Project CurrentSelectedProject { get; set; } //TODO: Make sure CurrentSelectedProject is really selectedProject (e.g. list was reset (no entry selected) but CurrentSelectedProject is still valid (should be null) 
        public int CurrentSelectedProjectIndex { get; set; } //TODO: see above
        public ProjectCategory CurrentSelectedProjectCategory { get; set; } //TODO: see above
        public int CurrentSelectedProjectCategoryIndex { get; set; }//TODO: see above

        public String CurrentCategoryName { get; set; }
        public ProjectCategory CurrentSelectedCategory { get; set; }//TODO: see above
        public int CurrentSelectedCategoryIndex { get; set; }//TODO: see above


        public GUIModel() {
            AllProjects = new List<Project>();
            AllCategories = new List<ProjectCategory>();
            CurrentProjectCategories = new List<ProjectCategory>();
        }

        public Project GetProject(String name) {
            foreach (Project curProject in AllProjects) {
                if (curProject.ProjectName.Equals(name)) return curProject;
            }
            return null;
        }
        public ProjectCategory GetProjectCategory(String name) {
            foreach(ProjectCategory curCat in AllCategories) {
                if(curCat.CategoryName.Equals(name)) return curCat;
            }
            return null;
        }
    }
}