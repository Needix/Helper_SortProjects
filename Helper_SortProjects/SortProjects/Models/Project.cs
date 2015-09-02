// Project.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
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

        public Project() { }
        public Project(String name, String path, Boolean fin, List<ProjectCategory> cats) {
            ProjectPath = path;
            ProjectName = name;
            Finished = fin;
            ProjectCategories = cats;
        }

        public override bool Equals(object obj) {
            if(obj == null) return false;
            if(obj == this) return true;

            Project newObj = obj as Project;
            if(newObj == null) return false;

            return newObj.ProjectName == this.ProjectName &&
                newObj.ProjectPath == this.ProjectPath &&
                newObj.Finished == this.Finished &&
                newObj.ProjectCategories == this.ProjectCategories
            ;
        }

        public override string ToString() {
            return string.Format("{0} ({1})", ProjectName, ProjectPath, Finished);
        }
    }
}