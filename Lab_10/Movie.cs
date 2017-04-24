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
        private int Select;

        public string TitleProp{ get { return Title; } set { Title = value; } }

        public string CategoryProp{ get { return Category; } set { Category = value; } }

        public int NumSelect { get { return Select; } set { Select = value; } }

        public Movie(string TitleInput, string CategoryInput, int NumSelect)
        {
            Title = TitleInput;
            Category = CategoryInput;
            Select = NumSelect;
        }

       

    }
}
