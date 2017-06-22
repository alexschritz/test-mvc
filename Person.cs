using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test.Models
{
    /// <summary>
    /// Perfis dos participantes do portal.
    /// </summary>
    public enum PersonProfile
    {
        [Display(Name ="Inovador")]
        Innovative,

        [Display(Name = "Mentor")]
        Mentor,

        [Display(Name = "Investidor")]
        Investor,

        [Display(Name = "Empreendedor")]
        Entrepreneur
    }

    /// <summary>
    /// Classe que representa as pessoas que participam do portal.
    /// </summary>
    public class Person : ModelBase
    {
        /// <summary>
        /// Toda pessoa tem um usuário no sistema.
        /// </summary>
        [ForeignKey("User")]
        [Required(ErrorMessage = "Escolha o usuário associado a essa pessoa (deve ser criado antes)!")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        /// <summary>
        /// Primeiro nome.
        /// </summary>
        [DisplayName("Primeiro nome")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Sobre nome.
        /// </summary>
        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "O sobrenome é obrigatório!")]
        [StringLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Cargo atual que ocupa.
        /// </summary>
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "O cargo é obrigatório!")]
        [StringLength(255)]
        public string Role { get; set; }

        /// <summary>
        /// Nome da empresa em que trabalha
        /// </summary>
        [DisplayName("Empresa")]
        [StringLength(255)]
        public string Company { get; set; }

        /// <summary>
        /// Número de telefone completo.
        /// </summary>
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "O telefone é obrigatório!")]
        [StringLength(13)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Genero.
        /// </summary>
        [DisplayName("Escolha o sexo (opcional)")]
        public char? Gender { get; set; }

        /// <summary>
        /// Data de nascimento.
        /// </summary>
        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Perfil do usuário.
        /// </summary>
        [DisplayName("Perfil")]
        [Required(ErrorMessage = "Escolha pelo menos uma das opções de perfil!")]
        public PersonProfile Profile { get; set; }

        /// <summary>
        /// Empresas que a pessoa tem interesse, separadas por ";"
        /// </summary>
        [DisplayName("Empresas de interesse")]
        public string CompaniesOfInterest { get; set; }
        [StringLength(1000)]

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Person> Followers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}