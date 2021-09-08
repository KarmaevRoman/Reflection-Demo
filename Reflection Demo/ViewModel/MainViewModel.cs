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

        private string _selectedName;

        private object _selectedItem;

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
                SelectedItem = _classObjects.First(it => it.GetType().Name == _selectedName);
            } 
        }

        public object SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);

        }

        public List<string> ClassNames => _classObjects.Select(it => it.GetType().Name).ToList();

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
