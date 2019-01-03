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
            jobViewerInstance.jobsToView(rowIndex);
            jobsIndex = rowIndex;
            jobViewerInstance.Show();

        }

        public void SaveClick()
        {
            Job CodeStompJob = new Job();
            CodeStompJob.MachineDescription = jobViewerInstance.GetTxtMachineDescription();
            CodeStompJob.FaultDescription = jobViewerInstance.GetTxtFaultDescription();
            CodeStompJob.JobUrgency = Convert.ToInt32(jobViewerInstance.GetTxtJobUrgency());
            CodeStompJob.MachineComplexity = Convert.ToInt32(jobViewerInstance.GetTxtMachineComplexity());

            Address CodeStompFactoryLocation = new Address();
            CodeStompFactoryLocation.HouseNumber = jobViewerInstance.GetTxtHouseNumber();
            CodeStompFactoryLocation.Street = jobViewerInstance.GetTxtStreet();
            CodeStompFactoryLocation.Town = jobViewerInstance.GetTxtTown();
            CodeStompFactoryLocation.PostCode = jobViewerInstance.GetTxtPostcode();

            CodeStompJob.FactoryLocation.Add(CodeStompFactoryLocation);

            using (var context = new UniDBContext())
            {

                var query = from b in context.ClientCompanys
                            orderby b.ClientID
                            select b;


                CodeStompJob.FactoryLocation.Add(CodeStompFactoryLocation);
                query.ToList()[jobsIndex].Jobs.Add(CodeStompJob);
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
