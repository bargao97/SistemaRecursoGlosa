
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
    
public partial class PROCEDIMENTO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PROCEDIMENTO()
    {

        this.RECURSO_GLOSA = new HashSet<RECURSO_GLOSA>();

    }


    public int idPROCEDIMENTO { get; set; }

    public Nullable<int> GUIAS_ID_GUIA { get; set; }

    public string DESCRICAO { get; set; }

    public Nullable<int> VLR_INFORMADO { get; set; }

    public Nullable<int> VLR_LIBERADO { get; set; }

    public Nullable<int> VLR_GLOSA { get; set; }

    public Nullable<System.DateTime> DATA_REALIZACAO { get; set; }

    public Nullable<int> COD_GLOSA { get; set; }

    public Nullable<int> TABELA { get; set; }

    public Nullable<int> COD_GLOSA_GUIA { get; set; }



    public virtual GUIAS GUIAS { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RECURSO_GLOSA> RECURSO_GLOSA { get; set; }

}

}
