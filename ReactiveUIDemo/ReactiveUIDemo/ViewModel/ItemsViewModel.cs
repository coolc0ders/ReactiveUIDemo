using ReactiveUI;
using ReactiveUIDemo.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Text;

namespace ReactiveUIDemo.ViewModel
{
    public class ItemsViewModel : ViewModelBase
    {
        /// <summary>
        /// Reactive List https://reactiveui.net/docs/handbook/collections/reactive-list
        /// </summary>
        ReactiveList<Todo> _todos;
        public ReactiveList<Todo> Todos
        {
            get => _todos;
            set => this.RaiseAndSetIfChanged(ref _todos, value);
        }
        private Todo _selectedTodo;
        public Todo SelectedTodo
        {
            get => _selectedTodo; 
            set => this.RaiseAndSetIfChanged(ref _selectedTodo , value);
        }


        public ItemsViewModel(IScreen hostScreen = null) : base(hostScreen)
        {
            Todos = new ReactiveList<Todo>();

            Todos.Add(new Todo { IsDone = false, Title = "Go to Sleep" });
            Todos.Add(new Todo { IsDone = false, Title = "Go get some dinner" });
            Todos.Add(new Todo { IsDone = false, Title = "Watch GOT" });
            Todos.Add(new Todo { IsDone = false, Title = "Code code and code!!!!" });

            Todos.ItemChanged.Subscribe(
                x =>
                {
                    Debug.WriteLine("Item Changed");
                    ;
                });

            ///Lets detect when ever a todo Item is marked as done 
            ///IF it is, it is sent to the bottom of the list
            ///Else nothing happens
            Todos.ItemChanged.Where(x => x.PropertyName == "IsDone" && x.Sender.IsDone)
                .Select(x => x.Sender)
                .Subscribe(x =>
               {
                   if (x.IsDone)
                   {
                       Debug.WriteLine("Item Isdone Changed");
                       Todos.Remove(x);
                       //Todos.Add(x);
                   }
               });
        }
    }
}
