using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CompanyManager
    {
        Repository<Company> repocompany = new Repository<Company>();

        //Tüm firma listesini getirme
        public List<Company> GetAll()
        {
            return repocompany.List();
        }
        // Yeni yazar ekleme işlemi
        public int AddCompanyBL(Company p)
        {
            //Parametreden gönderilen değerlerinin geçerliliğinin kontrolü
            if(p.CompanyName=="" || p.AboutShort=="" || p.CompanyTitle=="")
            {
                return -1;
            }
            return repocompany.Insert(p);
        }

        // Firmayı id değerinw göre edit sayfasına taşıma

        public Company FindCompany(int id)
        {
            return repocompany.Find(x => x.CompanyID == id);
        }

        public int EditCompany(Company p)
        {
            Company company = repocompany.Find(x => x.CompanyID == p.CompanyID);
            company.AboutShort = p.AboutShort;
            company.CompanyName = p.CompanyName;
            company.CompanyImage = p.CompanyImage;
            company.CompanyAbout = p.CompanyAbout;
            company.CompanyTitle = p.CompanyTitle;
            company.Mail = p.Mail;
            company.Password = p.Password;
            company.PhoneNumber = p.PhoneNumber;
            return repocompany.Update(company);
        }
    }
}
