using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Puwsheee.Classes
{
    public class Mood
    {
        public Mood()
        {
            //default constructor
        }
        public Mood(int rank)
        {
            Rank = rank;
        }

        private int rank;
        private string category;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string Category
        {
            get
            {
                switch (rank)
                {
                    case 0:
                        category = null;
                        break;
                    case 1:
                        category = "Angry";
                        break;
                    case 2:
                        category = "Disgusted";
                        break;
                    case 3:
                        category = "Miserable";
                        break;
                    case 4:
                        category = "Sad";
                        break;
                    case 5:
                        category = "Meh";
                        break;
                    case 6:
                        category = "Flirty";
                        break;
                    case 7:
                        category = "Contented";
                        break;
                    case 8:
                        category = "Happy";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                return category;
            }
        }
    }
}
}
