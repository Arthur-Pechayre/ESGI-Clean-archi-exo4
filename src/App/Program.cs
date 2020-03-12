using System;
using Core;

namespace App
{
    abstract class ACommand
    {
        public string Name {get;}
        public abstract Todo Exec(string[] args);

        public Command(string name, Func action)
        {
            this.Name = name;
            this.Action = action;
        }
    }

    class List : ACommand
    {
        List()
        {
            this.Name = "list";
        }

        public Todo Exec(Todostring[] args) 
        {
            
        }
    }

    class Program
    {
        private Todo MyTodo = new Todo();

        private ACommand[] Commands = {
            new List(),
        };

        static void Main(string[] args)
        {
            if (stringArray.Any(s => args[1].Equals(s))) {
                Console.WriteLine("Error : no comands")

                return;
            }

            
        }

        /*
        add list done remove
        */
    }
}
