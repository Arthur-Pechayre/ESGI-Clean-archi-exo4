using System;
using System.Collections.Generic;

namespace Core
{
    public class TodoItem
    {    
        public DateTime CreatedAt {get;}
        public string Content {get;}

        public TodoItem(string content, DateTime createdAt)
        {
            Content = content;
            CreatedAt = createdAt;
        }

        public override string ToString()
        {
            return $"[{CreatedAt.ToString()}] {Content}";
        }
    }

    public class Todo
    {
        private List<TodoItem> TodoList = new List<TodoItem>(); 

        public TodoItem Add(string content)
        {
            if (content.Equals("")) {
                return null;
            }

            var neoItem = new TodoItem(content);
            TodoList.Add(neoItem);

            return neoItem;
        }

        public string List()
        {
            return string.Join<TodoItem>("\n", TodoList.ToArray());
        }

        public void MarkDone()
        {
            
        }

        public void Remove()
        {
            
        }
    }
}
