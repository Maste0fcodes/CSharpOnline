using System;

namespace CSharpOnline.Exercises
{
    internal class TryShoe
    {
        private Func<string, string> myFavoriteShoe;

        public TryShoe(Func<string, string> myFavoriteShoe)
        {
            this.myFavoriteShoe = myFavoriteShoe;
        }
    }
}