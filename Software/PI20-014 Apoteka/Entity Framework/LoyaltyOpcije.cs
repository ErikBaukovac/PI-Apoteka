
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
    
public partial class LoyaltyOpcije
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoyaltyOpcije()
    {

        this.Korisnik = new HashSet<Korisnik>();

    }


    public int ID { get; set; }

    public string Naziv { get; set; }

    public Nullable<int> Popust { get; set; }

    public int Tvrtka { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Korisnik> Korisnik { get; set; }

    public virtual Tvrtka Tvrtka1 { get; set; }

}

}
