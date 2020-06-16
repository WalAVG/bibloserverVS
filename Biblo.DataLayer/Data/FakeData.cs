using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblo.DataLayer.Data
{
    public class FakeData
    {
        public static void EnsureSeeded(BibloDbContext bibloDbContext)
        {
            InitializeApp(bibloDbContext);
            bibloDbContext.SaveChanges();
        }
        public static void InitializeApp(BibloDbContext bibloDbContext)
        {
            //UTENTE
            if (!bibloDbContext.Users.Any())
            {
                bibloDbContext.Users.AddRange(new List<User>
                {
                    //i parametri key non è necessario inizializzarli, ci pensa il robo
                    new User { username = "gigi", pictureId = 0, email = "", password = "no", phoneNumber = "331", geolocation = "Napoli"},
                    new User { username = "roberto", pictureId = 0, email = "", password = "no", phoneNumber = "331",geolocation = "Roma"},
                    new User { username = "ascania", pictureId = 0, email = "laquila@univaq.it", password = "yes", phoneNumber = "331", geolocation = "Genova"},
                      new User { username = "rodrigo", pictureId = 0,
                        email = "rodrigo@email.com", password = "bella", phoneNumber = "331", geolocation = "Roma"},
                });
                //questo è per salvare nel db
                bibloDbContext.SaveChanges();
            }

            //ADDRESS
            if (!bibloDbContext.Addresses.Any())
            {
                bibloDbContext.Addresses.AddRange(new List<Address>
                {
                    new Address { nation = "Italy", region = "Abruzzo", city = "L'Aquila" }
                });
                bibloDbContext.SaveChanges();
            }

            //AUTHOR
            if (!bibloDbContext.Authors.Any())
            {
                bibloDbContext.Authors.AddRange(new List<Author>
                {
                    new Author { name = "gigi", pictureId = 0 },
                    new Author { name = "roberto", pictureId = 0},
                });
                bibloDbContext.SaveChanges();
            }

            //BOOK
            if (!bibloDbContext.Books.Any())
            {
                bibloDbContext.Books.AddRange(new List<Book>
                {
                    new Book { authorId = 1, title = "libro 1"},
                    new Book { authorId = 1, title = "libro 2"}
                });
                bibloDbContext.SaveChanges();
            }

            //BOARD MESSAGE
            if (!bibloDbContext.BoardMessages.Any())
            {
                bibloDbContext.BoardMessages.AddRange(new List<BoardMessage>
                {
                    new BoardMessage { text = "Questo è un messaggio", commentBoardId = 1, publishDate = new DateTime(2020, 1, 18), userId = 1},
                    new BoardMessage { text = "Questo è un altro messaggio", commentBoardId = 1, publishDate = new DateTime(2020, 1, 19), userId = 1},
                });
                bibloDbContext.SaveChanges();
            }

            //BOARD
            if (!bibloDbContext.CommentBoards.Any())
            {
                bibloDbContext.CommentBoards.AddRange(new List<CommentBoard>
                {
                    new CommentBoard { insertingId = 1},
                });
                bibloDbContext.SaveChanges();
            }

            //INSERTING
            if (!bibloDbContext.Pictures.Any())
            {
                bibloDbContext.Insertings.AddRange(new List<Inserting>
                {
                    new Inserting { userId = 1, 
                        pictureId = 0,
                        genres = "Fantasy",
                        genreSelected = "Fantasy",
                        description = "qualsiasi cosa", publishDate = new DateTime(1,1,1),
                        title = "mah" ,
                        geolocation = "Napoli"},
                     new Inserting { userId = 1,
                        pictureId = 0,
                        genres = "Fantasy, Thriller",
                        genreSelected = "Avventura",
                        description = "che non so cosa scrivere", publishDate = new DateTime(1,1,1),
                        title = "Non lo dite a nessuno",
                        geolocation = "Napoli"},
                      new Inserting { userId = 2,
                        pictureId = 0,
                        genres = "Avventura",
                        genreSelected = "Noir, Giallo",
                        description = "questo è un libro bellissimo", publishDate = new DateTime(1,1,1),
                        title = "Lalaland",
                        geolocation = "Roma"},
                });
                bibloDbContext.SaveChanges();
            }

            //PICTURE
            if (!bibloDbContext.Pictures.Any())
            {
                bibloDbContext.Pictures.AddRange(new List<Picture>
                {
                    new Picture { id = 0, url = ""},
                });
                bibloDbContext.SaveChanges();
            }

            //PRIVATE CHAT
            if (!bibloDbContext.PrivateChats.Any())
            {
                bibloDbContext.PrivateChats.AddRange(new List<PrivateChat>
                {
                    new PrivateChat { },
                    new PrivateChat { },
                });
                bibloDbContext.SaveChanges();
            }

            //PRIVATE MESSAGE
            if (!bibloDbContext.PrivateMessages.Any())
            {
                bibloDbContext.PrivateMessages.AddRange(new List<PrivateMessage>
                {
                    new PrivateMessage { text = "chatid 1 user 1", privateChatId = 1, publishDate = new DateTime(2020, 1, 18), userId = 1},
                    new PrivateMessage { text = "chatid 1 user 2", privateChatId = 1, publishDate = new DateTime(2020, 1, 19), userId = 2},
                    new PrivateMessage { text = "chatid 2 user 1", privateChatId = 2, publishDate = new DateTime(2020, 1, 19), userId = 1},
                    new PrivateMessage { text = "chatid 2 user 1", privateChatId = 2, publishDate = new DateTime(2020, 1, 19), userId = 1},
                    new PrivateMessage { text = "chatid 2 user 2", privateChatId = 2, publishDate = new DateTime(2020, 1, 19), userId = 2},
                    new PrivateMessage { text = "chatid 2 user 3", privateChatId = 2, publishDate = new DateTime(2020, 1, 19), userId = 3},
                    new PrivateMessage { text = "chatid 3 user 1", privateChatId = 3, publishDate = new DateTime(2020, 1, 19), userId = 1},
                });
                bibloDbContext.SaveChanges();
            }
        }

    }
}
