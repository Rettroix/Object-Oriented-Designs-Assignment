//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
    public class JobViewerPresenter
    {
        private IJobviewer jobViewerInstance;
        private int jobsIndex;

        public JobViewerPresenter(int rowIndex)
        {
            jobViewerInstance = new JobViewer(this);
            jobsIndex = rowIndex;
            jobViewerInstance.jobsToView(jobsIndex);
            jobViewerInstance.Show();

        }
 

        public void SaveClick()
        {
            Job NewJob = new Job();
            NewJob.MachineDescription = jobViewerInstance.GetTxtMachineDescription();
            NewJob.FaultDescription = jobViewerInstance.GetTxtFaultDescription();

            NewJob.JobUrgency = Convert.ToInt32(jobViewerInstance.GetTxtJobUrgency());
            NewJob.MachineComplexity = Convert.ToInt32(jobViewerInstance.GetTxtMachineComplexity());

            Address NewFactoryLocation = new Address();
            NewFactoryLocation.HouseNumber = jobViewerInstance.GetTxtHouseNumber();
            NewFactoryLocation.Street = jobViewerInstance.GetTxtStreet();
            NewFactoryLocation.Town = jobViewerInstance.GetTxtTown();
            NewFactoryLocation.PostCode = jobViewerInstance.GetTxtPostcode();

            NewJob.FactoryLocation.Add(NewFactoryLocation);

            using (var context = new UniDBContext())
            {

                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;


                NewJob.FactoryLocation.Add(NewFactoryLocation);
                query.ToList()[jobsIndex].Jobs.Add(NewJob);
                context.SaveChanges();
            }
        }

        public List<Job> GetListOfJobs()
        {
            using (var context = new UniDBContext())
            {
                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;

                return query.ToList()[jobsIndex].Jobs.ToList();

            }
        }
    }
}
