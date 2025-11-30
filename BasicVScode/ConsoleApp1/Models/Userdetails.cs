using System;
using System.Collections.Generic;
using System.Data.Common;

namespace user{

    public class userdetail{

        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }   
        public string password { get; set; }
    }
    public class adduser{

     List<userdetail> userls =new List<userdetail>(){
    
    };
    
    
    }
}