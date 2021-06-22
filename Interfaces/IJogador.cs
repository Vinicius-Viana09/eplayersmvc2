using System.Collections.Generic;
using Eplayers_AspNetCore.Models;

namespace Eplayers_AspNetCore.Interfaces
{
    public interface IJogador
    {
        
        void Criar(Jogador j);
        
        List<Jogador> LerTodos();
        
        void Alterar(Jogador j);
        
        void Deletar(int id);  
    }
}