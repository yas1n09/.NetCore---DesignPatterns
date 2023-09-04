using DesignPattern.ChainOfResponsibilty.DAL;
using DesignPattern.ChainOfResponsibilty.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı , Müşteriye Talep Ettiği Tutar Ödendi";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName= "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Şube Müdür Yardımcısına Yönlendirildi.";
                context.customerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
