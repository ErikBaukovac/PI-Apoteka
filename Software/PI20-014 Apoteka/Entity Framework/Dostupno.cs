
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PI20_014_Apoteka.Entity_Framework
{

using System;
    using System.Collections.Generic;
    
public partial class Dostupno
{

    public int ID_dobavljaca { get; set; }

    public int ID_lijeka { get; set; }

    public Nullable<int> Kolicina { get; set; }



    public virtual Dobavljac Dobavljac { get; set; }

    public virtual Lijek Lijek { get; set; }

}

}
