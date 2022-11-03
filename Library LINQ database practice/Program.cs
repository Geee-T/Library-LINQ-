using LibraryLINQ.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;

List<Books> books = new()
{
  new Books("The Secret History", "Donna Tart", 1992, "Mystery", "Thriller", "Crime", true),
  new Books("Percy Jackson The Lightning Thief", "Rick Riordan", 2005, "Fantasy", "Adventure", "Mythology", true),
  new Books("Percy Jackson Sea of Monster", "Rick Riordan",2006, "Fantasy", "Adventure", "Mythology", true),
  new Books("Percy Jackson The Titan's Curse", "Rick Riordan", 2007, "Fantasy", "Adventure", "Mythology", true),
  new Books("Percy Jackson The Battle of the Labyrinth", "Rick Riordan", 2008, "Fantasy", "Adventure", "Mythology", true),
  new Books("Percy Jackson The Last Olympian", "Rick Riordan", 2009, "Fantasy", "Adventure" , "Mythology", true),
  new Books("The First to Die at the End", "Adam Silvera", 2022, "LGBTQ+", "Romance", "Fantasy", true),
  new Books("If We Were Villains", "M.L Rio", 2017, "Mystery", "LGBTQ+", "Thriller", true),
  new Books("The Magicians Nephew", "C.S Lewis", 1955, "Classics", "Fantasy", "Adventure", true),
  new Books("The Lio, the Witch and the Wardrobe", "C.S Lewis", 1950, "Classics", "Fantasy", "Adventure", true),
  new Books("The Horse and His Boy", "C.S Lewis", 1954, "Classics", "Fantasy",  "Adventure", true),
  new Books("Prine Caspian", "C.S Lewis", 1951, "Classics", "Fantasy",  "Adventure", true),
  new Books("The Voyage of the Dawn Treader", "C.S Lewis", 1952, "Classics", "Fantasy",  "Adventure", true),
  new Books("The Silver Chair", "C.S Lewis", 1953, "Classics", "Fantasy",  "Adventure", true),
  new Books("The Last Battle", "C.S Lewis", 1956, "Classics", "Fantasy",  "Adventure",true),
  new Books("Cinderella Is Dead", "Kalynn Bayron", 2020, "Fantasy", "LGBTQ+", "Retellings", true),
  new Books("Afterlove", "Tanya Bryne", 2021, "LGBTQ+", "Fantasy", "Romance", true),
  new Books("Misrule", "Heather Walter", 2022, "Retellings", "Fantasy", "LGBTQ+", true),
  new Books("Malice", "Heather Walter", 2021, "Retellings", "Fantasy", "LGBTQ+", true),
  new Books("The Heartstopper Yearbook", "Alice Oseman", 2022, "Graphic Novel", "LGBTQ+", "Romance", true),
  new Books("Delilah Green Doesn't Care", "Ashley Herring Blake", 2022,"Romance", "LGBTQ+", "Adult", true),
  new Books("Not My Problem", "Ciara Smyth", 2021, "Contemporary", "LGBTQ+", "Romance", true),
  new Books("Harry Potter and the Philosophers Stone", "J.K Rowling", 1997, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Chamber of Secrets", "J.K Rowling", 1998, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Prisoner of Azkaban", "J.K Rowling", 1999, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Goblet of Fire", "J.K Rowling", 2000, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Order of the Phoenix", "J.K Rowling", 2003, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Half Blood Prince", "J.K Rowling", 2005, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Harry Potter and the Deathly Hallows", "J.K Rowling", 2007, "Fantasy", "Adventure", "Young Adult", true),
  new Books("Catfishing on Catnet", "Naomi Kritzer", 2019, "Science Fiction", "Mystery", "LGBTQ+", true),
  new Books("Count Your Lucky Stars", "Alexandria Bellefleur", 2022, "Romance", "LGBT", "Contemporary", true),
  new Books("Daisy Jones and the Six", "Taylor Jenkins Ried", 2019, "Historical", "Music", "Contemporary", true),
  new Books("Dawn of the Dead", "George A Romero", 1978, "Zombies", "Apocalyptic", "Science Fiction", true),
  new Books("Heartstopper Volume 1", "Alice Oseman", 2018, "Graphic Novel", "Romance","LGBQ+", true),
  new Books("Heartstopper Volume 2", "Alice Oseman", 2019, "Graphic Novel", "Romance", "LGBTQ+", true),
  new Books("Heartstopper Volime 3", "Alice Oseman", 2020, "Graphic Novel", "Romance", "LGBTQ+", true),
  new Books("Heartstopper Volume 4", "Alice Oseman", 2021, "Graphic Novel", "Romance", "LGBTQ+", true),
  new Books("Heroes of Olympus The Lost Hero", "Rick Riordan",2010,"Fantasy", "Adventure", "Mythology", true),
  new Books("Heroes of Olympus The Son of Neptune", "Rick Riordan", 2011, "Fantasy", "Adventure", "Mythology", true),
  new Books("Heroes of Olympus The Mark of Athena", "Rick Riordan", 2012, "Fantasy", "Adventure", "Mythology", true),
  new Books("Heroes of Olympus The House of Hades", "Rick Riordan", 2013, "Fantasy", "Adventure", "Mythology", true),
  new Books("Heroes of Olympus The Blood of Olympus", "Rick Riordan", 2014, "Fantasy", "Adventure", "Mythology", true),
  new Books("Shadow and Bone", "Leigh Bardugo", 2012, "High Fantasy", "Adventure", "Romance", true),
  new Books("Seige and Storm", "Leigh Bardugo", 2013, "High Fantasy", "Adventure", "Romance", true),
  new Books("Ruin and Rising", "Leigh Bardugo", 2014, "High Fantasy", "Adventure", "Romance", true),
  new Books("Little Women", "Louisa May Alcott", 1868, "Classics", "Historical", "Romance", true),
  new Books("A Clockwork Orange", "Anthony Burgess", 1962, "Classics", "Dystopian", "Science Fiction", true),
  new Books("One Last Stop", "Casey McQuinston", 2021, "Romance", "LGBTQ+", "Science Fiction", true),
  new Books("The Castaways", "Lucy Clarke", 2021, "Thriller", "Mystery", "Crime", true),
  new Books("Seconds", "Brian Lee O'Malley", 2014, "Graphic Novel", "Fantasy", "Adult", true),
  new Books("Scott Pilgrim's Precious Little Life", "Brian Lee O'Malley", 2004, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("Scott Pilgrim vs. The World", "Brian Lee O'Malley", 2005, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("Scott Pilgrim & The Infinite Sadness", "Brian Lee O'Malley", 2006, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("Scott Pilgrim Gets It Together", "Brian Lee O'Malley", 2007, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("Scott Pilgrim vs. The Universe","Brian Lee O'Malley", 2009, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("Scott Pilgrim's Finest Hour", "Brian Lee O'Malley", 2010, "Graphic Novel", "Fantasy", "Romance", true),
  new Books("The Song Of Achilles", "Madeline Miller", 2011, "Historical", "Fantasy", "Mythology", true),
  new Books("The Seven Husbands of Evelyn Hugo", "Taylor Jenkins Reid", 2017, "Historical", "Romance", "LGBTQ+", true),
  new Books("Murder Most Unladylike", "Robin Stevens", 2014, "Mystery", "Crime", "Historical", true),
  new Books("One of Us Is Lying", "Karen M. McManus", 2017, "Mystery", "Thriller", "Contemporary", true),
  new Books("They Both Die at the End", "Adam Silvera", 2017, "Romance", "Science Fiction", "LGBTQ+", true),
  new Books("The Perks of Being a Wallflower", "Stephen Chbosky,", 1999, "Contemporary", "Mental Health", "Realistic Fiction", true),
  new Books("Leah on the Offbeat", "Becky Albertalli", 2018, "LGBTQ+", "Romance", "Contemporary", true),
  new Books("Love Simon: Simon vs. The Homo Sapiens Agenda", "Becky Albertalli", 2015, "LGBTQ+", "Romance", "Contemporary", true),
};

Console.WriteLine("-----------------------");
Console.WriteLine("      Library App      ");
Console.WriteLine("-----------------------");
Console.WriteLine("** Fiction");
Console.WriteLine();

Console.WriteLine("Choose one of the following: ");
Console.WriteLine();
Console.WriteLine("1. Sort by Genre");
Console.WriteLine("2. Sort by Author");                     //User can choose how to sort 
int Sortby = Convert.ToInt32(Console.ReadLine());

if (Sortby == 1)
{
    Console.WriteLine("Choose one of the following genres: ");
    Console.WriteLine();
    Console.WriteLine("1. Mystery");
    Console.WriteLine("2. Thriller");
    Console.WriteLine("3. Crime");
    Console.WriteLine("4. Fantasy and High Fantasy");
    Console.WriteLine("5. Adventure");
    Console.WriteLine("6. Mythology");
    Console.WriteLine("7. LGBTQ+");
    Console.WriteLine("8. Romance");
    Console.WriteLine("9. Classics");
    Console.WriteLine("10. Retellings");
    Console.WriteLine("11. Graphic Novel");
    Console.WriteLine("12. Adult");
    Console.WriteLine("13. Contemporary");
    Console.WriteLine("14. Young Adult");
    Console.WriteLine("15. Science Fiction");
    Console.WriteLine("16. Historical");
    int GenreChoice = Convert.ToInt32(Console.ReadLine());

    if(GenreChoice == 1)        //Allows user to sort by genre
    {
        List<Books> multiwhere = books
            .Where(c => c.Genre1 == "Mystery" || c.Genre2 == "Mystery" || c.Genre3 == "Mystery")
            .ToList();

        foreach (var book in multiwhere)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 2)
    {
        List<Books> multiwhere2 = books
    .Where(c => c.Genre1 == "Thriller" || c.Genre2 == "Thriller" || c.Genre3 == "Thriller")
    .ToList();

        foreach (var book in multiwhere2)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 3)
    {
        List<Books> multiwhere3 = books
    .Where(c => c.Genre1 == "Crime" || c.Genre2 == "Crime" || c.Genre3 == "Crime")
    .ToList();

        foreach (var book in multiwhere3)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 4)
    {
        List<Books> multiwhere4 = books
    .Where(c => c.Genre1 == "Fantasy" || c.Genre2 == "Fantasy" || c.Genre3 == "Fantasy" || 
    c.Genre1 == "High Fantasy" || c.Genre2 == "High Fantasy" || c.Genre3 == "High Fantasy")
    .ToList();

        foreach (var book in multiwhere4)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 5)
    {
        List<Books> multiwhere5 = books
            .Where(c => c.Genre1 == "Adventure" || c.Genre2 == "Adventure" || c.Genre3 == "Adventure")
            .ToList();

        foreach (var book in multiwhere5)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 6)
    {
        List<Books> multiwhere6 = books
            .Where(c => c.Genre1 == "Mythology" || c.Genre2 == "Mythology" || c.Genre3 == "Mythology")
            .ToList();

        foreach (var book in multiwhere6)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 7)
    {
        List<Books> multiwhere7= books
            .Where(c => c.Genre1 == "LGBTQ+" || c.Genre2 == "LGBTQ+" || c.Genre3 == "LGBTQ+")
            .ToList();

        foreach (var book in multiwhere7)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 8)
    {
        List<Books> multiwhere8 = books
         .Where(c => c.Genre1 == "Romance" || c.Genre2 == "Romance" || c.Genre3 == "Romance")
         .ToList();

        foreach (var book in multiwhere8)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 9)
    {
        List<Books> multiwhere9 = books
         .Where(c => c.Genre1 == "Classics" || c.Genre2 == "Classics" || c.Genre3 == "Classics")
         .ToList();

        foreach (var book in multiwhere9)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 10)
    {
        List<Books> multiwhere10 = books
            .Where(c => c.Genre1 == "Retellings" || c.Genre2 == "Retellings" || c.Genre3 == "Retellings")
            .ToList();

        foreach (var book in multiwhere10)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 11)
    {
        List<Books> multiwhere11 = books
            .Where(c => c.Genre1 == "Graphic Novel" || c.Genre2 == "Graphic Novels" || c.Genre3 == "Graphic Novel")
            .ToList();

        foreach (var book in multiwhere11)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 12)
    {
        List<Books> multiwhere12 = books
            .Where(c => c.Genre1 == "Adult" || c.Genre2 == "Adult" || c.Genre3 == "Adult")
            .ToList();

        foreach (var book in multiwhere12)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 13)
    {
        List<Books> multiwhere13 = books
            .Where(c => c.Genre1 == "Contemporary" || c.Genre2 == "Contemporary" || c.Genre3 == "Contemporary")
            .ToList();

        foreach (var book in multiwhere13)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 14)
    {
        List<Books> multiwhere14 = books
            .Where(c => c.Genre1 == "Young Adult" || c.Genre2 == "Young Adult" || c.Genre3 == "Young Adult")
            .ToList();

        foreach (var book in multiwhere14)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else if (GenreChoice == 15)
    {
        List<Books> multiwhere15 = books
            .Where(c => c.Genre1 == "Science Fiction" || c.Genre2 == "Science Fiction" || c.Genre3 == "Science Fiction")
            .ToList();

        foreach (var book in multiwhere15)
            Console.WriteLine(book);
        Console.WriteLine();
    }
    else 
    {
        List<Books> multiwhere16 = books
            .Where(c => c.Genre1 == "Historical" || c.Genre2 == "Historical" || c.Genre3 == "Historical")
            .ToList();

        foreach (var book in multiwhere16)
            Console.WriteLine(book);
        Console.WriteLine();
    }

}
else
{
    Console.WriteLine("Choose one of the following authors: ");
    Console.WriteLine();
    Console.WriteLine("1. Donna Tart");
    Console.WriteLine("2. Rick Riordan");
    Console.WriteLine("3. Adam Silvera");
    Console.WriteLine("4. M.L Mio");
    Console.WriteLine("5. C.S Lewis");
    Console.WriteLine("6. Kalynn Bayron");
    Console.WriteLine("7. Tanya Bryne");
    Console.WriteLine("8. Heather Walter");
    Console.WriteLine("9. Alice Oseman");
    Console.WriteLine("10. Ciara Smyth");
    Console.WriteLine("11. J.K Rowling");
    Console.WriteLine("12. Noami Kritzer");
    Console.WriteLine("13. Alexandria Bellefleur");
    Console.WriteLine("14. Taylor Jenkins Reid");
    Console.WriteLine("15. George A Romero");
    Console.WriteLine("16. Leigh Bardugo");
    Console.WriteLine("17. Louisa May Alcott");
    Console.WriteLine("18. Anthony Burgess");
    Console.WriteLine("19. Casey McQuinston");
    Console.WriteLine("20. Lucy Clarke");
    Console.WriteLine("21. Brian Lee O'Malley");
    Console.WriteLine("22. Madeline Miller");
    Console.WriteLine("23. Robin Stevens");
    Console.WriteLine("24. Karen M. McManus");
    Console.WriteLine("25. Stephen Chbosky");
    Console.WriteLine("26. Becky Albertallis");
    int AuthorChoice = Convert.ToInt32(Console.ReadLine());

    if (AuthorChoice == 1)        //Allows user to sort by author
    {
        List<Books> author1 = books
            .Where(c => c.Author.Equals("Donna Tart"))
            .ToList();

        foreach (var book in author1)
            Console.WriteLine(book);

    }
    else if (AuthorChoice == 2)
    {
        List<Books> author2 = books
            .Where(c => c.Author.Equals("Rick Riordan"))
            .ToList();

        foreach (var book in author2)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 3)
    {
        List<Books> author3 = books
            .Where(c => c.Author.Equals("Adam Silvera"))
            .ToList();

        foreach (var book in author3)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 4)
    {
        List<Books> author4 = books
            .Where(c => c.Author.Equals("M.L Mio"))
            .ToList();

        foreach (var book in author4)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 5)
    {
        List<Books> author5 = books
            .Where(c => c.Author.Equals("C.S Lewis"))
            .ToList();

        foreach (var book in author5)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 6)
    {
        List<Books> author6 = books
            .Where(c => c.Author.Equals("Kalynn Bayron"))
            .ToList();

        foreach (var book in author6)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 7)
    {
        List<Books> author7 = books
            .Where(c => c.Author.Equals("Tanya Brynn"))
            .ToList();

        foreach (var book in author7)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 8)
    {
        List<Books> author8 = books
            .Where(c => c.Author.Equals("Heather Walter"))
            .ToList();

        foreach (var book in author8)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 9)
    {
        List<Books> author9 = books
            .Where(c => c.Author.Equals("Alice Oseman"))
            .ToList();

        foreach (var book in author9)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 10)
    {
        List<Books> author10 = books
            .Where(c => c.Author.Equals("Ciara Smyth"))
            .ToList();

        foreach (var book in author10)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 11)
    {
        List<Books> author11 = books
            .Where(c => c.Author.Equals("J.K Rowling"))
            .ToList();

        foreach (var book in author11)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 12)
    {
        List<Books> author12 = books
            .Where(c => c.Author.Equals("Noami Kritzer"))
            .ToList();

        foreach (var book in author12)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 13)
    {
        List<Books> author13 = books
            .Where(c => c.Author.Equals("Alexandria Bellefleur"))
            .ToList();

        foreach (var book in author13)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 14)
    {
        List<Books> author14 = books
            .Where(c => c.Author.Equals("Taylor Jenkins Reid"))
            .ToList();

        foreach (var book in author14)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 15)
    {
        List<Books> author15 = books
            .Where(c => c.Author.Equals("George A Romero"))
            .ToList();

        foreach (var book in author15)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 16)
    {
        List<Books> author16 = books
    .Where(c => c.Author.Equals("Leigh Bardugo"))
    .ToList();

        foreach (var book in author16)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 17)
    {
        List<Books> author17 = books
            .Where(c => c.Author.Equals("Louisa May Alcott"))
            .ToList();

        foreach (var book in author17)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 18)
    {
        List<Books> author18 = books
            .Where(c => c.Author.Equals("Anthony Burgess"))
            .ToList();

        foreach (var book in author18)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 19)
    {
        List<Books> author19 = books
            .Where(c => c.Author.Equals("Casey McQuinston"))
            .ToList();

        foreach (var book in author19)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 20)
    {
        List<Books> author20 = books
            .Where(c => c.Author.Equals("Lucy Clarke"))
            .ToList();

        foreach (var book in author20)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 21)
    {
        List<Books> author21 = books
            .Where(c => c.Author.Equals("Brian Lee O'Malley"))
            .ToList();

        foreach (var book in author21)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 22)
    {
        List<Books> author22 = books
            .Where(c => c.Author.Equals("Madeline Miller"))
            .ToList();

        foreach (var book in author22)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 23)
    {
        List<Books> author23 = books
            .Where(c => c.Author.Equals("Robin Stevens"))
            .ToList();

        foreach (var book in author23)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 24)
    {
        List<Books> author24 = books
            .Where(c => c.Author.Equals("Karen M McManus"))
            .ToList();

        foreach (var book in author24)
            Console.WriteLine(book);
    }
    else if (AuthorChoice == 25)
    {
        List<Books> author25 = books
            .Where(c => c.Author.Equals("Stephen Chbosky"))
            .ToList();

        foreach (var book in author25)
            Console.WriteLine(book);
    }
    else
    {
        List<Books> author26 = books
            .Where(c => c.Author.Equals("Becky Albertallis"))
            .ToList();

        foreach (var book in author26)
            Console.WriteLine(book);
    }
}