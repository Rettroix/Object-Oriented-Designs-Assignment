//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IJobviewer
    {
        void jobsToView(int t_jobsIndex);
        void PopulateDataGridView();
        void clearText();
        void Show();
        string GetTxtMachineDescription();
        string GetTxtFaultDescription();
        string GetTxtJobUrgency();
        string GetTxtMachineComplexity();
        string GetTxtHouseNumber();
        string GetTxtStreet();
        string GetTxtTown();
        string GetTxtPostcode();
    }
}
