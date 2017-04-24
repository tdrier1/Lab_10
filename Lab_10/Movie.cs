using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Movie
    {
        private string Title;
        private string Category;

        public string TitleProp{ get { return Title; } set { Title = value; } }

        public string CategoryProp{ get { return Category; } set { Category = value; } }

        public Movie(string TitleInput, string CategoryInput)
        {
            Title = TitleInput;
            Category = CategoryInput;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }

    }
}
