
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Teste.Database
{

using System;
    using System.Collections.Generic;
    
public partial class PRESTADORES_has_OPERADORAS
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PRESTADORES_has_OPERADORAS()
    {

        this.DEMONSTRATIVO = new HashSet<DEMONSTRATIVO>();

        this.RECURSO_GLOSA = new HashSet<RECURSO_GLOSA>();

    }


    public int PRESTADORES_IDPRESTADOR { get; set; }

    public int OPERADORAS_ID_OPERADORA { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DEMONSTRATIVO> DEMONSTRATIVO { get; set; }

    public virtual OPERADORAS OPERADORAS { get; set; }

    public virtual PRESTADORES PRESTADORES { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RECURSO_GLOSA> RECURSO_GLOSA { get; set; }

}

}
