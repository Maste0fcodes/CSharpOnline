using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson15Exercises
    {
        public void myMovieGenre(Lesson15ExerciseEnum genre)
        {
            string msg = "My favorite movie genre is ";
            switch (genre)
            {
                case Lesson15ExerciseEnum.Horror:
                    msg += Lesson15ExerciseEnum.Horror;
                    break;
                case Lesson15ExerciseEnum.Action:
                    msg += Lesson15ExerciseEnum.Action;
                    break;
                case Lesson15ExerciseEnum.Adventure:
                    msg += Lesson15ExerciseEnum.Adventure;
                    break;
                case Lesson15ExerciseEnum.Drama:
                    msg += Lesson15ExerciseEnum.Drama;
                    break;
                default:
                    msg += Lesson15ExerciseEnum.Fanasty;
                    break;
            }
            Console.WriteLine(msg);
        }

    } // end class 
} // end namespace
