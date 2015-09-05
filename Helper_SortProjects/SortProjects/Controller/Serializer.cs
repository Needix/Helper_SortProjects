// Serializer.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Helper_SortProjects.SortProjects.Models;

namespace Helper_SortProjects.SortProjects.Controller {
    public class Serializer {
        private const String SAVE_PATH = "save.xml";
        private readonly GUIController _controller;

        public Serializer(GUIController controller) {
            _controller = controller;
        }

        public void Save(object sender, EventArgs e) {
            Serialize(_controller.Model);
        }

        public void Load(object sender, EventArgs e) {
            GUIModel loadedModel = Deserialize();
            if (loadedModel == null) return ;
            _controller.Model = loadedModel;
        }

        public void Reset(object sender, EventArgs e) {
            _controller.Model = new GUIModel();
        }

        /// <summary>
        /// Serializes the GUIModel
        /// </summary>
        /// <param name="model">The model to serialize</param>
        public void Serialize(GUIModel model) {
            if(File.Exists(SAVE_PATH)) File.Delete(SAVE_PATH);

            XmlSerializer serializer = new XmlSerializer(typeof(GUIModel));
            FileStream stream = new FileStream(SAVE_PATH, FileMode.Create);

            serializer.Serialize(stream, model);
            stream.Close();
        }
        /// <summary>
        /// Loads the GUIModel from the XML file and sets/replaces the model instance
        /// </summary>
        /// <returns>The loaded model, or null if loading failed</returns>
        public GUIModel Deserialize() {
            if(!File.Exists(SAVE_PATH)) return null;

            XmlSerializer serializer = new XmlSerializer(typeof (GUIModel));
            FileStream fs = new FileStream(SAVE_PATH, FileMode.Open);

            GUIModel obj = (GUIModel) serializer.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}