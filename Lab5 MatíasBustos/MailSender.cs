﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_MatíasBustos
{
    class MailSender
    {
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
           
            //Disparo del evento de Email enviado 
            OnEmailSent();


        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }


        public delegate void EmailSentEventHandler(object source, EventArgs args);

        public event EmailSentEventHandler EmailSent;

        protected virtual void OnEmailSent()
        {
            //Verificacion de subscriptores
            if (EmailSent != null)
            {
                EmailSent(this, EventArgs.Empty);
            }

        }
    }
}
