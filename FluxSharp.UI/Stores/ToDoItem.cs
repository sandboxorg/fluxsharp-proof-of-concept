﻿namespace FluxSharp.Stores
{
    public class ToDoItem
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public bool IsComplete { get; set; }
        public bool IsEditable { get; set; }
    }
}