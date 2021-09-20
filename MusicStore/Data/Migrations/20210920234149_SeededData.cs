using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 1, "Aaron Copland & London Symphony Orchestra" },
                    { 98, "Nicolaus Esterhazy Sinfonia" },
                    { 99, "Nirvana" },
                    { 100, "O Terço" },
                    { 101, "Olodum" },
                    { 102, "Orchestra of The Age of Enlightenment" },
                    { 103, "Os Paralamas Do Sucesso" },
                    { 97, "Nash Ensemble" },
                    { 104, "Ozzy Osbourne" },
                    { 106, "Paul D'Ianno" },
                    { 107, "Pearl Jam" },
                    { 108, "Pink Floyd" },
                    { 109, "Queen" },
                    { 110, "R.E.M." },
                    { 111, "Raul Seixas" },
                    { 105, "Page & Plant" },
                    { 96, "Motörhead" },
                    { 95, "Mötley Crüe" },
                    { 94, "Milton Nascimento" },
                    { 78, "Legião Urbana" },
                    { 79, "Lenny Kravitz" },
                    { 81, "London Symphony Orchestra & Sir Charles Mackerras" },
                    { 82, "Luciana Souza/Romero Lubambo" },
                    { 83, "Lulu Santos" },
                    { 84, "Marcos Valle" },
                    { 85, "Marillion" },
                    { 86, "Marisa Monte" },
                    { 87, "Martin Roscoe" },
                    { 88, "Maurizio Pollini" },
                    { 89, "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" },
                    { 90, "Men At Work" },
                    { 91, "Metallica" },
                    { 92, "Michael Tilson Thomas & San Francisco Symphony" },
                    { 93, "Miles Davis" },
                    { 112, "Red Hot Chili Peppers" },
                    { 113, "Roger Norrington, London Classical Players" },
                    { 114, "Royal Philharmonic Orchestra & Sir Thomas Beecham" },
                    { 115, "Rush" },
                    { 135, "The Posies" },
                    { 136, "The Rolling Stones" },
                    { 137, "The Who" },
                    { 138, "Tim Maia" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 139, "Ton Koopman" },
                    { 140, "U2" },
                    { 141, "UB40" },
                    { 142, "Van Halen" },
                    { 143, "Various Artists" },
                    { 144, "Velvet Revolver" },
                    { 145, "Vinícius De Moraes" },
                    { 146, "Wilhelm Kempff" },
                    { 147, "Yehudi Menuhin" },
                    { 148, "Yo-Yo Ma" },
                    { 149, "Zeca Pagodinho" },
                    { 134, "The Police" },
                    { 77, "Led Zeppelin" },
                    { 133, "The King's Singers" },
                    { 131, "The Cult" },
                    { 116, "Santana" },
                    { 117, "Scholars Baroque Ensemble" },
                    { 118, "Scorpions" },
                    { 119, "Sergei Prokofiev & Yuri Temirkanov" },
                    { 120, "Sir Georg Solti & Wiener Philharmoniker" },
                    { 121, "Skank" },
                    { 122, "Soundgarden" },
                    { 123, "Spyro Gyra" },
                    { 124, "Stevie Ray Vaughan & Double Trouble" },
                    { 125, "Stone Temple Pilots" },
                    { 126, "System Of A Down" },
                    { 127, "Temple of the Dog" },
                    { 128, "Terry Bozzio, Tony Levin & Steve Stevens" },
                    { 129, "The 12 Cellists of The Berlin Philharmonic" },
                    { 130, "The Black Crowes" },
                    { 132, "The Doors" },
                    { 76, "Kiss" },
                    { 80, "Les Arts Florissants & William Christie" },
                    { 74, "Julian Bream" },
                    { 21, "Black Sabbath" },
                    { 22, "Boston Symphony Orchestra & Seiji Ozawa" },
                    { 23, "Britten Sinfonia, Ivor Bolton & Lesley Garrett" },
                    { 24, "Bruce Dickinson" },
                    { 25, "Buddy Guy" },
                    { 26, "Caetano Veloso" },
                    { 27, "Cake" },
                    { 28, "Calexico" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 29, "Cássia Eller" },
                    { 30, "Chic" },
                    { 31, "Chicago Symphony Orchestra & Fritz Reiner" },
                    { 32, "Chico Buarque" },
                    { 33, "Chico Science & Nação Zumbi" },
                    { 75, "Kent Nagano and Orchestre de l'Opéra de Lyon" },
                    { 35, "Chris Cornell" },
                    { 20, "Black Label Society" },
                    { 36, "Christopher O'Riley" },
                    { 19, "Billy Cobham" },
                    { 17, "Berliner Philharmoniker & Hans Rosbaud" },
                    { 2, "Aaron Goldberg" },
                    { 3, "AC/DC" },
                    { 4, "Accept" },
                    { 5, "Adrian Leaper & Doreen de Feis" },
                    { 6, "Aerosmith" },
                    { 7, "Aisha Duo" },
                    { 8, "Alanis Morissette" },
                    { 9, "Alberto Turco & Nova Schola Gregoriana" },
                    { 10, "Alice In Chains" },
                    { 11, "Amy Winehouse" },
                    { 12, "Anita Ward" },
                    { 13, "Antônio Carlos Jobim" },
                    { 14, "Apocalyptica" },
                    { 15, "Audioslave" },
                    { 16, "Barry Wordsworth & BBC Concert Orchestra" },
                    { 18, "Berliner Philharmoniker & Herbert Von Karajan" },
                    { 37, "Cidade Negra" },
                    { 34, "Choir Of Westminster Abbey & Simon Preston" },
                    { 39, "Creedence Clearwater Revival" },
                    { 59, "Gilberto Gil" },
                    { 60, "Godsmack" },
                    { 38, "Cláudio Zoli" },
                    { 62, "Göteborgs Symfoniker & Neeme Järvi" },
                    { 63, "Guns N' Roses" },
                    { 64, "Gustav Mahler" },
                    { 65, "Incognito" },
                    { 66, "Iron Maiden" },
                    { 67, "James Levine" },
                    { 68, "Jamiroquai" },
                    { 69, "Jimi Hendrix" },
                    { 70, "Joe Satriani" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Name" },
                values: new object[,]
                {
                    { 71, "Jorge Ben" },
                    { 72, "Jota Quest" },
                    { 73, "Judas Priest" },
                    { 58, "Gerald Moore" },
                    { 57, "Funk Como Le Gusta" },
                    { 61, "Gonzaguinha" },
                    { 55, "Frank Zappa & Captain Beefheart" },
                    { 40, "David Coverdale" },
                    { 41, "Deep Purple" },
                    { 42, "Dennis Chambers" },
                    { 56, "Fretwork" },
                    { 43, "Djavan" },
                    { 44, "Donna Summer" },
                    { 46, "Ed Motta" },
                    { 45, "Dread Zeppelin" },
                    { 48, "Elis Regina" },
                    { 49, "English Concert & Trevor Pinnock" },
                    { 50, "Eric Clapton" },
                    { 51, "Eugene Ormandy" },
                    { 52, "Faith No More" },
                    { 53, "Falamansa" },
                    { 54, "Foo Fighters" },
                    { 47, "Edo de Waart & San Francisco Symphony" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 6, "Blues" },
                    { 8, "Reggae" },
                    { 7, "Latin" },
                    { 5, "Disco" },
                    { 9, "Pop" },
                    { 3, "Metal" },
                    { 2, "Jazz" },
                    { 1, "Rock" },
                    { 4, "Alternative" },
                    { 10, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "~/images/placeholder.gif", 90, 1, 8.99m, "The Best Of Men At Work" },
                    { 207, "~/images/placeholder.gif", 126, 3, 8.99m, "Mezmerize" },
                    { 18, "~/images/placeholder.gif", 15, 4, 8.99m, "Revelations" },
                    { 33, "~/images/placeholder.gif", 27, 4, 8.99m, "Cake: B-Sides and Rarities" },
                    { 34, "~/images/placeholder.gif", 28, 4, 8.99m, "Carried to Dust (Bonus Track Version)" },
                    { 41, "~/images/placeholder.gif", 35, 4, 8.99m, "Carry On" },
                    { 208, "~/images/placeholder.gif", 127, 4, 8.99m, "Temple of the Dog" },
                    { 14, "~/images/placeholder.gif", 12, 5, 8.99m, "Ring My Bell" },
                    { 36, "~/images/placeholder.gif", 30, 5, 8.99m, "Le Freak" },
                    { 62, "~/images/placeholder.gif", 44, 5, 8.99m, "MacArthur Park Suite" },
                    { 69, "~/images/placeholder.gif", 50, 6, 8.99m, "The Cream Of Clapton" },
                    { 70, "~/images/placeholder.gif", 50, 6, 8.99m, "Unplugged" },
                    { 109, "~/images/placeholder.gif", 66, 6, 8.99m, "Iron Maiden" },
                    { 171, "~/images/placeholder.gif", 104, 3, 8.99m, "Tribute" },
                    { 205, "~/images/placeholder.gif", 124, 6, 8.99m, "In Step" },
                    { 212, "~/images/placeholder.gif", 130, 6, 8.99m, "Live [Disc 2]" },
                    { 15, "~/images/placeholder.gif", 13, 7, 8.99m, "Chill: Brazil (Disc 2)" },
                    { 31, "~/images/placeholder.gif", 26, 7, 8.99m, "Prenda Minha" },
                    { 32, "~/images/placeholder.gif", 26, 7, 8.99m, "Sozinho Remix Ao Vivo" },
                    { 35, "~/images/placeholder.gif", 29, 7, 8.99m, "Cássia Eller - Sem Limite [Disc 1]" },
                    { 38, "~/images/placeholder.gif", 32, 7, 8.99m, "Minha Historia" },
                    { 39, "~/images/placeholder.gif", 33, 7, 8.99m, "Afrociberdelia" },
                    { 40, "~/images/placeholder.gif", 33, 7, 8.99m, "Da Lama Ao Caos" },
                    { 45, "~/images/placeholder.gif", 38, 7, 8.99m, "Na Pista" },
                    { 60, "~/images/placeholder.gif", 43, 7, 8.99m, "Djavan Ao Vivo - Vol. 02" },
                    { 61, "~/images/placeholder.gif", 43, 7, 8.99m, "Djavan Ao Vivo - Vol. 1" },
                    { 64, "~/images/placeholder.gif", 46, 7, 8.99m, "The Best of Ed Motta" },
                    { 211, "~/images/placeholder.gif", 130, 6, 8.99m, "Live [Disc 1]" },
                    { 161, "~/images/placeholder.gif", 96, 3, 8.99m, "Ace Of Spades" },
                    { 160, "~/images/placeholder.gif", 95, 3, 8.99m, "Motley Crue Greatest Hits" },
                    { 152, "~/images/placeholder.gif", 91, 3, 8.99m, "St. Anger" },
                    { 25, "~/images/placeholder.gif", 20, 3, 8.99m, "Alcohol Fueled Brewtality Live! [Disc 2]" },
                    { 26, "~/images/placeholder.gif", 21, 3, 8.99m, "Black Sabbath Vol. 4 (Remaster)" },
                    { 27, "~/images/placeholder.gif", 21, 3, 8.99m, "Black Sabbath" },
                    { 30, "~/images/placeholder.gif", 24, 3, 8.99m, "Chemical Wedding" },
                    { 82, "~/images/placeholder.gif", 60, 3, 8.99m, "Faceless" },
                    { 87, "~/images/placeholder.gif", 63, 3, 8.99m, "Use Your Illusion II" },
                    { 98, "~/images/placeholder.gif", 66, 3, 8.99m, "A Real Dead One" },
                    { 99, "~/images/placeholder.gif", 66, 3, 8.99m, "A Real Live One" },
                    { 100, "~/images/placeholder.gif", 66, 3, 8.99m, "Live After Death" },
                    { 101, "~/images/placeholder.gif", 66, 3, 8.99m, "No Prayer For The Dying" },
                    { 102, "~/images/placeholder.gif", 66, 3, 8.99m, "Piece Of Mind" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 103, "~/images/placeholder.gif", 66, 3, 8.99m, "Powerslave" },
                    { 104, "~/images/placeholder.gif", 66, 3, 8.99m, "Rock In Rio [CD1]" },
                    { 105, "~/images/placeholder.gif", 66, 3, 8.99m, "Rock In Rio [CD2]" },
                    { 106, "~/images/placeholder.gif", 66, 3, 8.99m, "Seventh Son of a Seventh Son" },
                    { 107, "~/images/placeholder.gif", 66, 3, 8.99m, "Somewhere in Time" },
                    { 108, "~/images/placeholder.gif", 66, 3, 8.99m, "The Number of The Beast" },
                    { 116, "~/images/placeholder.gif", 73, 3, 8.99m, "Living After Midnight" },
                    { 137, "~/images/placeholder.gif", 79, 3, 8.99m, "Greatest Hits" },
                    { 144, "~/images/placeholder.gif", 91, 3, 8.99m, "...And Justice For All" },
                    { 145, "~/images/placeholder.gif", 91, 3, 8.99m, "Black Album" },
                    { 146, "~/images/placeholder.gif", 91, 3, 8.99m, "Garage Inc. (Disc 1)" },
                    { 147, "~/images/placeholder.gif", 91, 3, 8.99m, "Garage Inc. (Disc 2)" },
                    { 148, "~/images/placeholder.gif", 91, 3, 8.99m, "Load" },
                    { 149, "~/images/placeholder.gif", 91, 3, 8.99m, "Master Of Puppets" },
                    { 150, "~/images/placeholder.gif", 91, 3, 8.99m, "ReLoad" },
                    { 151, "~/images/placeholder.gif", 91, 3, 8.99m, "Ride The Lightning" },
                    { 66, "~/images/placeholder.gif", 48, 7, 8.99m, "Elis Regina-Minha História" },
                    { 68, "~/images/placeholder.gif", 50, 7, 8.99m, "Unplugged" },
                    { 74, "~/images/placeholder.gif", 53, 7, 8.99m, "Deixa Entrar" },
                    { 79, "~/images/placeholder.gif", 57, 7, 8.99m, "Roda De Funk" },
                    { 28, "~/images/placeholder.gif", 22, 10, 8.99m, "Carmina Burana" },
                    { 29, "~/images/placeholder.gif", 23, 10, 8.99m, "A Soprano Inspired" },
                    { 37, "~/images/placeholder.gif", 31, 10, 8.99m, "Scheherazade" },
                    { 42, "~/images/placeholder.gif", 36, 10, 8.99m, "SCRIABIN: Vers la flamme" },
                    { 65, "~/images/placeholder.gif", 47, 10, 8.99m, "Adams, John: The Chairman Dances" },
                    { 67, "~/images/placeholder.gif", 49, 10, 8.99m, "Pachelbel: Canon & Gigue" },
                    { 71, "~/images/placeholder.gif", 51, 10, 8.99m, "Respighi:Pines of Rome" },
                    { 72, "~/images/placeholder.gif", 51, 10, 8.99m, "Strauss: Waltzes" },
                    { 84, "~/images/placeholder.gif", 62, 10, 8.99m, "Nielsen: The Six Symphonies" },
                    { 110, "~/images/placeholder.gif", 67, 10, 8.99m, "Mascagni: Cavalleria Rusticana" },
                    { 117, "~/images/placeholder.gif", 75, 10, 8.99m, "Weill: The Seven Deadly Sins" },
                    { 138, "~/images/placeholder.gif", 81, 10, 8.99m, "Tchaikovsky: The Nutcracker" },
                    { 143, "~/images/placeholder.gif", 87, 10, 8.99m, "Szymanowski: Piano Works, Vol. 1" },
                    { 153, "~/images/placeholder.gif", 92, 10, 8.99m, "Berlioz: Symphonie Fantastique" },
                    { 154, "~/images/placeholder.gif", 92, 10, 8.99m, "Prokofiev: Romeo & Juliet" },
                    { 162, "~/images/placeholder.gif", 97, 10, 8.99m, "Mozart: Chamber Music" },
                    { 163, "~/images/placeholder.gif", 98, 10, 8.99m, "The Best of Beethoven" },
                    { 167, "~/images/placeholder.gif", 102, 10, 8.99m, "Bach: The Brandenburg Concertos" },
                    { 191, "~/images/placeholder.gif", 113, 10, 8.99m, "Purcell: The Fairy Queen" },
                    { 192, "~/images/placeholder.gif", 114, 10, 8.99m, "Haydn: Symphonies 99 - 104" },
                    { 197, "~/images/placeholder.gif", 117, 10, 8.99m, "Handel: The Messiah (Highlights)" },
                    { 198, "~/images/placeholder.gif", 119, 10, 8.99m, "Prokofiev: Symphony No.1" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 199, "~/images/placeholder.gif", 120, 10, 8.99m, "Wagner: Favourite Overtures" },
                    { 210, "~/images/placeholder.gif", 129, 10, 8.99m, "South American Getaway" },
                    { 215, "~/images/placeholder.gif", 133, 10, 8.99m, "English Renaissance" },
                    { 224, "~/images/placeholder.gif", 139, 10, 8.99m, "Bach: Toccata & Fugue in D Minor" },
                    { 243, "~/images/placeholder.gif", 146, 10, 8.99m, "Bach: Goldberg Variations" },
                    { 22, "~/images/placeholder.gif", 18, 10, 8.99m, "Mozart: Symphonies Nos. 40 & 41" },
                    { 24, "~/images/placeholder.gif", 20, 3, 8.99m, "Alcohol Fueled Brewtality Live! [Disc 1]" },
                    { 21, "~/images/placeholder.gif", 17, 10, 8.99m, "Sibelius: Finlandia" },
                    { 8, "~/images/placeholder.gif", 5, 10, 8.99m, "Górecki: Symphony No. 3" },
                    { 80, "~/images/placeholder.gif", 59, 7, 8.99m, "Quanta Gente Veio Ver (Live)" },
                    { 83, "~/images/placeholder.gif", 61, 7, 8.99m, "Meus Momentos" },
                    { 114, "~/images/placeholder.gif", 71, 7, 8.99m, "Jorge Ben Jor 25 Anos" },
                    { 115, "~/images/placeholder.gif", 72, 7, 8.99m, "Jota Quest-1995" },
                    { 134, "~/images/placeholder.gif", 78, 7, 8.99m, "Mais Do Mesmo" },
                    { 139, "~/images/placeholder.gif", 82, 7, 8.99m, "Duos II" },
                    { 140, "~/images/placeholder.gif", 84, 7, 8.99m, "Chill: Brazil (Disc 1)" },
                    { 142, "~/images/placeholder.gif", 86, 7, 8.99m, "Barulhinho Bom" },
                    { 158, "~/images/placeholder.gif", 94, 7, 8.99m, "Milton Nascimento Ao Vivo" },
                    { 159, "~/images/placeholder.gif", 94, 7, 8.99m, "Minas" },
                    { 166, "~/images/placeholder.gif", 101, 7, 8.99m, "Olodum" },
                    { 168, "~/images/placeholder.gif", 103, 7, 8.99m, "Acústico MTV" },
                    { 169, "~/images/placeholder.gif", 103, 7, 8.99m, "Arquivo II" },
                    { 170, "~/images/placeholder.gif", 103, 7, 8.99m, "Arquivo Os Paralamas Do Sucesso" },
                    { 222, "~/images/placeholder.gif", 138, 7, 8.99m, "Serie Sem Limite (Disc 1)" },
                    { 223, "~/images/placeholder.gif", 138, 7, 8.99m, "Serie Sem Limite (Disc 2)" },
                    { 239, "~/images/placeholder.gif", 143, 7, 8.99m, "Sambas De Enredo 2001" },
                    { 240, "~/images/placeholder.gif", 143, 7, 8.99m, "Vozes do MPB" },
                    { 242, "~/images/placeholder.gif", 145, 7, 8.99m, "Vinicius De Moraes" },
                    { 246, "~/images/placeholder.gif", 149, 7, 8.99m, "Ao Vivo [IMPORT]" },
                    { 43, "~/images/placeholder.gif", 37, 8, 8.99m, "Acústico MTV [Live]" },
                    { 44, "~/images/placeholder.gif", 37, 8, 8.99m, "Cidade Negra - Hits" },
                    { 135, "~/images/placeholder.gif", 79, 8, 8.99m, "Greatest Hits" },
                    { 233, "~/images/placeholder.gif", 141, 8, 8.99m, "UB40 The Best Of - Volume Two [UK]" },
                    { 13, "~/images/placeholder.gif", 11, 9, 8.99m, "Frank" },
                    { 238, "~/images/placeholder.gif", 143, 9, 8.99m, "Axé Bahia 2001" },
                    { 2, "~/images/placeholder.gif", 1, 10, 8.99m, "A Copland Celebration, Vol. I" },
                    { 20, "~/images/placeholder.gif", 16, 10, 8.99m, "The Last Night of the Proms" },
                    { 17, "~/images/placeholder.gif", 14, 3, 8.99m, "Plays Metallica By Four Cellos" },
                    { 204, "~/images/placeholder.gif", 123, 2, 8.99m, "Morning Dance" },
                    { 203, "~/images/placeholder.gif", 123, 2, 8.99m, "Heart of the Night" },
                    { 91, "~/images/placeholder.gif", 66, 1, 8.99m, "Fear Of The Dark" },
                    { 92, "~/images/placeholder.gif", 66, 1, 8.99m, "Live At Donington 1992 (Disc 1)" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 93, "~/images/placeholder.gif", 66, 1, 8.99m, "Live At Donington 1992 (Disc 2)" },
                    { 94, "~/images/placeholder.gif", 66, 1, 8.99m, "Rock In Rio [CD2]" },
                    { 95, "~/images/placeholder.gif", 66, 1, 8.99m, "The Number of The Beast" },
                    { 96, "~/images/placeholder.gif", 66, 1, 8.99m, "The X Factor" },
                    { 97, "~/images/placeholder.gif", 66, 1, 8.99m, "Virtual XI" },
                    { 111, "~/images/placeholder.gif", 68, 1, 8.99m, "Emergency On Planet Earth" },
                    { 112, "~/images/placeholder.gif", 69, 1, 8.99m, "Are You Experienced?" },
                    { 113, "~/images/placeholder.gif", 70, 1, 8.99m, "Surfing with the Alien (Remastered)" },
                    { 118, "~/images/placeholder.gif", 76, 1, 8.99m, "Greatest Kiss" },
                    { 119, "~/images/placeholder.gif", 76, 1, 8.99m, "Unplugged [Live]" },
                    { 120, "~/images/placeholder.gif", 77, 1, 8.99m, "BBC Sessions [Disc 1] [Live]" },
                    { 121, "~/images/placeholder.gif", 77, 1, 8.99m, "BBC Sessions [Disc 2] [Live]" },
                    { 122, "~/images/placeholder.gif", 77, 1, 8.99m, "Coda" },
                    { 123, "~/images/placeholder.gif", 77, 1, 8.99m, "Houses Of The Holy" },
                    { 124, "~/images/placeholder.gif", 77, 1, 8.99m, "In Through The Out Door" },
                    { 125, "~/images/placeholder.gif", 77, 1, 8.99m, "IV" },
                    { 126, "~/images/placeholder.gif", 77, 1, 8.99m, "Led Zeppelin I" },
                    { 127, "~/images/placeholder.gif", 77, 1, 8.99m, "Led Zeppelin II" },
                    { 128, "~/images/placeholder.gif", 77, 1, 8.99m, "Led Zeppelin III" },
                    { 129, "~/images/placeholder.gif", 77, 1, 8.99m, "Physical Graffiti [Disc 1]" },
                    { 130, "~/images/placeholder.gif", 77, 1, 8.99m, "Physical Graffiti [Disc 2]" },
                    { 131, "~/images/placeholder.gif", 77, 1, 8.99m, "Presence" },
                    { 132, "~/images/placeholder.gif", 77, 1, 8.99m, "The Song Remains The Same (Disc 1)" },
                    { 133, "~/images/placeholder.gif", 77, 1, 8.99m, "The Song Remains The Same (Disc 2)" },
                    { 136, "~/images/placeholder.gif", 79, 1, 8.99m, "Greatest Hits" },
                    { 90, "~/images/placeholder.gif", 66, 1, 8.99m, "Brave New World" },
                    { 141, "~/images/placeholder.gif", 85, 1, 8.99m, "Misplaced Childhood" },
                    { 89, "~/images/placeholder.gif", 66, 1, 8.99m, "A Matter of Life and Death" },
                    { 85, "~/images/placeholder.gif", 63, 1, 8.99m, "Appetite for Destruction" },
                    { 4, "~/images/placeholder.gif", 3, 1, 8.99m, "For Those About To Rock We Salute You" },
                    { 5, "~/images/placeholder.gif", 3, 1, 8.99m, "Let There Be Rock" },
                    { 6, "~/images/placeholder.gif", 4, 1, 8.99m, "Balls to the Wall" },
                    { 7, "~/images/placeholder.gif", 4, 1, 8.99m, "Restless and Wild" },
                    { 9, "~/images/placeholder.gif", 6, 1, 8.99m, "Big Ones" },
                    { 11, "~/images/placeholder.gif", 8, 1, 8.99m, "Jagged Little Pill" },
                    { 12, "~/images/placeholder.gif", 10, 1, 8.99m, "Facelift" },
                    { 19, "~/images/placeholder.gif", 15, 1, 8.99m, "Audioslave" },
                    { 46, "~/images/placeholder.gif", 39, 1, 8.99m, "Chronicle, Vol. 1" },
                    { 47, "~/images/placeholder.gif", 39, 1, 8.99m, "Chronicle, Vol. 2" },
                    { 48, "~/images/placeholder.gif", 40, 1, 8.99m, "Into The Light" },
                    { 49, "~/images/placeholder.gif", 41, 1, 8.99m, "Come Taste The Band" },
                    { 50, "~/images/placeholder.gif", 41, 1, 8.99m, "Deep Purple In Rock" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 51, "~/images/placeholder.gif", 41, 1, 8.99m, "Fireball" },
                    { 52, "~/images/placeholder.gif", 41, 1, 8.99m, "Machine Head" },
                    { 53, "~/images/placeholder.gif", 41, 1, 8.99m, "MK III The Final Concerts [Disc 1]" },
                    { 54, "~/images/placeholder.gif", 41, 1, 8.99m, "Purpendicular" },
                    { 55, "~/images/placeholder.gif", 41, 1, 8.99m, "Slaves And Masters" },
                    { 56, "~/images/placeholder.gif", 41, 1, 8.99m, "Stormbringer" },
                    { 57, "~/images/placeholder.gif", 41, 1, 8.99m, "The Battle Rages On" },
                    { 58, "~/images/placeholder.gif", 41, 1, 8.99m, "The Final Concerts (Disc 2)" },
                    { 63, "~/images/placeholder.gif", 45, 1, 8.99m, "Un-Led-Ed" },
                    { 73, "~/images/placeholder.gif", 52, 1, 8.99m, "King For A Day Fool For A Lifetime" },
                    { 75, "~/images/placeholder.gif", 54, 1, 8.99m, "In Your Honor [Disc 1]" },
                    { 76, "~/images/placeholder.gif", 54, 1, 8.99m, "In Your Honor [Disc 2]" },
                    { 77, "~/images/placeholder.gif", 54, 1, 8.99m, "The Colour And The Shape" },
                    { 78, "~/images/placeholder.gif", 55, 1, 8.99m, "Bongo Fury" },
                    { 86, "~/images/placeholder.gif", 63, 1, 8.99m, "Use Your Illusion I" },
                    { 244, "~/images/placeholder.gif", 147, 10, 8.99m, "Bartok: Violin & Viola Concertos" },
                    { 164, "~/images/placeholder.gif", 99, 1, 8.99m, "Nevermind" },
                    { 172, "~/images/placeholder.gif", 104, 1, 8.99m, "Bark at the Moon (Remastered)" },
                    { 218, "~/images/placeholder.gif", 136, 1, 8.99m, "Hot Rocks, 1964-1971 (Disc 1)" },
                    { 219, "~/images/placeholder.gif", 136, 1, 8.99m, "No Security" },
                    { 220, "~/images/placeholder.gif", 136, 1, 8.99m, "Voodoo Lounge" },
                    { 221, "~/images/placeholder.gif", 137, 1, 8.99m, "My Generation - The Very Best Of The Who" },
                    { 225, "~/images/placeholder.gif", 140, 1, 8.99m, "Achtung Baby" },
                    { 226, "~/images/placeholder.gif", 140, 1, 8.99m, "B-Sides 1980-1990" },
                    { 227, "~/images/placeholder.gif", 140, 1, 8.99m, "How To Dismantle An Atomic Bomb" },
                    { 228, "~/images/placeholder.gif", 140, 1, 8.99m, "Pop" },
                    { 229, "~/images/placeholder.gif", 140, 1, 8.99m, "Rattle And Hum" },
                    { 230, "~/images/placeholder.gif", 140, 1, 8.99m, "The Best Of 1980-1990" },
                    { 231, "~/images/placeholder.gif", 140, 1, 8.99m, "War" },
                    { 232, "~/images/placeholder.gif", 140, 1, 8.99m, "Zooropa" },
                    { 234, "~/images/placeholder.gif", 142, 1, 8.99m, "Diver Down" },
                    { 235, "~/images/placeholder.gif", 142, 1, 8.99m, "The Best Of Van Halen, Vol. I" },
                    { 236, "~/images/placeholder.gif", 142, 1, 8.99m, "Van Halen III" },
                    { 237, "~/images/placeholder.gif", 142, 1, 8.99m, "Van Halen" },
                    { 241, "~/images/placeholder.gif", 144, 1, 8.99m, "Contraband" },
                    { 3, "~/images/placeholder.gif", 2, 2, 8.99m, "Worlds" },
                    { 10, "~/images/placeholder.gif", 7, 2, 8.99m, "Quiet Songs" },
                    { 16, "~/images/placeholder.gif", 13, 2, 8.99m, "Warner 25 Anos" },
                    { 23, "~/images/placeholder.gif", 19, 2, 8.99m, "The Best Of Billy Cobham" },
                    { 59, "~/images/placeholder.gif", 42, 2, 8.99m, "Outbreak" },
                    { 81, "~/images/placeholder.gif", 59, 2, 8.99m, "Quanta Gente Veio ver--Bônus De Carnaval" },
                    { 88, "~/images/placeholder.gif", 65, 2, 8.99m, "Blue Moods" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 155, "~/images/placeholder.gif", 93, 2, 8.99m, "Miles Ahead" },
                    { 156, "~/images/placeholder.gif", 93, 2, 8.99m, "The Essential Miles Davis [Disc 1]" },
                    { 157, "~/images/placeholder.gif", 93, 2, 8.99m, "The Essential Miles Davis [Disc 2]" },
                    { 217, "~/images/placeholder.gif", 135, 1, 8.99m, "Every Kind of Light" },
                    { 165, "~/images/placeholder.gif", 100, 1, 8.99m, "Compositores" },
                    { 216, "~/images/placeholder.gif", 134, 1, 8.99m, "The Police Greatest Hits" },
                    { 213, "~/images/placeholder.gif", 131, 1, 8.99m, "Beyond Good And Evil" },
                    { 173, "~/images/placeholder.gif", 104, 1, 8.99m, "Blizzard of Ozz" },
                    { 174, "~/images/placeholder.gif", 104, 1, 8.99m, "Diary of a Madman (Remastered)" },
                    { 175, "~/images/placeholder.gif", 104, 1, 8.99m, "No More Tears (Remastered)" },
                    { 176, "~/images/placeholder.gif", 104, 1, 8.99m, "Speak of the Devil" },
                    { 177, "~/images/placeholder.gif", 105, 1, 8.99m, "Walking Into Clarksdale" },
                    { 178, "~/images/placeholder.gif", 106, 1, 8.99m, "The Beast Live" },
                    { 179, "~/images/placeholder.gif", 107, 1, 8.99m, "Live On Two Legs [Live]" },
                    { 180, "~/images/placeholder.gif", 107, 1, 8.99m, "Riot Act" },
                    { 181, "~/images/placeholder.gif", 107, 1, 8.99m, "Ten" },
                    { 182, "~/images/placeholder.gif", 107, 1, 8.99m, "Vs." },
                    { 183, "~/images/placeholder.gif", 108, 1, 8.99m, "Dark Side Of The Moon" },
                    { 184, "~/images/placeholder.gif", 109, 1, 8.99m, "Greatest Hits I" },
                    { 185, "~/images/placeholder.gif", 109, 1, 8.99m, "Greatest Hits II" },
                    { 186, "~/images/placeholder.gif", 109, 1, 8.99m, "News Of The World" },
                    { 187, "~/images/placeholder.gif", 110, 1, 8.99m, "New Adventures In Hi-Fi" },
                    { 188, "~/images/placeholder.gif", 111, 1, 8.99m, "Raul Seixas" },
                    { 189, "~/images/placeholder.gif", 112, 1, 8.99m, "By The Way" },
                    { 190, "~/images/placeholder.gif", 112, 1, 8.99m, "Californication" },
                    { 193, "~/images/placeholder.gif", 115, 1, 8.99m, "Retrospective I (1974-1980)" },
                    { 194, "~/images/placeholder.gif", 116, 1, 8.99m, "Santana - As Years Go By" },
                    { 195, "~/images/placeholder.gif", 116, 1, 8.99m, "Santana Live" },
                    { 196, "~/images/placeholder.gif", 116, 1, 8.99m, "Supernatural" },
                    { 200, "~/images/placeholder.gif", 121, 1, 8.99m, "Maquinarama" },
                    { 201, "~/images/placeholder.gif", 121, 1, 8.99m, "O Samba Poconé" },
                    { 202, "~/images/placeholder.gif", 122, 1, 8.99m, "A-Sides" },
                    { 206, "~/images/placeholder.gif", 125, 1, 8.99m, "Core" },
                    { 209, "~/images/placeholder.gif", 128, 1, 8.99m, "[1997] Black Light Syndrome" },
                    { 214, "~/images/placeholder.gif", 132, 1, 8.99m, "The Doors" },
                    { 245, "~/images/placeholder.gif", 148, 10, 8.99m, "Bach: The Cello Suites" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10);
        }
    }
}
