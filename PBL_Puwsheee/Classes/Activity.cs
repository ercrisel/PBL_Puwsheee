using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Classes
{
    public class Activity
    {
        public Activity()
        {
            //default constructor
        }

        public Activity(int id)
        {
            //accepts the type of id
            Id = id;
        }

        private int id;
        private string category;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get
            {
                switch (id)
                {
                    case 1:
                        category = "Cooking";
                        break;
                    case 2:
                        category = "Exercising";
                        break;
                    case 3:
                        category = "Gaming";
                        break;
                    case 4:
                        category = "Music";
                        break;
                    case 5:
                        category = "Reading";
                        break;
                    case 6:
                        category = "Shopping";
                        break;
                    case 7:
                        category = "Sleeping";
                        break;
                    case 8:
                        category = "Socializing";
                        break;
                    case 9:
                        category = "Sports";
                        break;
                    case 10:
                        category = "Studying";
                        break;
                    case 11:
                        category = "Traveling";
                        break;
                    case 12:
                        category = "Watching";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                return category;
            }
        }
    }
}
