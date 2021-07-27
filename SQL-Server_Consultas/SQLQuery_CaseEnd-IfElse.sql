select *, 
        case 
            when TipoPessoa = 'J' then 'Juridica' 
            when TipoPessoa = 'F' then 'Física' 
            else 'Pessoa indefinida' 
        end 
from clientes