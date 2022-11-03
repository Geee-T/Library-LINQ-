using System;


namespace LibraryLINQ.Data
{
    public class Books
    {
        public Books (string name, string author, int publicationyear, string genre1, string genre2, string genre3, bool fiction)
        {
            Name = name;
            Author = author;
            PublicationYear = publicationyear;
            Genre1 = genre1;
            Genre2 = genre2;
            Genre3 = genre3;
            Fiction = fiction;   
        }

        public string Name { get; set; }
        public string Author { get; set; }  
        int PublicationYear { get; set; }   
        public string Genre1 { get; set; }     
        public string Genre2 { get; set; } 
        public string Genre3 { get; set; }

        bool Fiction { get; set; }

        public override string? ToString()
        {
            return Name + " " + "By " + Author + " " + PublicationYear + " " + Genre1 + " " + Genre2 + " " + Genre3+ " " +(Fiction ? "**" : "");
        }
    }
}
