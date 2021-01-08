using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Produtos.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }
    public class Produto : BaseModel
    {
        public Produto()
        {

        }
        
        [Required]
        public long Codigo { get; set; }

        [Required]
        public string Nome { get;  set; }
        [Required]
        public Categoria Categoria { get; set; }

        [Required]
        public Marca Marca { get; set; }

        [Required]
        public double PrecoUnitario { get;  set; }
        public string Unidade { get;  set; }

        public Produto(long codigo , string nome , Categoria categoria , Marca marca , double precoUnitario , string unidade)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Marca = marca;
            this.PrecoUnitario = precoUnitario;
            this.Unidade = unidade;

        }

    }

    public class Categoria : BaseModel
    {
        public Categoria()
        {

        }

        [Required]
        public string Descricao { get; set; }
        [Required]
        public Setor Setor { get; set; }

        public Categoria(string descricao , Setor setor)
        {
            this.Descricao = descricao;
            this.Setor = setor;
        }

    }

    public class Marca : BaseModel
    {
        public Marca()
        {

        }

        public string Descricao { get; set; }

        public Marca(string descricao)
        {
            this.Descricao = descricao;
        }

    }

    public class Setor : BaseModel
    {
        public Setor()
        {

        }

        public string Descricao { get; set; }

        public Setor(string descricao)
        {
            this.Descricao = descricao;
        }

    }

}
