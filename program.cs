usando o Sistema;
namespace Atividade |
{
    Programa de aulas
    {
        static void Main(string[] args)
        {
            val_pag flutuante;
            Console. WriteLine("Informar Nome");
            string var_nome = Console. Linha de leitura();
            Console. WriteLine("Informar Endereço");
            string var_endereco = Console. Linha de leitura();
            Console. WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console. Linha de leitura();
            if(var_tipo == "f")
            {
                --- Pessoa Física ----
                Pessoa_Fisica pf = nova Pessoa_Fisica();
                pf. nome = var_nome;
                pf. endereco = var_endereco;
                Console. WriteLine("Informar CPF:");
                pf. cpf = Console. Linha de leitura();
                Console. WriteLine("Informar RG:");
                pf. rg = Console. Linha de leitura();
                Console. WriteLine("Informar Valor de Compra:");
                val_pag = flutuação. Analisar(Console. Linha de leitura());
                pf. Pagar_Imposto(val_pag);
                Console. WriteLine("-------- Pessoa Física ---------");
                Console. WriteLine("Nome ..........: " + pf. nomo);
                Console. WriteLine("Endereço ......: " + pf. endereco |);
                Console. WriteLine("CPF ...........: " + pf. cpf);
                Console. WriteLine("RG ............: " + pf. Rg);
                Console. WriteLine("Valor de Compra: " + pf. valor. ToString("C"));
                Console. WriteLine("Imposto .......: " + pf. valor_imposto. ToString("C"));
                Console. WriteLine("Total a Pagar : " + pf. total. ToString("C"));
            }
            if(var_tipo == "j")
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = nova Pessoa_Juridica();
                pj. nome = var_nome;
                pj. endereco = var_endereco;
                Console. WriteLine("Informar CNPJ:");
                pj. cnpj = Console. Linha de leitura();
                Console. WriteLine("Informar IE:");
                pj. ie = Console. Linha de leitura();
                Console. WriteLine("Informar Valor de Compra:");
                val_pag = flutuação. Analisar(Console. Linha de leitura());
                pj. Pagar_Imposto(val_pag);
                Console. WriteLine(-------- Pessoa Jurídica ---------");
                Console. WriteLine("Nome ..........: " + pj. nomo);
                Console. WriteLine("Endereço ......: " + pj. endereco |);
                Console. WriteLine("CNPJ ..........: " + pj. cnpj);
                Console. WriteLine("IE ............: " + pj. Ie);
                Console. WriteLine("Valor de Compra: " + pj. valor. ToString("C"));
                Console. WriteLine("Imposto .......: " + pj. valor_imposto. ToString("C"));
                Console. WriteLine("Total a Pagar : " + pj. total. ToString("C"));

            }
        }
    }
}
