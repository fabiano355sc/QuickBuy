﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email{ get; set; }
        public string Senha{ get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos 
        /// </summary>        
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Critica - Email precisa ser preenchido!");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Critica - Senha precisa ser preenchido!");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica - Nome precisa ser preenchido!");
            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Critica - SobreNome precisa ser preenchido!");
        }
    }
}
