using sticky_notes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace sticky_notes.ViewModels
{
   public  class NotesViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }

        public NotesViewModel()
        {
            Notes = new ObservableCollection<Note>
            {
                new Note{Title = "Summer Fun", Text = "Without a doubt, summer is the most anticipated season of the year,and whether or not it’s your favorite.", Date = "Monday 5.55 PM"},
                new Note{Title = "Family", Text = "Family, a group of persons united by the ties of marriage,usually those of spouses, parents.", Date = "Nonember 21, 7.55 PM"},
                new Note{Title = "UX Basics", Text = "User experience (UX) focuses on having a deep understanding of users, what they need, what they value, their abilities, and also their... ", Date = "Tuesday 8.55 PM"},
                new Note{Title = "Home", Text = "A home, or domicile, is a living space used as a permanent or semi-permanent residence for an individual.", Date = "November 1, 5.55 PM"}
                //new Note{Title = "Summer Fun", Text = "Without a doubt, summer is the most anticipated season of the year,and whether or not it’s your favorite.", Date = "Monday 5.55 PM"},
                //new Note{Title = "Family", Text = "Family, a group of persons united by the ties of marriage,usually those of spouses, parents.", Date = "Nonember 21, 7.55 PM"},
                //new Note{Title = "UX Basics", Text = "User experience (UX) focuses on having a deep understanding of users, what they need, what they value, their abilities, and also their... ", Date = "Tuesday 8.55 PM"}
            };
        }
    }
}
