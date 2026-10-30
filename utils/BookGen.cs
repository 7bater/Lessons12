using System;
using Lessons12.models;

namespace Lessons12.utils
{
    public static class BookGen
    {
        private static string[] titles = { "Кобзар", "Тіні забутих предків", "Тигролови", "Чорна рада", "Захар Беркут" };
        private static string[] authors = { "Тарас Шевченко", "Михайло Коцюбинський", "Іван Багряний", "Пантелеймон Куліш", "Іван Франко" };
        private static string[] genres = { "Поема", "Повість", "Роман", "Історичний роман", "Повість" };

        private const int MinYear = 1840;
        private const int MaxYear = 1950;
        private static Random rnd = new Random();

        public static string GenTitle() => titles[rnd.Next(0, titles.Length)];
        public static string GenAuthor() => authors[rnd.Next(0, authors.Length)];
        public static string GenGenre() => genres[rnd.Next(0, genres.Length)];
        public static int GenYear() => rnd.Next(MinYear, MaxYear);

        public static Book GenerateRandomBook()
        {
            return new Book(GenTitle(), GenAuthor(), GenGenre(), GenYear());
        }
    }
}