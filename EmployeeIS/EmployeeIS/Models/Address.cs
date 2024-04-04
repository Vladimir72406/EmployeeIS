using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
	public class Address
	{
		[DisplayName("ID")]
		public int address_id { get; set; }
		[DisplayName("ID компании")]
		public int corporation_id { get; set; }
		[DisplayName("Тип адреса")]
		public string address_type { get; set; }
		[DisplayName("Страна")]
		public string country { get; set; }
		[DisplayName("Город")]
		public string city { get; set; }
		[DisplayName("Улица")]
		public string street { get; set; }
		[DisplayName("Номер дома")]
		public string home { get; set; }
		[DisplayName("Офис")]
		public string apartment { get; set; }

		public Address(int _address_id, int _corporation_id, string _address_type, string _country, string _city, string _street,
			string _home, string _apartment)
		{
			address_id = _address_id;
			this.corporation_id = _corporation_id;
			address_type = _address_type;
			country = _country;
			city = _city;
			street = _street;
			home = _home;
			apartment = _apartment;
		}
		public Address() { }
		public Address(SqlDataReader reader)
		{
			address_id = Convert.ToInt32(reader["address_id"]);
			corporation_id = Convert.ToInt32(reader["corporation_id"]);
			address_type = reader["address_type"].ToString();
			country = reader["country"].ToString();
			city = reader["city"].ToString();
			street = reader["street"].ToString();
			home = reader["home"].ToString();
			apartment = reader["apartment"].ToString();
		}
	}
}
