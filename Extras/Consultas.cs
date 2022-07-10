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
        " with  " +
        " cte_calendar as ( " +
        " select Data_completa from calendar  " +
        " where  " +
        " cast(Data_completa as date) >= cast(DATEFROMPARTS(datepart(YEAR,GETDATE()),datepart(MONTH,datediff(m,6,GETDATE())),01) as date) " +
        " and  " +
        " cast(Data_completa as date) <= cast(DATEFROMPARTS(datepart(YEAR,GETDATE()),datepart(MONTH,GETDATE()),01) as date) " +
        " ), " +
        " cte_entrada	as (select  " +
        " transact_value, " +
        " datepart(MONTH,date_transact) data_Valor, " +
        " date_transact " +
        " from transact t  " +
        " where t.removed = 0 and t.id_transact_type = @id " +
        " ), " +
        " " +
        " cte_soma_entrada as ( " +
        " select ct.data_Valor, sum(transact_value) as Valor from cte_entrada ct " +
        " group by data_Valor " +
        " ), " +
        " cte_result as ( " +
        " select distinct datepart(MONTH,Data_completa) as 'Mês', coalesce(ct.Valor,0) as Valor from cte_calendar c " +
        " left join cte_soma_entrada ct on (ct.data_Valor = Datepart(MONTH,c.Data_completa)) " +
        " ) " +
        "  " +
        " select * from cte_result " +
        " order by 'Mês' ";

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
                    " and (@v1 = 0 or it.id_transact_type like '%@v1%')" +
                    " order by t.date_transact desc";

    }
}
