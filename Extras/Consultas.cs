using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistentePessoal.Extras
{
    public class Consultas
    {
        public Consultas() { }

        public string sql_GraficoEntrada { get; private set; } =
        " with " +
        " cte_calendar as ( " +
        " select Data_completa from calendar " +
        " where " +
        " cast(Data_completa as date) >= cast(DATEFROMPARTS(datepart(YEAR, GETDATE()),datepart(MONTH, datediff(m,6, GETDATE())),01) as date)  " +
        " and " +
        " cast(Data_completa as date) <= cast(DATEADD(D,-1, DATEFROMPARTS(datepart(YEAR, GETDATE()),datepart(MONTH, DATEADD(M,1, GETDATE())),01)) as date)  " +
        " ),  " +
        " cte_entrada	as (select " +
        " transact_value, " +
        " date_transact " +
        " from transact t " +
        " where t.removed = 0 and t.id_transact_type = @id " +
        " ),  " +
        " cte_soma_entrada as ( " +
        " select date_transact, sum(transact_value) as Valor from cte_entrada ct " +
        " group by date_transact " +
        " ),  " +
        " cte_result as ( " +
        " select distinct " +
        " datepart(MONTH, c.Data_completa) as 'Mês', coalesce(ct.Valor,0) as Valor, " +
        " ROW_NUMBER() over(partition by datepart(MONTH, c.Data_completa) order by ct.Valor desc) as linha " +
        " from cte_calendar c " +
        " left join cte_soma_entrada ct on(cast(ct.date_transact as date) = cast(c.Data_completa as date))  " +
        " )  " +
        " select ct.Mês , max(ct.Valor) from cte_result ct " +
        " where linha = 1 " +
        " group by ct.Mês, ct.Valor " +
        " order by ct.Mês ";

        public string sqlGrid { get; private set; } =
                    " select t.transact_number as 'Número da Transação', " +
                    " t.transact_value as 'Valor da Transação', " +
                    " it.name_transact_type as 'Movimentação', " +
                    " s.sender_name as 'Remetente',	" +
                    " p.name_portfolio as 'Portifólio', 	" +
                    " t.transact_comment as 'Comentário',	" +
                    " format(t.date_transact, 'dd/MM/yyyy') as 'Data de Transação'" +
                    " from transact t inner join transact_type it on (it.id_transact_type = t.id_transact_type) " +
                    " inner join sender s on (s.id_sender = t.id_sender) " +
                    " inner join portfolio p on (p.id_portfolio = t.id_portfolio) " +
                    " where t.removed = 0 " +
                    " and (@p0 = 0 or (@p1 like '%@r1%' " +
                    " and @p2 like '%@r2%' " +
                    " and @p3 like '%@r3%')) " +
                    " and (@v1 = 0 or it.id_transact_type like '%@v1%') " +
                    " and (@d1 = 0 or datepart(YEAR,t.date_transact) = @d1) " +
                    " order by t.date_transact desc";
    }
}
