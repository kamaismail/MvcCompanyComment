using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class UserProfileManager
    {
        Repository<Company> repouser = new Repository<Company>();
        Repository<Blog> repouserblog = new Repository<Blog>();
        public List<Company> GetCompanyByMail(string p)
        {
            return repouser.List(x => x.Mail == p);
        }

        public List<Blog> GetBlogByCompany(int id)
        {
            return repouserblog.List(x => x.CompanyID == id);
        }

        public int EditCompany(Company p)
        {
            Company company = repouser.Find(x => x.CompanyID == p.CompanyID);
            company.AboutShort = p.AboutShort;
            company.CompanyName = p.CompanyName;
            company.CompanyImage = p.CompanyImage;
            company.CompanyAbout = p.CompanyAbout;
            company.CompanyTitle = p.CompanyTitle;
            company.Mail = p.Mail;
            company.Password = p.Password;
            company.PhoneNumber = p.PhoneNumber;
            return repouser.Update(company);
        }
    }
}
