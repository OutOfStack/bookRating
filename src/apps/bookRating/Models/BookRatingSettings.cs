using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRating.Models
{
    /// <summary>
    ///     App configration
    /// </summary>
    public class BookRatingSettings
    {
        public GoodReadsApiSettings GoodReadsApiSettings { get; set; }
    }

    /// <summary>
    ///     Goodreads api tokens
    /// </summary>
    public class GoodReadsApiSettings
    {
        public string Key { get; set; }
        public string Secret { get; set; }
    }
}
