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
    
    public partial class TABELA_ANS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABELA_ANS()
        {
            this.RECURSO_GLOSA = new HashSet<RECURSO_GLOSA>();
        }
    
        public int COD_ANS { get; set; }
        public Nullable<int> TABELA_OPCOES_ANS_ID_OPCOES { get; set; }
        public string DESCRICAO { get; set; }
        public string RESPOSTA_AUTOMATICA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECURSO_GLOSA> RECURSO_GLOSA { get; set; }
        public virtual TABELA_OPCOES_ANS TABELA_OPCOES_ANS { get; set; }
    }
}