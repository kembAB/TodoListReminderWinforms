using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
   
    public class Task
    {
        private DateTime date;
        private string description;
        private priorityType priority;
        private string priorityString;
       // private priorityType _priorit;

        public Task(DateTime taskdate)
        {
            DefaultValues();
            this.date = taskdate;
        }
        public override string ToString()
        {
            string textOut = string.Format("{0,-30}{1,10}\t\t{2,-16 }\t{3,-20 }",
                date.ToLongDateString(),
                GetTimeString(),
                GetPriorityString(),
                Description);
            return textOut;
        }

        //private object GetPriorityString()
        //{
        //    throw new NotImplementedException();
        //}

        public string GetPriorityString()
        {
           // GET THE PRIORITY TYPE AND RETURN IT 
           // _priorit = priorit;

            switch (priority)
            {

                case priorityType.Normal:
                    priorityString = "normal";
                    break;
                case priorityType.Important:
                    priorityString = "Important";
                    break;
                case priorityType.Less_important:
                    priorityString = "Less Important";
                    break;
                case priorityType.Very_important:
                    priorityString = "very Important";
                    break;
                case priorityType.Not_important:
                    priorityString = " Not Important";
                    break;
            }

           

            return priorityString;
        
           
        }

       

            



        

    public string GetTimeString()
            
    {
            
        return (date.Hour.ToString("00") +":"+ date.Minute.ToString("00")); 
        


    }
    public void DefaultValues()
        {
            date = DateTime.Now;
            description = "string.Empty";
            priority = priorityType.Normal;
        }
        public string Description
        {
            
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return (DateTime.Now==date)  ? DateTime.Now
                   : date;
            }

            set
            {
                date = value;

            }

           
            
           
        }
      
        public string MinuteAndSecondString
        {

            get
            {
                return date.Minute.ToString("00" + date.Second.ToString("00"));
            }
        }
        public priorityType Priority
        {
            get
            {
                return (priorityType.Normal == priority) ? priorityType.Normal : priority;
            }
            set
            {

                priority = value;
            }
        }
      
    }
}
