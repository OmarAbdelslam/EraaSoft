

use BikeStores

select * from sales.order_items

select AVG(list_price)
from production.products

select * from production.products

select * from sales.staffs

select * from sales.orders


select s.first_name+' '+s.last_name as [Full Name],COUNT(o.order_id) as [The Count Of Order]
from sales.staffs as s join sales.orders as o
on s.staff_id = o.staff_id
group by s.first_name+' '+s.last_name;

