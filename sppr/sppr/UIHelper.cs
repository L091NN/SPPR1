using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    public partial class MainForm
    {
        SortedSet<string> errors;
        protected string checkErrorParam(string param)
        {
            try
            {
                var test = Double.Parse(textBoxA.Text);
            }
            catch(InvalidCastException e)
            {
                errors.Add(e.Message);
            }
            errors = new SortedSet<string>();
            var en = errors.GetEnumerator();
            if (en.MoveNext())
            label1.Text = en.Current;
            return "";
        }
    }
}
