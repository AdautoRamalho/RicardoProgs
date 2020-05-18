using System;
using System.Collections.Generic;
using System.Text;

namespace RicardoProj.Models
{
    public class User
    {        
        public Guid Id { get; }        

        public string DisplayName { get; set; }

        public string Initials => GetFirstTwoOrLessInitials(DisplayName);
        // '=>' é o mesmo que colocar tudo isso que tem aqui em baixo
        //public string Initials
        //{
        //    get
        //    {
        //        return GetInitialsUsingMagicOfHell(DisplayName);
        //    }
        //}

        public User()
        {
            Id = Guid.NewGuid();
        }

        private string GetFirstTwoOrLessInitials(string theNameFromHell)
        {
            var len = 2;

            if (theNameFromHell.Length < 2)
                len = theNameFromHell.Length;

            return theNameFromHell.Substring(0, len);
        }
    }
}
