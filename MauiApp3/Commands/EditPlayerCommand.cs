using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp3.Commands
{
    public class EditPlayerCommand
    {
        public int Id;
        public string Name;
        public int Level;
        public EditPlayerCommand(int id, string name, int level)
        {
            Id = id;
            Name = name;
            Level = level;
        }
    }
}