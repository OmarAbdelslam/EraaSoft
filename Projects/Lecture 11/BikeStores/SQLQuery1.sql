
select s.first_name +' '+s.last_name as FullName,Count(o.customer_id)
from sales.customers s join sales.orders o
on s.customer_id = o.customer_id
group by s.first_name+' '+s.last_name

select * from sales.customers