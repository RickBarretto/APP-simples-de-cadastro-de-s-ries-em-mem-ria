using System;

namespace RegisterDioApp
{
    public class Series : EntidyBase
    {
        
        // Atributes:
        private Genre Genre {get; set;}
        private string Title {get; set;}
        private string Description {get; set;}
        private int Year {get; set;}
        private bool Deleted {get; set;}

        // Constructor:
        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Description = description;
            this.Genre = genre;
            this.Deleted = false;
        }

        // Methods
        public override string ToString()
        {
            string _return = "";
            _return += "Genre: " + this.Genre + "\n";
            _return += "Title: " + this.Title + "\n";
            _return += "Description: " + this.Description + "\n";
            _return += "Launching Year: " + this.Year + "\n";
            return _return;
        }

        public string ReturnTitle()
        {
            return this.Title;
        }

        public int ReturnId()
        {
            return this.Id;
        }

        public void _Delete()
        {
            this.Deleted = true;
        }

    }
}