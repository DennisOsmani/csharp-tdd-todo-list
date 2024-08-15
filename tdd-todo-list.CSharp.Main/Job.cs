﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_Slist.CSharp.Main
{

    public enum Status
    {
        COMPLETE,
        INCOMPLETE
    }

    public class Job
{
        private readonly int id;
        private readonly string name;
        private readonly Status status;
        private readonly DateTime date;

        public Job(int id, string name, Status status, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.date = date;
        }

        public int Id { get { return id; } } 
        public string Name { get { return name; } }  
        public Status Status { get { return status; } }
        public DateTime Date { get { return date; } }

    }
}
