using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions
{
    public class BindigListData
    {

        public BindigListData()
        {
            this.Data = new BindingList<Person>();
        }


        #region Public Property
        public BindingList<Person> Data
        {
            get;
            set;
        }
        #endregion


        public Person GetActualPerson(Guid faceId)
        {
            Person person = this.Data.FirstOrDefault(item => item.FaceID == faceId);

            //if (person == null)
            //{
            //    person = new Person();
            //    person.FaceID = faceId;
            //    this.Data.Add(person);
            //}

            return person;
        }


        public void AddPerson(Person person)
        {
            this.Data.Add(person);
        }


        public void ClearPersons()
        {
            this.Data.Clear();
        }

        
    }
}
