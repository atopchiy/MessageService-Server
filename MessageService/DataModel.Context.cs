﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MessageServiceEntities : DbContext
    {
        public MessageServiceEntities()
            : base("name=MessageServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Recipient> Recipient { get; set; }
        public virtual DbSet<MessageToRecipient> MessageToRecipient { get; set; }
    }
}