//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPnetPhishing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public decimal LineTotal { get; private set; }

        public void SetLineTotal()
        {
            if (this.Qty > 0 && this.Product != null)
            {
                this.LineTotal = this.Qty * this.Product.Price;
            }
        }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
