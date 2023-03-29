using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.Presenter
{
    public interface ILogin
    {
        public String getUsername();
        public String getPassword();
        public void close();
        public void hide();
    }
}
