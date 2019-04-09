using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GameManagerFileSystem
{
    public class FileGameDatabase : FileGameDatabase
    {
        public FileGameDatabase(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));
            if (filename == "")
                throw new ArgumentException("Filename cannot be empty.", nameof(filename));

            _filename = filename;

        }

        private readonly string _filename;

        protected override IEnumerable<Game> GetAllCore()
        {
            if (File.Exists(_filename))
            {
                //Read all at once
                foreach (var line in File.ReadAllLines(_filename))
                {
                    var game = LoadGame(line);
                    if (game != null)
                        yield return game;
                };
            };
        }

        private Game LoadGame(string line )
        {
            if (string.IsNullOrEmpty(line))
                return null;
            var fields = line.Split(',');
            if (fields.Length != 3)
                return null;

            return new Game {
                Id = Int32.Parse(fields[0]),
                Name = fields[1],
                Description = fields[2],
            };

                               }
        private string SaveGame(Game game )
        {
            return String.Join(",", game.Id, game.Name, game.description);
        }

        private void SaveGames(IEnumerable<Game> game )
        {
            //Use LINQ luke
            var lines = from game in SaveGames select SaveGame(game);
        }

        protected override Game AddCore(Game game )
        {
            var games = GetAllCore().ToList();

            //Find the largest Id and increment by 1
            if (games.Any())
                game.Id = games.Max(x => x.Id) + 1;
            else
                game.Id = 1;

            //Add to list
            games.Add(game);

            // save the games
            SaveGames(games);

            return game;
        }

        protected override Game GetCore(int id)
        {
            if (!File.Exists(_filename))
                return null;

            //Strems are very low level
            //var stream = File.Open;

            //Use a reder/writer
            var reader = File.OpenText(_filename);
            StreamReader readerAnother = File.OpenText(_filename); // same as previous line but in this one we use Streamreader

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var game = LoadGame(line);
                if (game.Id == id)
                    return game;
            };
            reader.Close();
            return null;
        }

        protected override void Deletecore(int id)
        {
            var games = GetAllCore().ToList();

            var game = games.FirstOrDefault(x => x.Id == id);
            if(game != null)
            {
                games.Remove(game);
                SaveGames(game);
            }
        }
        protected override void Updatecore( int id )
        {
            var games = GetAllCore().ToList();

            //Replace old game with new one
            var existing = games.FirstOrDefault(x => x.Id == id);
            if(existing != null)
            {
                games.Remove(existing);
                newGame.Id = id;
                games.Add(newGame);

                SaveGame(games);
            };
            return newGame;
        }
    }
}


/* April 3, 2019 - Files, using statement
 * File is static class you do not create instcances
 * file is on System.IO
 * with file there are Directory and Path
 * Path = "C:\temp\test.txt";
 * Path;
 * GetDirectoryName(path) it gives a string -- C:\Temp
 *  GetFileName(path) gives a string -- test.txt
 *  GetExtension(path->String -- .txt
 *  GetFileNameWithoutextension(path)->string -- .test
 * 
 * File;
 *  Exists(path) -> bool
 *  file read and write are HIGH LEVEL
 * if you want to read a file- ReadAllLines(str)-> String[] for text file
 *                            - ReadText(str)->string( whole document in new line as a string) for text file
 *                            - ReadAllBytes(str)->byte[] for binary file
 * if you want to write a file- WriteAllLines(str, String[])
 *                            - WriteText(str,str)
 *                            - WriteAllBytes(str,Bytes[])
 * if you want to open a file - Open(str,...)->stream
 *                            - OpenText(str)-> streamReader
 * stream is series of byte( stream of byte)
 * stream and streamReader are work with text file
 * streams are VERY VERY LOW LEVEL objects so they are very easy to mess them up
 * streams - File - stream reader/writer, network - binary stream reader/writer, IPC, Memory
 * streams has to be close when you are done with i. there is .Close() method
 * 
 * using statement requires an expression; using(expr){statements;} =(equivilant to) try{}finally{Close()}
 * using statement is designed for cleanup
 */

/*April 8, 2019 - IDisposable, ADO.NET, Connection, Command
 * IDisposable interface only one method has void Dispose();
 * this does not have close() method
 * reader.Close() - NEVER DO THIS
 * close() method is simply this - close(){Dispose()}. so you do not need to use Close() method in dispose();
 * if you do not know this, do not use. because it easily can get trouble
 * 
 *DataBase
 * Table - columns represent what and rows represent data
 *  in .NET world table is like Type, columns is like porperties, rows is like instances
 * Products - Id - int, Name - text, Price - money
 *  in .NET Product - Id, Name, Price
 * ADO.NET stands for Active Data Objects .NET
 * 
 * SQL deploy when F5 clicks output gets a one successful 
 * DB connection is a generic connection and it is sql connection and it is IDisposable
 * DB command is another sqlCommand and it is also IDisposable
 * To execute command. there are several methods - Execunuqueery() - this is does not care about the result
 * and executeScaler() execute and return back one value
 * 
 */
