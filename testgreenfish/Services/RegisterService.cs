
using System.Collections.Generic;
using System.Threading.Tasks;
using testgreenfish.Models;
using testgreenfish.Data;
using testgreenfish.Services.Interfaces;
using System.Linq;

namespace testgreenfish.Services
{
    public class RegisterServices : IRegisterServices
    {
        private readonly ApplicationContext _context;

        public RegisterServices(ApplicationContext context)
        {
            _context = context;
        }
        public void addEmail(Email email)
        {
            _context.Add(email);
            _context.SaveChanges();
        }

        public Email getEmail(string address)
        {
            return _context.Emails.Where(x => x.address == address).FirstOrDefault();
        }

        public IList<Email> getEmails()
        {
            return _context.Emails.ToList();
        }
    }

}