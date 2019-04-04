/*
 * ITSE 1430
 * 
 * Provides a sample implementation of a game database.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class MemoryGameDatabase : GameDatabase
    {
        protected override Game AddCore( Game game )
        {
            game.Id = ++_nextId;
            _items.Add(Clone(game));

            return game;
        }

        protected override void DeleteCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        protected override Game GetCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            //Use iterator
            //foreach (var item in _items)
            //    yield return Clone(item);

            return _items.Select(Clone);
        }

        protected override Game UpdateCore( int id, Game game )
        {
            var index = GetIndex(id);

            game.Id = id;
            var existing = _items[index];
            Clone(existing, game);

            return game;
        }

        private Game Clone( Game game )
        {
            var newGame = new Game();
            Clone(newGame, game);

            return newGame;
        }

        private void Clone( Game target, Game source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Price = source.Price;
            target.Owned = source.Owned;
            target.Completed = source.Completed;
        }

        private int GetIndex( int id )
        {
            //Can use lambda anywhere you need a function object, must be explicit on type
            //Func<Game, bool> isId = (g) => g.Id == id;

            //for (var index = 0; index < _items.Count; ++index)
            //    if (_items[index]?.Id == id)
            //        return index;

            //In here we replaced our for loop with Ienurable<T>
            //_items = all games
            // .Where = filters down to only those matching IsId
            // .FirstOrDefault = returns first of filtered items, if any
            var game = _items.Where(g => g.Id == id).FirstOrDefault(); //Lambda expression is litt;e bit different than nomal function though
            
            // Demoing anonymous type
            //var games = from g in _items
            //            where g.Id == id
            //            select new { Id = g.Id, Name = g.Name };
            //var game = games.FirstOrDefault();
            if (game != null)
                return _items.IndexOf(game);

            return -1;
        }

        private bool IsId(Game game )
        {
            return game.Id == id;
        }

        //Arrays are so 90s
        //private readonly Game[] _items = new Game[100];

        //ArrayLists are so 00s
        //private readonly ArrayList _items = new ArrayList();

        private readonly List<Game> _items = new List<Game>();

        private int _nextId = 0;
    }
}

/* March 27, 2019 - instance members and static memebers
 * Abstract base class(ABC);
 *  -add or virtual members
 *  -you can change existing members
 * IFC;
 *  -add or remove anything
 *  -change any existing signature
 * member access operator - "." - members you have access to that particular type
 * instance members and static members;
 *  static members can be use for single patterns
 *  -they are indipendent 
 *  -they can work globaly
 * type Uri for URL types
 * -you dont create then straight. so you can use uri.Create(string)
 * -instance members always need objects on left side
 * like; var uri = new Uri();
 *         uri = uri.Create(""); LHS- type.staticMember
 * static members do not have access for instance pointers(data)
 * so, they cannot access instance members so, static members can access other static members only
 * 
 * extention methods are compiler sugar; it simply change the how the method is called
 * compiler just rewrite your code for you
 * if you own a method its instance; if(own T){instance}
 * instance rules;
 * In order to be an extension method;
 * -method must be static
 * -it must be static class
 * -the first parameter must be proceed by the key work "this"
 * -have at least one parameter and the type is first parameter type for any instance
 * if you want an extension method, you can extense any type including value type
 * IEnunerable<T> - one of the most important methods in .NET framework. it has an Orderby() and it returns IEnunerable<T> with sorted
 * IEnunerable<T> - this always returns the new sets of data. always
 * ToList() -  converts IEnunerable<T> to list
 * OrderBy() is how you sort IEnunerable<T> - but there is one problem
 * *excepts a game and turns to the key - Func<Game,Key>
 * most of the IEnunerable<T> methods do not execute until you need it to(only when it needs to)
 * First() - do not use these . instead use - FirstOrDefault() -> T
 * Last() - do not use these . instead use - LastOrDefault() -> T
 * single() - do not use these . instead use - SingleOrDefault() -> T
 * any() reyurns a bool - this determine if it is empty. Count()
 * ToArray() take you IEnum<T> and return back T[]
 * Skip(int) -> IEnum<T>
 * Take(int) -> IEnum<T>
 * where() -> IEnum<T>
 * all of these are extension methods( IEnunerable extensions)
 * IEnunerable<T> will never return null. they return an empty object if they do not have anything
 */

/* April 1, 2019 - LINQ, Lambda
 * Lambda is a function expression
 * Lambda is indicated using "=>"
 * Parameters on the left if any and the expressions on the right. means they only work with functions
 * Lambdas are the only things we always use single letters for parametrs (like g)
 * If you do not crae about lamda parameter you can use just "_". it says you do not care about the parameter 
 * or you can also use no parameters for lamdas as well
 * if you need more than one statement you can use {} and you can put any statements there then u must use ; too.
 * 
 * closures
 * expresson bodies
 * 
 * LINQ
 * anonymous types. we do not know what type is but compile knows. it show with "`a"
 * anonymous type really design fpr LINQs(or links) but you can use anywhere you want.
 *
 * Example for extension method;
 * Given products(IEnumerable<Product>)
 * Get all where Price > 1000
 *  var items = products.where(x=> x.Price>1000);
 * Order by Name and Price
 *  items = items.OrderBy(x=>x.Name);
 *  items.ThenBy(x=>x.Price); //if you have more than one orderby s you can use "ThenBy". first one must be OrderBy then after that everything is ThenBy
 * only Get Id, Name and Price
 *  var finalItems = items.select(x=>new{Id=x.Id,Name=x.Name,Price=x.Price}) //{} because it is an annonymous type
 * 
 * Example for LINQ method;
 * Given products(IEnumerable<Product>)
 * Get all where Price > 1000
 *  var items = from x in products where x.Price>1000;
 * Order by Name and Price
 *  items = from x in items OrderBy x.Name, x.Price;
 * Get Id, Name and Price
 *  var finalItems = from x in items select new{Id=x.Id,Name=x.Name,Price=x.Price};
 * 
 */

