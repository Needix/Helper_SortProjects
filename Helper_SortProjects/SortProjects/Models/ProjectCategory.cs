// ProjectCategory.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Xml.Serialization;

namespace Helper_SortProjects.SortProjects.Models {
    [XmlType("ProjectCategory")] // define Type
    [XmlInclude(typeof(Project)), XmlInclude(typeof(ProjectCategory))]  
    public class ProjectCategory {
        public String CategoryName { get; set; }

        /// <summary>
        /// Parameterless constructor for serialization
        /// </summary>
        public ProjectCategory() { CategoryName = "Category Name"; }
        public ProjectCategory(String name) {
            CategoryName = name;
        }

        public Boolean LogicalIdentical(ProjectCategory project) {
            if(project == null) return false;
            if(project == this) return true;

            return project.CategoryName == this.CategoryName;
        }

        public override bool Equals(object obj) {
            if(obj == null) return false;
            if(obj == this) return true;

            ProjectCategory newObj = obj as ProjectCategory;
            if(newObj == null) return false;

            return newObj.CategoryName == this.CategoryName;
        }

        public override string ToString() {
            return CategoryName;
        }
    }
}