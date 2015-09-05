// Project.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Helper_SortProjects.SortProjects.Models {
    [XmlType("Project")] // define Type
    [XmlInclude(typeof(Project)), XmlInclude(typeof(ProjectCategory))]  
    public class Project {
        public String ProjectName { get; set; }
        public String ProjectPath { get; set; }
        public Boolean Finished { get; set; }

        [XmlArray("CurrentProjectCategories")]
        [XmlArrayItem("ProjectCategoryObject")]
        public List<ProjectCategory> ProjectCategories { get; set; }

        /// <summary>
        /// Parameterless constructor for serialization
        /// </summary>
        public Project() : this("Project Name") {}
        /// <summary>
        /// Creates a project with optional parameters
        /// </summary>
        /// <param name="name">The name of the project</param>
        /// <param name="path">The path to the project</param>
        /// <param name="finished">true, if project is finished, else false</param>
        public Project(String name, String path = "Project Path", Boolean finished = false) : this(name, path, finished, new List<ProjectCategory>()) {}
        /// <summary>
        /// Creates a project with all necesarry data
        /// </summary>
        /// <param name="name">The name of the project</param>
        /// <param name="path">The path to the project</param>
        /// <param name="finished">true, if project is already finished, else false</param>
        /// <param name="cats">A list of project categories this project has</param>
        public Project(String name, String path, Boolean finished, List<ProjectCategory> cats) {
            ProjectPath = path;
            ProjectName = name;
            Finished = finished;
            ProjectCategories = cats;
        }
        /// <summary>
        /// Copy constructor, copies prevProjects data and creates a new Project with this data
        /// </summary>
        /// <param name="prevProject">The Project to copy</param>
        public Project(Project prevProject) {
            ProjectName = prevProject.ProjectName;
            ProjectPath = prevProject.ProjectPath;
            Finished = prevProject.Finished;
            List<ProjectCategory> oldList = prevProject.ProjectCategories;
            ProjectCategory[] cats = new ProjectCategory[oldList.Count];
            oldList.CopyTo(cats);
            ProjectCategories = cats.ToList();
        }

        public override bool Equals(object obj) {
            if(obj == null) return false;
            if(obj == this) return true;

            Project newObj = obj as Project;
            if(newObj == null) return false;

            return newObj.ProjectName == this.ProjectName && newObj.ProjectPath == this.ProjectPath;
        }

        public override string ToString() {
            return string.Format("{0} ({1})", ProjectName, ProjectPath, Finished);
        }
    }
}