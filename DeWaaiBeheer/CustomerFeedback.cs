
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DeWaaiBeheer
{

    using System;
    using System.Collections.Generic;
    
    public partial class CustomerFeedback
    {

        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public System.DateTime Date { get; set; }

        public int Stars { get; set; }
        public bool Approved { get; set; }
    }

}
