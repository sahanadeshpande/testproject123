using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Model;

namespace WebApplication1.Controller
{
    public class PersonController : ApiController
    {
        public static List<Person> persons = new List<Person>
    {
       new Person {FName="abc",LName="abc",DOB="1993/10/10",Address="vijayanagar banglore" },
       new Person {FName="def",LName="def",DOB="1998/11/01",Address="banshankri banglore" },
       new Person {FName="ghi",LName="ghi",DOB="2001/14/09",Address="Rajajinagar banglore" },
       new Person {FName="jkl",LName="jkl",DOB="2015/15/12",Address="mysore" }
    };
        [HttpGet]
        public List<Person> Get()
        {
            return persons;
        }
        [HttpGet]
        public Person Get(string FName)
        {
            return persons.Find((r) => r.FName == FName);
        }
        [HttpPost]
        public bool Post(Person person)
        {
            try
            {
                persons.Add(person);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool Put(Person newperson)
        {
            try
            {
                foreach (var item in persons)
                {
                    if (item.FName == newperson.FName)
                    {
                        item.LName = newperson.LName;
                        item.DOB = newperson.DOB;
                        item.Address = newperson.Address;
                    }

              
                }
                return true;

            }
            catch
            {
                return false;
            }
            
        }

                       
        [HttpDelete]
        public bool Delete(string FName)
        {
            try
            {
                var itemToRemove = persons.Find((r) => r.FName == FName);
                persons.Remove(itemToRemove);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}


