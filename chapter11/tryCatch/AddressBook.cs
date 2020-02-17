using System;
using System.Collections.Generic;

namespace tryCatch
{
    class AddressBook{
        public Dictionary<string,Contact> addressBook = new Dictionary<string,Contact>();

        public void AddContact (Contact personToAdd){
            addressBook.Add(personToAdd.Email, personToAdd);
        }

        public Contact GetByEmail(string email){

               try{ foreach(KeyValuePair<string,Contact> person in addressBook){
                        if(email==person["Email"].Key){

                        }
                    }
               }catch(){


               }

        }
    }
}