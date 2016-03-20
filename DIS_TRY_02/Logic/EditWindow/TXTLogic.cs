using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class TXTLogic : BaseLogic
    {
        public List<ph_tutors> Tutor (int id)
        {
            List<ph_tutors> result = new List<ph_tutors>();
            if (id != 0)
            {
                var tutor = Tutors.GetAll();
                var ph = Ph_Assigments.GetAll();
                var query = ph.FirstOrDefault(f => f.id_person == id);
                 result = tutor.Where(f => query != null && f.id_phdAssignment == query.id_phdAssignment).ToList();
            }
            return result;
        }
        public ph_topics Topic(int id)
        {
            ph_topics result = new ph_topics();
            if (id != 0)
            {
                var topic = Topics.GetAll();
                var ph = Ph_Assigments.GetAll();
                var query = ph.FirstOrDefault(f => f.id_person == id);
                result = topic.FirstOrDefault(f => f.id_phdAssignment == query.id_phdAssignment);
            }
            return result;
        }


    }
}
