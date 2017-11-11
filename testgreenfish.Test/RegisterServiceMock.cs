using System.Collections.Generic;
using System.Threading.Tasks;
using testgreenfish.Models;
using testgreenfish.Data;
using testgreenfish.Services.Interfaces;
using System.Linq;

namespace testgreenfish.Test
{
    public class RegisterServicesMock : IRegisterServices
    {
        private readonly List<Email> _context;

        public RegisterServicesMock()
        {
            _context = new List<Email>();
            _context.Add(new Email()
            {
                emailId = 1,
                address = "marcusv.bianchisantos@gmail.com"
            });

        }
        public void addEmail(Email email)
        {
            _context.Add(email);
        }

        public Email getEmail(string address)
        {
            return _context.Where(x => x.address == address).FirstOrDefault();
        }

        public IList<Email> getEmails()
        {
            return _context.ToList();
        }
    }

}