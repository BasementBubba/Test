select customers.name
from customers
where customers.id not in (select orders.customerid from orders)