using System.Collections.Generic;
using System.Threading.Tasks;
using testgreenfish.Models;

namespace testgreenfish.Services.Interfaces
{
    public interface IRegisterServices
    {
        Email getEmail(string email);
        IList<Email> getEmails();
        void addEmail(Email email);
    }

}