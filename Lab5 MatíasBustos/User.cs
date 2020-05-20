using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_MatíasBustos
{
    class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        public virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("¿Quiere verificar su correo (escriba si o no)?\n");
            string option = Console.ReadLine();
            if (option == "si")
            {
                OnEmailVerified();
            }
        }
    }
}
