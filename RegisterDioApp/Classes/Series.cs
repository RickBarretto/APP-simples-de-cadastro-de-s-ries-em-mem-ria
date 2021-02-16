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

        // Constructor:
        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Description = description;
            this.Genre = genre;
        }

        public override string ToString()
        {
            string _return = "";
            _return += "Genre: " + this.Genre + Enviroment.NewLine;
            _return += "Title: " + this.Title + Enviroment.NewLine;
            _return += "Description: " + this.Description + Enviroment.NewLine;
            _return += "Launching Year: " + this.Year + Enviroment.NewLine;
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

    }
}