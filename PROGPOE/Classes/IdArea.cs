using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOE.Classes
{
    internal class IdArea
    {
        public Dictionary<string, string> sl = new Dictionary<string, string>()
        { 
            {"000", "Knowledge of a broad range about various subjects"},
            {"100", "The study of the human mind"},
            {"200", "Systems of faith and worship."},
            {"300", "A study around the human behaviour in its social and cultural aspects."},
            {"400", "A system of communication used by a particular country."},
            {"500", "The systematic study of the natural world through observation and experiments"},
            {"600", "Machinery and equipment developed from the application of scientific knowledge"},
            {"700", "Activities done for enjoyment"},
            {"800", "Written works, especially those considered of lasting artistic merit."},
            {"900", "The study of past events, particularly in human affairs and regional studies"},

        };

        public Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"General Knowledge", "000"},
            {"Philosophy and Psychology", "100"},
            {"Religion", "200"},
            {"Social Sciences", "300"},
            {"Languages", "400"},
            {"Science", "500"},
            {"Technology", "600"},
            {"Arts and Recreation", "700"},
            {"Literature", "800"},
            {"History and Geography", "900"},

        };


    }
}
