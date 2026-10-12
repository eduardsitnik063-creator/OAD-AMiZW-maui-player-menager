using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp3.Commands
{
    public class DeletePlayerCommand
    {
        public int Id;
        public DeletePlayerCommand(int id){
            Id = id;
        }
    }
}