using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Reflection_Demo.ViewModel.ClassForReflection;

namespace Reflection_Demo.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private readonly object[] _classObjects;

        private Dictionary<string, object> _selectedClassProperty;

        private string _selectedName;

        public MainViewModel()
        {
            _classObjects = GetObjects();
        }

        public string SelectedName
        {
            get => _selectedName;
            set
            {
                Set(ref _selectedName, value);
                var element = _classObjects.First(it => it.GetType().Name == _selectedName);
                var typeElement = element.GetType();
                var properties = typeElement.GetProperties();
                var classProperties = new Dictionary<string, object>();
                foreach (var property in properties)
                {
                    classProperties[property.Name] = property.GetValue(element);
                }

                SelectedClassProperty = classProperties;
            }
        }

        public List<string> ClassNames => _classObjects.Select(it => it.GetType().Name).ToList();

        public Dictionary<string, object> SelectedClassProperty
        {
            get => _selectedClassProperty;
            set => Set(ref _selectedClassProperty, value);
        }

        private object[] GetObjects()
        {
            var objects = new object[]
            {
                new Car("Blue", "Nissan", 210, 1350),
                new Table("Yellow", "tree", 120, 100),
                new Human("Petrov Ivan Ivanovich", 45)
            };

            return objects;
        }
    }
}
