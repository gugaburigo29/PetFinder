using PetFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Domain.Entities
{
    class Estado : ICamposPadrao
    {
        public int EstadoId { get; set; }
        public int CodigoIbge { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Ddd { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public int UsuarioCriacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UsuarioUltimaAlteracao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DataCriacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DataUltimaAlteracao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
