using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
	internal class SQL
	{
	}
}

// Второе задание
/*	
		SELECT p.name, c.name
		FROM products p
		LEFT JOIN products_categories pc ON pc.product_id = p.product_id
		LEFT JOIN categories c ON pc.category_id = c.category_id
*/