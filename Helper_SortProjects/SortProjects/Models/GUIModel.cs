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

        public Project CurrentProject { get; set; } 
        public Project LastSelectedObject { get; set; }
        public int CurrentSelectedProjectIndex { get; set; }

        public ProjectCategory CurrentSelectedProjectCategory { get; set; }
        public int CurrentSelectedProjectCategoryIndex { get; set; }

        public ProjectCategory CurrentSelectedCategory { get; set; }
        public int CurrentSelectedCategoryIndex { get; set; }


        public GUIModel() {
            AllProjects = new List<Project>();
            AllCategories = new List<ProjectCategory>();

            CurrentProject = new Project();
            LastSelectedObject = CurrentProject;
            CurrentSelectedProjectIndex = -1;
            CurrentSelectedCategory  = new ProjectCategory("Category Name");
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